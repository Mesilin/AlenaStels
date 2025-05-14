using System.Collections;
using System.Windows.Forms;
using AlenaStels.Data;
using Microsoft.EntityFrameworkCore;

namespace AlenaStels
{
    public partial class MainForm : Form
    {
        private EmployeeCatalogForm _emplForm = new();
        private DeviceCatalogForm _deviceForm = new();

        public MainForm()
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            peopleFilterComboBox.SelectedIndexChanged += PeopleFilterComboBoxSelectedIndexChanged;
            workLogGridView.CellEndEdit += WorkLogGridViewCellValueChanged;
            workLogGridView.EditingControlShowing += WorkLogGridViewEditingControlShowing;
        }

        private void PeopleFilterComboBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateDataGridViewColumns();
        }

        private void WorkLogGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Игнорируем клики на заголовках и последнем столбце
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex == workLogGridView.Columns["Total"].Index)
                return;

            // Пересчет суммы для текущей строки
            UpdateRowTotal(e.RowIndex);

            SaveItem(e);

        }

        private void SaveItem(DataGridViewCellEventArgs e)
        {
            if (!int.TryParse(workLogGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out int value))
                return;

            int day = e.ColumnIndex;
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;

            var peopleId = (int?)(peopleFilterComboBox.SelectedValue) ?? 0;

            var devId = (int)workLogGridView.Rows[e.RowIndex].Cells[0].Tag;
            var existing = dataContext.WorkLogs
                .SingleOrDefault(w => w.EmployeeId == peopleId && w.DeviceId == devId && w.Year == year && w.Month == month && w.Day == day);

            if (existing != null)
            {
                existing.Value = value;
                dataContext.SaveChanges();
            }
            else
            {
                var wl = new WorkLog();
                wl.Value = value;
                wl.EmployeeId = peopleId;
                wl.DeviceId = devId;
                wl.Year = year;
                wl.Month = month;
                wl.Day = day;

                dataContext.WorkLogs.Add(wl);
                dataContext.SaveChanges();
            }
        }

        private void UpdateRowTotal(int rowIndex)
        {
            int sum = 0;

            // Суммируем значения со 2-го до предпоследнего столбца
            for (int col = 1; col < workLogGridView.Columns.Count - 1; col++)
            {
                if (int.TryParse(workLogGridView.Rows[rowIndex].Cells[col].Value?.ToString(), out int value))
                {
                    sum += value;
                }
            }

            // Записываем сумму в последнюю ячейку
            workLogGridView.Rows[rowIndex].Cells["Total"].Value = sum;
        }

        private void WorkLogGridViewEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox textBox)
            {
                textBox.KeyPress += (s, ev) =>
                {
                    if (!char.IsControl(ev.KeyChar) && !char.IsDigit(ev.KeyChar))
                    {
                        ev.Handled = true; // Блокируем ввод
                    }
                };
                textBox.TextChanged += (s, args) =>
                {
                    if (workLogGridView.CurrentCell != null)
                    {
                        UpdateRowTotal(workLogGridView.CurrentCell.RowIndex);
                    }
                };
            }
        }

        private void DateTimePicker1_ValueChanged(object? sender, EventArgs e)
        {
            UpdateDataGridViewColumns();
        }

        private void UpdateDataGridViewColumns()
        {
            dataContext.Devices.Load();
            dataContext.Employees.Where(w=>w.IsActive).OrderBy(o => o.FIO).Load();
            dataContext.WorkLogs.Load();
            foreach (var entry in dataContext.ChangeTracker.Entries().ToList())
            {
                entry.Reload();
            }
            employeeBindingSource.DataSource = dataContext.Employees.Local.ToBindingList();

            DateTime selectedDate = dateTimePicker1.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;

            int selectedPeopleId = (int?)(peopleFilterComboBox.SelectedValue) ?? 0;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            workLogGridView.Columns.Clear();
            workLogGridView.Rows.Clear();

            workLogGridView.Columns.Add("Device", "Прибор");
            workLogGridView.Columns["Device"]!.Frozen = true;
            workLogGridView.Columns["Device"]!.Width = 120;
            workLogGridView.Columns["Device"]!.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            workLogGridView.Columns["Device"]!.ReadOnly = true;
            workLogGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            for (int day = 1; day <= daysInMonth; day++)
            {
                string columnName = $"Day{day}";
                workLogGridView.Columns.Add(columnName, $"{day}");
                workLogGridView.Columns[columnName]!.Width = 32;
            }

            workLogGridView.Columns.Add("Total", $"Всего");
            workLogGridView.Columns["Total"]!.Width = 45;
            workLogGridView.Columns["Total"]!.ReadOnly = true;

            var devices = dataContext.Devices
                .AsNoTracking()
                .Where(w => w.IsActive)
                .OrderBy(o => o.SortIndex)
                .ToList();
            var works = dataContext.WorkLogs.AsNoTracking().Where(w => w.EmployeeId == selectedPeopleId && w.Year == year && w.Month == month).ToList();

            int i = 0;
            foreach (var device in devices)
            {
                var deviceWork = works.Where(w => w.DeviceId == device.DeviceId).ToDictionary(w => w.Day);

                workLogGridView.Rows.Add();
                workLogGridView.Rows[i].Cells[0].Tag = device.DeviceId;
                workLogGridView.Rows[i].Cells[0].Value = device.Name;

                int? sum = 0;
                for (var day = 1; day <= daysInMonth; day++)
                {
                    if (!deviceWork.TryGetValue(day, out var val) || !val.Value.HasValue)
                        continue;
                    workLogGridView.Rows[i].Cells[day].Value = val.Value;
                    sum += val.Value;
                }

                workLogGridView.Rows[i].Cells[daysInMonth + 1].Value = sum;
                i++;
            }

            // Настройка первого столбца
            workLogGridView.Columns["Device"]!.DefaultCellStyle.BackColor = Color.LightGray;
            workLogGridView.Columns["Device"]!.DefaultCellStyle.ForeColor = Color.Black;
            workLogGridView.Columns["Total"]!.DefaultCellStyle.BackColor = Color.LightGray;
            workLogGridView.Columns["Total"]!.DefaultCellStyle.ForeColor = Color.Black;

            // Настройка заголовков столбцов
            workLogGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            workLogGridView.EnableHeadersVisualStyles = false; // Отключаем стандартные стили
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _emplForm.DataUpdated += RefreshEmployeeFilter;
            _emplForm.ShowDialog();
        }

        private void RefreshEmployeeFilter()
        {
            UpdateDataGridViewColumns();
        }

        private void приборыToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            _deviceForm.DataUpdated += UpdateDataGridViewColumns;
            _deviceForm.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dataContext = new DataContext();
            UpdateDataGridViewColumns();
        }
        private DataContext dataContext;

        private void openSummaryButton_Click(object sender, EventArgs e)
        {
            int month = dateTimePicker1.Value.Month;
            int year = dateTimePicker1.Value.Year;
            SummaryForm summaryForm = new(year, month);
            summaryForm.ShowDialog();
        }
    }
}