using AlenaStels.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Drawing.Text;

namespace AlenaStels
{
    public partial class MainForm : Form
    {
        private DataContext? dataContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dataContext = new DataContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            //this.dataContext.Database.EnsureCreated();
            this.dataContext.Employees.Load();
            this.dataContext.Devices.Load();

            //this.categoryBindingSource.DataSource = dataContext.Categories.Local.ToBindingList();
        }

        //https://learn.microsoft.com/ru-ru/ef/core/get-started/winforms

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dataContext?.Dispose();
            this.dataContext = null;
        }
    
    }
}
