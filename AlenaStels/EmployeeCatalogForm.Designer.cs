
namespace AlenaStels
{
    partial class EmployeeCatalogForm
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
            employeeGridView = new DataGridView();
            sortIndexDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            FIO = new DataGridViewTextBoxColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            employeeBindingSource = new BindingSource(components);
            panel1 = new Panel();
            buttonSaveEmployees = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)employeeGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // employeeGridView
            // 
            employeeGridView.AllowUserToOrderColumns = true;
            employeeGridView.AutoGenerateColumns = false;
            employeeGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeGridView.Columns.AddRange(new DataGridViewColumn[] { sortIndexDataGridViewTextBoxColumn, Column1, FIO, isActiveDataGridViewCheckBoxColumn });
            employeeGridView.DataSource = employeeBindingSource;
            employeeGridView.Dock = DockStyle.Fill;
            employeeGridView.Location = new Point(0, 0);
            employeeGridView.Name = "employeeGridView";
            employeeGridView.Size = new Size(800, 411);
            employeeGridView.TabIndex = 0;
            // 
            // sortIndexDataGridViewTextBoxColumn
            // 
            sortIndexDataGridViewTextBoxColumn.DataPropertyName = "SortIndex";
            sortIndexDataGridViewTextBoxColumn.HeaderText = "SortIndex";
            sortIndexDataGridViewTextBoxColumn.Name = "sortIndexDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            Column1.DataPropertyName = "EmployeeId";
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // FIO
            // 
            FIO.DataPropertyName = "FIO";
            FIO.HeaderText = "ФИО";
            FIO.Name = "FIO";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "Активность";
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            isActiveDataGridViewCheckBoxColumn.ToolTipText = "Если активно - будет доступно для выбора";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Data.Employee);
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSaveEmployees);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 39);
            panel1.TabIndex = 1;
            // 
            // buttonSaveEmployees
            // 
            buttonSaveEmployees.Location = new Point(704, 10);
            buttonSaveEmployees.Name = "buttonSaveEmployees";
            buttonSaveEmployees.Size = new Size(75, 23);
            buttonSaveEmployees.TabIndex = 0;
            buttonSaveEmployees.Text = "Сохранить";
            buttonSaveEmployees.UseVisualStyleBackColor = true;
            buttonSaveEmployees.Click += buttonSaveEmployees_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(employeeGridView);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 411);
            panel2.TabIndex = 2;
            // 
            // EmployeeCatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeCatalogForm";
            Text = "Сотрудники";
            ((System.ComponentModel.ISupportInitialize)employeeGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView employeeGridView;
        private Panel panel1;
        private Button buttonSaveEmployees;
        private Panel panel2;
        private DataGridViewTextBoxColumn sortIndexDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn Column1;
    }
}