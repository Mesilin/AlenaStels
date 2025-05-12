namespace AlenaStels
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            приборыToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            employeeBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1077, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            справочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сотрудникиToolStripMenuItem, приборыToolStripMenuItem });
            справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            справочникиToolStripMenuItem.Size = new Size(94, 20);
            справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(140, 22);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            сотрудникиToolStripMenuItem.Click += сотрудникиToolStripMenuItem_Click;
            // 
            // приборыToolStripMenuItem
            // 
            приборыToolStripMenuItem.Name = "приборыToolStripMenuItem";
            приборыToolStripMenuItem.Size = new Size(140, 22);
            приборыToolStripMenuItem.Text = "Приборы";
            приборыToolStripMenuItem.Click += приборыToolStripMenuItem_Click;
            // 
            // comboBox1
            // 
            comboBox1.DataSource = employeeBindingSource;
            comboBox1.DisplayMember = "FIO";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 9F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(202, 23);
            comboBox1.TabIndex = 1;
            comboBox1.ValueMember = "EmployeeId";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Data.Employee);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(221, 3);
            dateTimePicker1.MaxDate = new DateTime(2120, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1077, 38);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(347, 3);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 62);
            panel2.Name = "panel2";
            panel2.Size = new Size(1077, 555);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(1077, 555);
            dataGridView1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Stels";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem приборыToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private BindingSource employeeBindingSource;
        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Button button1;
    }
}
