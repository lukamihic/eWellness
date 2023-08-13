namespace eWellness.WinForms
{
    partial class Services
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbServiceCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelSC = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lnkImageURL = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(710, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(321, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usluge";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(13, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(682, 23);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 125);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(683, 84);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Opis";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(13, 231);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(299, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(359, 231);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(302, 23);
            this.txtDuration.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cijena";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "KM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Trajanje";
            // 
            // cmbServiceCategory
            // 
            this.cmbServiceCategory.FormattingEnabled = true;
            this.cmbServiceCategory.Location = new System.Drawing.Point(14, 276);
            this.cmbServiceCategory.Name = "cmbServiceCategory";
            this.cmbServiceCategory.Size = new System.Drawing.Size(681, 23);
            this.cmbServiceCategory.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(308, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "SPASI";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelSC
            // 
            this.labelSC.AutoSize = true;
            this.labelSC.Location = new System.Drawing.Point(12, 259);
            this.labelSC.Name = "labelSC";
            this.labelSC.Size = new System.Drawing.Size(98, 15);
            this.labelSC.TabIndex = 13;
            this.labelSC.Text = "Kategorija usluge";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(14, 327);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(681, 23);
            this.txtImageUrl.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "URL slike";
            // 
            // lnkImageURL
            // 
            this.lnkImageURL.AutoSize = true;
            this.lnkImageURL.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lnkImageURL.Location = new System.Drawing.Point(14, 330);
            this.lnkImageURL.Name = "lnkImageURL";
            this.lnkImageURL.Size = new System.Drawing.Size(61, 15);
            this.lnkImageURL.TabIndex = 16;
            this.lnkImageURL.TabStop = true;
            this.lnkImageURL.Text = "ImageURL";
            this.lnkImageURL.Visible = false;
            this.lnkImageURL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImageURL_LinkClicked);
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 402);
            this.Controls.Add(this.lnkImageURL);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.labelSC);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbServiceCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Name = "Services";
            this.Text = "eWellness :: Admin | Usluge";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Services_FormClosed);
            this.Load += new System.EventHandler(this.Services_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private RichTextBox txtDescription;
        private Label label3;
        private TextBox txtPrice;
        private TextBox txtDuration;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cmbServiceCategory;
        private Button btnSave;
        private Label labelSC;
        private TextBox txtImageUrl;
        private Label label8;
        private LinkLabel lnkImageURL;
    }
}