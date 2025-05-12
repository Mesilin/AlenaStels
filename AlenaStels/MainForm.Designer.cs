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
            menuStrip1 = new MenuStrip();
            справочникиToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            приборыToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            dateTimePicker1 = new DateTimePicker();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { справочникиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(848, 24);
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
            // 
            // приборыToolStripMenuItem
            // 
            приборыToolStripMenuItem.Name = "приборыToolStripMenuItem";
            приборыToolStripMenuItem.Size = new Size(140, 22);
            приборыToolStripMenuItem.Text = "Приборы";
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(848, 70);
            panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Size = new Size(848, 70);
            splitContainer1.SplitterDistance = 617;
            splitContainer1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(78, 3);
            dateTimePicker1.MaxDate = new DateTime(2120, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(137, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 503);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Stels";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem приборыToolStripMenuItem;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private DateTimePicker dateTimePicker1;
    }
}
