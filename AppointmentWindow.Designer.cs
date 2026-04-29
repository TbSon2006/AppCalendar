namespace AppCalendar
{
    partial class AppointmentWindow
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
            txtName = new TextBox();
            txtLocation = new TextBox();
            dtpStart = new DateTimePicker();
            dtpEnd = new DateTimePicker();
            btnSave = new Button();
            btnCancel = new Button();
            lblName = new Label();
            lblEnd = new Label();
            lblStart = new Label();
            lblLocation = new Label();
            chkIsGroupMeeting = new CheckBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(355, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(250, 27);
            txtName.TabIndex = 0;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(355, 104);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(250, 27);
            txtLocation.TabIndex = 1;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(355, 181);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(250, 27);
            dtpStart.TabIndex = 2;
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(355, 259);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(250, 27);
            dtpEnd.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.LimeGreen;
            btnSave.Location = new Point(67, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 46);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Location = new Point(475, 358);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 46);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11F);
            lblName.Location = new Point(67, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 25);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 11F);
            lblEnd.Location = new Point(67, 261);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(48, 25);
            lblEnd.TabIndex = 7;
            lblEnd.Text = "End:";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Segoe UI", 11F);
            lblStart.Location = new Point(67, 183);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(54, 25);
            lblStart.TabIndex = 8;
            lblStart.Text = "Start:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 11F);
            lblLocation.Location = new Point(67, 106);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(88, 25);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "Location:";
            // 
            // chkIsGroupMeeting
            // 
            chkIsGroupMeeting.AutoSize = true;
            chkIsGroupMeeting.Location = new Point(275, 318);
            chkIsGroupMeeting.Name = "chkIsGroupMeeting";
            chkIsGroupMeeting.Size = new Size(131, 24);
            chkIsGroupMeeting.TabIndex = 11;
            chkIsGroupMeeting.Text = "Group Meeting";
            chkIsGroupMeeting.UseVisualStyleBackColor = true;
            // 
            // AppointmentWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 428);
            Controls.Add(chkIsGroupMeeting);
            Controls.Add(lblLocation);
            Controls.Add(lblStart);
            Controls.Add(lblEnd);
            Controls.Add(lblName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(dtpEnd);
            Controls.Add(dtpStart);
            Controls.Add(txtLocation);
            Controls.Add(txtName);
            Name = "AppointmentWindow";
            Text = "AppointmentWindow";
            Load += AppointmentWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtLocation;
        private DateTimePicker dtpStart;
        private DateTimePicker dtpEnd;
        private Button btnSave;
        private Button btnCancel;
        private Label lblName;
        private Label lblEnd;
        private Label lblStart;
        private Label lblLocation;
        private CheckBox chkIsGroupMeeting;
    }
}