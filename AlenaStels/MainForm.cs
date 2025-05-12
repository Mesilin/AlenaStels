using AlenaStels.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Windows.Forms;

namespace AlenaStels
{
    public partial class MainForm : Form
    {
        private EmployeeCatalogForm EmplForm = new();
        private DeviceCatalogForm DeviceForm = new();

        public MainForm()
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.EditingControlShowing += DataGridView1_EditingControlShowing;
        }

        private void ComboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {
            UpdateDataGridViewColumns();
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Игнорируем клики на заголовках и последнем столбце
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.ColumnIndex == dataGridView1.Columns["Total"].Index)
                return;

            // Пересчет суммы для текущей строки
            UpdateRowTotal(e.RowIndex);
        }

        private void UpdateRowTotal(int rowIndex)
        {
            int sum = 0;

            // Суммируем значения со 2-го до предпоследнего столбца
            for (int col = 1; col < dataGridView1.Columns.Count - 1; col++)
            {
                if (int.TryParse(dataGridView1.Rows[rowIndex].Cells[col].Value?.ToString(), out int value))
                {
                    sum += value;
                }
            }

            // Записываем сумму в последнюю ячейку
            dataGridView1.Rows[rowIndex].Cells["Total"].Value = sum;
        }
        private void DataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
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
                    if (dataGridView1.CurrentCell != null)
                    {
                        UpdateRowTotal(dataGridView1.CurrentCell.RowIndex);
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
            DateTime selectedDate = dateTimePicker1.Value;
            int year = selectedDate.Year;
            int month = selectedDate.Month;

            int selectedPeopleId = (int)comboBox1.SelectedValue!;

            int daysInMonth = DateTime.DaysInMonth(year, month);
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Device", $"Прибор");

            dataGridView1.Columns["Device"].Width = 120;
            //dataGridView1.Columns["Device"]
            dataGridView1.Columns["Device"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns["Device"].ReadOnly = true;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            for (int day = 1; day <= daysInMonth; day++)
            {
                string columnName = $"Day{day}";
                dataGridView1.Columns.Add(columnName, $"{day}");
                dataGridView1.Columns[columnName].Width = 32;
            }

            dataGridView1.Columns.Add("Total", $"Всего");
            dataGridView1.Columns["Total"].Width = 45;
            dataGridView1.Columns["Total"].ReadOnly = true;

            var devices = dataContext.Devices.Where(w => w.IsActive).OrderBy(o => o.SortIndex).ToList();
            var works = dataContext.WorkLogs
                .Where(w => w.EmployeeId == selectedPeopleId && w.Year == year && w.Month == month).ToList();
            
            int i = 0;
            foreach (var device in devices)
            {
                var deviceWork = works.Where(w => w.DeviceId == device.DeviceId).ToDictionary(w => w.Day);

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = device.Name;

                int? sum = 0;
                for (var day = 1; day <= daysInMonth; day++)
                {
                    if (deviceWork.TryGetValue(day, out var val) && val.Value.HasValue)
                    {
                        dataGridView1.Rows[i].Cells[day].Value = val.Value;
                        sum += val.Value;
                    }
                }

                dataGridView1.Rows[i].Cells[daysInMonth + 1].Value = sum;
                i++;
            }
            // Настройка первого столбца
            dataGridView1.Columns["Device"].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns["Device"].DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.Columns["Total"].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.Columns["Total"].DefaultCellStyle.ForeColor = Color.Black;

            // Настройка заголовков строк
            dataGridView1.RowHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Gray; // Цвет при выделении

            // Настройка заголовков столбцов
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.EnableHeadersVisualStyles = false; // Отключаем стандартные стили
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmplForm.DataUpdated += RefreshEmployeeFilter;

            EmplForm.ShowDialog();
        }

        private void RefreshEmployeeFilter()
        {
            this.dataContext.Employees.OrderBy(o=>o.SortIndex).Load();
            this.employeeBindingSource.DataSource = dataContext.Employees.Local.ToBindingList();
        }

        private void приборыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeviceForm.ShowDialog();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dataContext = new DataContext();
            this.dataContext.Employees.OrderBy(o => o.SortIndex).Load();
            this.employeeBindingSource.DataSource = dataContext.Employees.Local.ToBindingList();
            UpdateDataGridViewColumns();
        }
        private DataContext dataContext;

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
