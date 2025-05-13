using AlenaStels.Data;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace AlenaStels
{
    public partial class EmployeeCatalogForm : Form
    {

        private void buttonSaveEmployees_Click(object sender, EventArgs e)
        {
            this.dataContext!.SaveChanges();
            this.employeeGridView.Refresh();
            DataUpdated.Invoke();
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

        public event Action DataUpdated;
    }
}
