namespace eWellness.WinForms
{
    partial class Login
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
            this.cmbKorisnik = new System.Windows.Forms.ComboBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.lblKorisnik = new System.Windows.Forms.Label();
            this.lblUcitavanje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbKorisnik
            // 
            this.cmbKorisnik.Enabled = false;
            this.cmbKorisnik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbKorisnik.FormattingEnabled = true;
            this.cmbKorisnik.Location = new System.Drawing.Point(22, 41);
            this.cmbKorisnik.Name = "cmbKorisnik";
            this.cmbKorisnik.Size = new System.Drawing.Size(442, 38);
            this.cmbKorisnik.TabIndex = 0;
            // 
            // btnPrijava
            // 
            this.btnPrijava.Enabled = false;
            this.btnPrijava.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrijava.Location = new System.Drawing.Point(156, 87);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(174, 40);
            this.btnPrijava.TabIndex = 1;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // lblKorisnik
            // 
            this.lblKorisnik.AutoSize = true;
            this.lblKorisnik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKorisnik.Location = new System.Drawing.Point(22, 13);
            this.lblKorisnik.Name = "lblKorisnik";
            this.lblKorisnik.Size = new System.Drawing.Size(79, 25);
            this.lblKorisnik.TabIndex = 2;
            this.lblKorisnik.Text = "Korisnik";
            // 
            // lblUcitavanje
            // 
            this.lblUcitavanje.AutoSize = true;
            this.lblUcitavanje.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUcitavanje.Location = new System.Drawing.Point(142, 44);
            this.lblUcitavanje.Name = "lblUcitavanje";
            this.lblUcitavanje.Size = new System.Drawing.Size(203, 30);
            this.lblUcitavanje.TabIndex = 3;
            this.lblUcitavanje.Text = "Učitavam podatke...";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 137);
            this.Controls.Add(this.lblUcitavanje);
            this.Controls.Add(this.lblKorisnik);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.cmbKorisnik);
            this.Name = "Login";
            this.Text = "eWellness :: Admin | Prijava";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbKorisnik;
        private Button btnPrijava;
        private Label lblKorisnik;
        private Label lblUcitavanje;
    }
}