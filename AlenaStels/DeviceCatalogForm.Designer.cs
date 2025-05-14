
namespace AlenaStels
{
    partial class DeviceCatalogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            deviceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            sortIndexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deviceBindingSource = new BindingSource(components);
            panel1 = new Panel();
            buttonSaveDevice = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deviceBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { deviceIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, isActiveDataGridViewCheckBoxColumn, sortIndexDataGridViewTextBoxColumn });
            dataGridView1.DataSource = deviceBindingSource;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(800, 411);
            dataGridView1.TabIndex = 0;
            // 
            // deviceIdDataGridViewTextBoxColumn
            // 
            deviceIdDataGridViewTextBoxColumn.DataPropertyName = "DeviceId";
            deviceIdDataGridViewTextBoxColumn.HeaderText = "DeviceId";
            deviceIdDataGridViewTextBoxColumn.Name = "deviceIdDataGridViewTextBoxColumn";
            deviceIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "Активность";
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            isActiveDataGridViewCheckBoxColumn.ToolTipText = "Если активно - будет доступно для выбора";
            // 
            // sortIndexDataGridViewTextBoxColumn
            // 
            sortIndexDataGridViewTextBoxColumn.DataPropertyName = "SortIndex";
            sortIndexDataGridViewTextBoxColumn.HeaderText = "SortIndex";
            sortIndexDataGridViewTextBoxColumn.Name = "sortIndexDataGridViewTextBoxColumn";
            sortIndexDataGridViewTextBoxColumn.ToolTipText = "Чем меньше индекс сортировки - тем выше в таблице будет этот прибор";
            // 
            // deviceBindingSource
            // 
            deviceBindingSource.DataSource = typeof(Data.Device);
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSaveDevice);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 39);
            panel1.TabIndex = 1;
            // 
            // buttonSaveDevice
            // 
            buttonSaveDevice.Location = new Point(704, 10);
            buttonSaveDevice.Name = "buttonSaveDevice";
            buttonSaveDevice.Size = new Size(75, 23);
            buttonSaveDevice.TabIndex = 0;
            buttonSaveDevice.Text = "Сохранить";
            buttonSaveDevice.UseVisualStyleBackColor = true;
            buttonSaveDevice.Click += buttonSaveDevice_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 411);
            panel2.TabIndex = 2;
            // 
            // DeviceCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DeviceCatalogForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Приборы";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)deviceBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private BindingSource deviceBindingSource;
        private Panel panel1;
        private Button buttonSaveDevice;
        private Panel panel2;
        private DataGridViewTextBoxColumn deviceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn sortIndexDataGridViewTextBoxColumn;
    }
}