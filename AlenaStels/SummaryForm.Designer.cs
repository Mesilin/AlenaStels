namespace AlenaStels
{
    partial class SummaryForm
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
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            summaryGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)summaryGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(887, 34);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "MMMM yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(12, 5);
            dateTimePicker1.MaxDate = new DateTime(2120, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(125, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(887, 34);
            label1.TabIndex = 0;
            label1.Text = "Сводка за май 2025";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // summaryGridView
            // 
            summaryGridView.AllowUserToAddRows = false;
            summaryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            summaryGridView.Dock = DockStyle.Fill;
            summaryGridView.Location = new Point(0, 34);
            summaryGridView.Name = "summaryGridView";
            summaryGridView.ReadOnly = true;
            summaryGridView.RowHeadersVisible = false;
            summaryGridView.Size = new Size(887, 636);
            summaryGridView.TabIndex = 1;
            // 
            // SummaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 670);
            Controls.Add(summaryGridView);
            Controls.Add(panel1);
            Name = "SummaryForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Сводка";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)summaryGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView summaryGridView;
        private DateTimePicker dateTimePicker1;
    }
}