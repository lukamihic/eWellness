namespace eWellness.WinForms
{
    partial class SpecialOffers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblExpired = new System.Windows.Forms.Label();
            this.dtpOfferExpirationDate = new System.Windows.Forms.DateTimePicker();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 55);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(321, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popusti";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 143);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(683, 23);
            this.txtDescription.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(11, 82);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(684, 23);
            this.txtName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "Opis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 19;
            this.label2.Text = "Naziv";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(294, 257);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "SPASI";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblExpired
            // 
            this.lblExpired.AutoSize = true;
            this.lblExpired.ForeColor = System.Drawing.Color.Red;
            this.lblExpired.Location = new System.Drawing.Point(259, 239);
            this.lblExpired.Name = "lblExpired";
            this.lblExpired.Size = new System.Drawing.Size(182, 15);
            this.lblExpired.TabIndex = 29;
            this.lblExpired.Text = "UPOZORENJE: PONUDA ISTEKLA!";
            this.lblExpired.Visible = false;
            // 
            // dtpOfferExpirationDate
            // 
            this.dtpOfferExpirationDate.Enabled = false;
            this.dtpOfferExpirationDate.Location = new System.Drawing.Point(216, 186);
            this.dtpOfferExpirationDate.Name = "dtpOfferExpirationDate";
            this.dtpOfferExpirationDate.Size = new System.Drawing.Size(479, 23);
            this.dtpOfferExpirationDate.TabIndex = 28;
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Location = new System.Drawing.Point(12, 189);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(184, 19);
            this.cbIsActive.TabIndex = 27;
            this.cbIsActive.Text = "Specijalna ponuda aktivna do:";
            this.cbIsActive.UseVisualStyleBackColor = true;
            this.cbIsActive.CheckedChanged += new System.EventHandler(this.cbIsActive_CheckedChanged);
            // 
            // SpecialOffers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 304);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblExpired);
            this.Controls.Add(this.dtpOfferExpirationDate);
            this.Controls.Add(this.cbIsActive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Name = "SpecialOffers";
            this.Text = "eWellness :: Admin | Popusti";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpecialOffers_FormClosed);
            this.Load += new System.EventHandler(this.SpecialOffers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label label5;
        private Label label2;
        private Button btnSave;
        private Label lblExpired;
        private DateTimePicker dtpOfferExpirationDate;
        private CheckBox cbIsActive;
    }
}