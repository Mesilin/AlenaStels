using AlenaStels.Data;
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;

namespace AlenaStels
{
    public partial class DeviceCatalogForm : Form
    {
        private void buttonSaveDevice_Click(object sender, EventArgs e)
        {
            this.dataContext!.SaveChanges();
            this.dataGridView1.Refresh();
            DataUpdated?.Invoke();
        }

        public DeviceCatalogForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.dataContext = new DataContext();
            this.dataContext.Devices.OrderBy(o => o.SortIndex).Load();
            this.deviceBindingSource.DataSource = dataContext.Devices.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            this.dataContext?.Dispose();
            this.dataContext = null;
        }

        private DataContext? dataContext;

        public event Action? DataUpdated;
    }
}
