using AlenaStels.Data;
using Microsoft.EntityFrameworkCore;

namespace AlenaStels
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(int year, int month)
        {
            InitializeComponent();
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            this.year = year;
            this.month = month;
            monthDictionary = new Dictionary<int, string>
            {
                {1, "Январь" },
                {2, "Февраль"},
                {3,"Март"},
                {4,"Апрель"},
                {5,"Май"},
                {6,"Июнь"},
                {7,"Июль"},
                {8,"Август"},
                {9,"Сентябрь"},
                {10,"Октябрь"},
                {11,"Ноябрь"},
                {12,"Декабрь"}
            };
        }
        private void DateTimePicker1_ValueChanged(object? sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            year = selectedDate.Year;
            month = selectedDate.Month;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            summaryGridView.Columns.Clear();
            summaryGridView.Rows.Clear();

            using var dc = new DataContext();

            var work = dc.WorkLogs
                .Include(i => i.Device)
                .Include(i => i.Employee)
                .Where(w => w.Year == year && w.Month == month).ToList();

            this.label1.Text = $"Сводка за {monthDictionary[month]} {year}";

            var deviceStatistics = work
                .GroupBy(w => new { w.DeviceId, w.Device.Name })
                .Select(g => new
                {
                    DeviceId = g.Key.DeviceId,
                    DeviceName = g.Key.Name,
                    TotalValue = g.Sum(x => x.Value) ?? 0
                })
                .OrderByDescending(x => x.TotalValue)
                .ToList();

            var peoples = work.Select(s => s.Employee)
                .Distinct().OrderBy(o => o.FIO)
                .Select(s => new { s.EmployeeId, s.FIO });


            summaryGridView.Columns.Add("Device", "Прибор");
            summaryGridView.Columns["Device"]!.Frozen = true;
            summaryGridView.Columns["Device"]!.Width = 120;
            summaryGridView.Columns["Device"]!.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            summaryGridView.Columns["Device"]!.ReadOnly = true;
            summaryGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            summaryGridView.Columns.Add("Total", $"Всего");
            summaryGridView.Columns["Total"]!.Width = 45;

            foreach (var people in peoples)
            {
                string columnName = $"{people.EmployeeId}";
                summaryGridView.Columns.Add(columnName, $"{people.FIO}");
                summaryGridView.Columns[columnName]!.Width = 80;
            }

            int i = 0;
            foreach (var item in deviceStatistics)
            {
                summaryGridView.Rows.Add();
                summaryGridView.Rows[i].Cells[0].Tag = item.DeviceId;
                summaryGridView.Rows[i].Cells[0].Value = item.DeviceName;
                summaryGridView.Rows[i].Cells[1].Value = item.TotalValue;

                foreach (var people in peoples)
                {
                    var val = work.Where(w => w.DeviceId == item.DeviceId && w.EmployeeId == people.EmployeeId)
                        .Sum(s => s.Value) ?? 0;

                    summaryGridView.Rows[i].Cells[$"{people.EmployeeId}"].Value = val;
                }

                i++;
            }
            summaryGridView.Columns["Device"]!.DefaultCellStyle.BackColor = Color.LightGray;
            summaryGridView.Columns["Device"]!.DefaultCellStyle.ForeColor = Color.Black;
            summaryGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            summaryGridView.EnableHeadersVisualStyles = false; // Отключаем стандартные стили
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dateTimePicker1.Value = new DateTime(year, month, 15);
        }
        
        private int year;
        private int month;
        private IQueryable<IGrouping<Device, WorkLog>> groupWl;
        private readonly Dictionary<int, string> monthDictionary;
    }
}