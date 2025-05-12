using AlenaStels.Data;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace AlenaStels
{
    public partial class EmployeeCatalogForm : Form
    {
        public event Action DataUpdated;

        private void buttonSaveEmployees_Click(object sender, EventArgs e)
        {
            this.dataContext!.SaveChanges();
            this.dataGridView1.Refresh();
            DataUpdated?.Invoke();
        }

        public EmployeeCatalogForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dataContext = new DataContext();
            this.dataContext.Employees.Load();
            this.employeeBindingSource.DataSource = dataContext.Employees.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dataContext?.Dispose();
            this.dataContext = null;
        }

        private DataContext? dataContext;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
