namespace eWellness.WinForms
{
    partial class Clients
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblLastInfo = new System.Windows.Forms.Label();
            this.cbIsMember = new System.Windows.Forms.CheckBox();
            this.dtpMembershipExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpired = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblLastAppointment = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ime i prezime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 55);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(321, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klijenti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefon";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Pol";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Datum rođenja";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 23);
            this.txtName.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(372, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(323, 23);
            this.txtEmail.TabIndex = 16;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(373, 147);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(323, 23);
            this.txtAddress.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(12, 147);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(312, 23);
            this.txtPhone.TabIndex = 17;
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(12, 212);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(311, 23);
            this.dtpDateOfBirth.TabIndex = 19;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "",
            "Muško",
            "Žensko"});
            this.cmbGender.Location = new System.Drawing.Point(374, 212);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(322, 23);
            this.cmbGender.TabIndex = 20;
            // 
            // lblLastInfo
            // 
            this.lblLastInfo.AutoSize = true;
            this.lblLastInfo.Location = new System.Drawing.Point(376, 262);
            this.lblLastInfo.Name = "lblLastInfo";
            this.lblLastInfo.Size = new System.Drawing.Size(277, 15);
            this.lblLastInfo.TabIndex = 21;
            this.lblLastInfo.Text = "Posljednji termin:                          (ukupno         puta)";
            // 
            // cbIsMember
            // 
            this.cbIsMember.AutoSize = true;
            this.cbIsMember.Location = new System.Drawing.Point(12, 261);
            this.cbIsMember.Name = "cbIsMember";
            this.cbIsMember.Size = new System.Drawing.Size(70, 19);
            this.cbIsMember.TabIndex = 22;
            this.cbIsMember.Text = "Član do:";
            this.cbIsMember.UseVisualStyleBackColor = true;
            this.cbIsMember.CheckedChanged += new System.EventHandler(this.cbIsMember_CheckedChanged);
            // 
            // dtpMembershipExpirationDate
            // 
            this.dtpMembershipExpirationDate.Enabled = false;
            this.dtpMembershipExpirationDate.Location = new System.Drawing.Point(80, 258);
            this.dtpMembershipExpirationDate.Name = "dtpMembershipExpirationDate";
            this.dtpMembershipExpirationDate.Size = new System.Drawing.Size(243, 23);
            this.dtpMembershipExpirationDate.TabIndex = 23;
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.ForeColor = System.Drawing.Color.Red;
            this.lblExpired.Location = new System.Drawing.Point(251, 307);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(199, 15);
            this.lblExpired.TabIndex = 24;
            this.lblExpired.Text = "UPOZORENJE: ČLANARINA ISTEKLA!";
            this.lblExpired.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(294, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "SPASI";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblLastAppointment
            // 
            this.lblLastAppointment.AutoSize = true;
            this.lblLastAppointment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblLastAppointment.Location = new System.Drawing.Point(474, 262);
            this.lblLastAppointment.Name = "lblLastAppointment";
            this.lblLastAppointment.Size = new System.Drawing.Size(51, 15);
            this.lblLastAppointment.TabIndex = 27;
            this.lblLastAppointment.Text = "lastAppt";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblN.Location = new System.Drawing.Point(595, 262);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(23, 15);
            this.lblN.TabIndex = 28;
            this.lblN.Text = "XX";
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 373);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblLastAppointment);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.dtpMembershipExpirationDate);
            this.Controls.Add(this.cbIsMember);
            this.Controls.Add(this.lblLastInfo);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Clients";
            this.Text = "eWellness :: Admin | Klijenti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Clients_FormClosed);
            this.Load += new System.EventHandler(this.Clients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cmbGender;
        private Label lblLastInfo;
        private CheckBox cbIsMember;
        private DateTimePicker dtpMembershipExpirationDate;
        private Label lblExpired;
        private Button btnSave;
        private Label lblLastAppointment;
        private Label lblN;
    }
}