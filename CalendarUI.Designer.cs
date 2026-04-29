namespace AppCalendar
{
    partial class CalendarUI
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
            dgvSchedule = new DataGridView();
            btnAddAppt = new Button();
            monthCalendar = new MonthCalendar();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            SuspendLayout();
            // 
            // dgvSchedule
            // 
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSchedule.Location = new Point(429, 30);
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.RowHeadersWidth = 51;
            dgvSchedule.Size = new Size(341, 355);
            dgvSchedule.TabIndex = 0;
            // 
            // btnAddAppt
            // 
            btnAddAppt.BackColor = Color.LimeGreen;
            btnAddAppt.Location = new Point(89, 407);
            btnAddAppt.Name = "btnAddAppt";
            btnAddAppt.Size = new Size(175, 53);
            btnAddAppt.TabIndex = 1;
            btnAddAppt.Text = "Add";
            btnAddAppt.UseVisualStyleBackColor = false;
            btnAddAppt.Click += btnAddAppt_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(71, 99);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 2;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Red;
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(532, 407);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(175, 52);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CalendarUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 472);
            Controls.Add(btnRefresh);
            Controls.Add(monthCalendar);
            Controls.Add(btnAddAppt);
            Controls.Add(dgvSchedule);
            Name = "CalendarUI";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSchedule;
        private Button btnAddAppt;
        private MonthCalendar monthCalendar;
        private Button btnRefresh;
    }
}
