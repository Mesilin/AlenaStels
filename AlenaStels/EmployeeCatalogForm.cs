using AlenaStels.Data;
using Microsoft.EntityFrameworkCore;

namespace AlenaStels
{
    public partial class EmployeeCatalogForm : Form
    {
        private void Save()
        {
            if (!dc.ChangeTracker.HasChanges())
                return;
            dc.SaveChanges();
            this.employeeGridView.Refresh();
            DataUpdated.Invoke();
        }

        private void buttonSaveEmployees_Click(object sender, EventArgs e)
        {
            Save();
        }

        public EmployeeCatalogForm()
        {
            InitializeComponent();
            //employeeGridView.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
        }

        //void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex < 0 || e.ColumnIndex !=
        //        employeeGridView.Columns["DeleteBtnColumn"]?.Index) return;

        //    if (MessageBox.Show("Удалить сотрудника? Сведения о количестве приборов также будут удалены.", "Подтверждение",
        //            MessageBoxButtons.YesNo) == DialogResult.No)
        //        return;

        //    var id = (int)employeeGridView.Rows[e.RowIndex].Cells["EmployeeId"].Value;

        //    dc.Database.ExecuteSqlRaw("DELETE FROM Employees WHERE EmployeeId = {0}", id);
        //    employeeGridView.Rows.Remove(employeeGridView.Rows[e.RowIndex]);
        //    DataUpdated.Invoke();
        //}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            dc = new DataContext();
            dc.Employees.Load();
            this.employeeBindingSource.DataSource = dc.Employees.Local.ToBindingList();

            //if (employeeGridView.Columns["DeleteBtnColumn"] == null)
            //{
            //    DataGridViewButtonColumn buttonColumn =
            //        new DataGridViewButtonColumn();
            //    buttonColumn.HeaderText = "";
            //    buttonColumn.Name = "DeleteBtnColumn";
            //    buttonColumn.Text = "Удалить";
            //    buttonColumn.UseColumnTextForButtonValue = true;
            //    employeeGridView.Columns.Add(buttonColumn);
            //}
        }


        private DataContext dc;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            dc?.Dispose();
            base.OnFormClosing(e);
        }

        private void employeeGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public event Action DataUpdated;
    }
}
