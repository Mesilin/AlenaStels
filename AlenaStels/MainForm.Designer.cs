﻿namespace AlenaStels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            приборыToolStripMenuItem = new ToolStripMenuItem();
            peopleFilterComboBox = new ComboBox();
            employeeBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            openSummaryButton = new Button();
            workLogGridView = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)workLogGridView).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Wheat;
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1241, 24);
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
            // peopleFilterComboBox
            // 
            peopleFilterComboBox.DataSource = employeeBindingSource;
            peopleFilterComboBox.DisplayMember = "FIO";
            peopleFilterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            peopleFilterComboBox.Font = new Font("Segoe UI", 9F);
            peopleFilterComboBox.FormattingEnabled = true;
            peopleFilterComboBox.Location = new Point(12, 6);
            peopleFilterComboBox.Name = "peopleFilterComboBox";
            peopleFilterComboBox.Size = new Size(202, 23);
            peopleFilterComboBox.TabIndex = 1;
            peopleFilterComboBox.ValueMember = "EmployeeId";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Data.Employee);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(231, 6);
            dateTimePicker1.MaxDate = new DateTime(2120, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(openSummaryButton);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(peopleFilterComboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 38);
            panel1.TabIndex = 2;
            // 
            // openSummaryButton
            // 
            openSummaryButton.Location = new Point(358, 6);
            openSummaryButton.Name = "openSummaryButton";
            openSummaryButton.Size = new Size(75, 23);
            openSummaryButton.TabIndex = 2;
            openSummaryButton.Text = "Сводка";
            openSummaryButton.UseVisualStyleBackColor = true;
            openSummaryButton.Click += openSummaryButton_Click;
            // 
            // workLogGridView
            // 
            workLogGridView.AllowUserToAddRows = false;
            workLogGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            workLogGridView.Dock = DockStyle.Fill;
            workLogGridView.Location = new Point(0, 62);
            workLogGridView.Name = "workLogGridView";
            workLogGridView.RowHeadersVisible = false;
            workLogGridView.Size = new Size(1241, 582);
            workLogGridView.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 644);
            Controls.Add(workLogGridView);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stels";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)workLogGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem приборыToolStripMenuItem;
        private DateTimePicker dateTimePicker1;
        private ComboBox peopleFilterComboBox;
        private BindingSource employeeBindingSource;
        private Panel panel1;
        private DataGridView workLogGridView;
        private Button openSummaryButton;
    }
}
