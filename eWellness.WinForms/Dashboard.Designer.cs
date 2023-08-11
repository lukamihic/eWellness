namespace eWellness.WinForms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblPayments = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblClients = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblServices = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalji = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lnkServiceCategories = new System.Windows.Forms.LinkLabel();
            this.lnkPaymentMethods = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.label1.Location = new System.Drawing.Point(574, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dobro došli,";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lblUser.Location = new System.Drawing.Point(657, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(78, 15);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "((username))";
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lblLogout.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lblLogout.Location = new System.Drawing.Point(6, 9);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(55, 15);
            this.lblLogout.TabIndex = 2;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Odjava ×";
            this.lblLogout.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 528);
            this.panel1.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.lblPayments);
            this.panel10.Controls.Add(this.pictureBox6);
            this.panel10.Location = new System.Drawing.Point(0, 392);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(123, 77);
            this.panel10.TabIndex = 14;
            this.panel10.Click += new System.EventHandler(this.panel10_Click);
            // 
            // lblPayments
            // 
            this.lblPayments.AutoSize = true;
            this.lblPayments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPayments.Location = new System.Drawing.Point(34, 57);
            this.lblPayments.Name = "lblPayments";
            this.lblPayments.Size = new System.Drawing.Size(41, 15);
            this.lblPayments.TabIndex = 9;
            this.lblPayments.Text = "Uplate";
            this.lblPayments.Click += new System.EventHandler(this.lblPayments_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(32, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(49, 43);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.lblDiscount);
            this.panel9.Controls.Add(this.pictureBox5);
            this.panel9.Location = new System.Drawing.Point(0, 313);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(118, 80);
            this.panel9.TabIndex = 12;
            this.panel9.Click += new System.EventHandler(this.panel9_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDiscount.Location = new System.Drawing.Point(32, 56);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(47, 15);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Popusti";
            this.lblDiscount.Click += new System.EventHandler(this.lblDiscount_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(31, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(48, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblAppointments);
            this.panel8.Controls.Add(this.pictureBox3);
            this.panel8.Location = new System.Drawing.Point(0, 156);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(124, 79);
            this.panel8.TabIndex = 10;
            this.panel8.Click += new System.EventHandler(this.panel8_Click);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAppointments.Location = new System.Drawing.Point(34, 58);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(46, 15);
            this.lblAppointments.TabIndex = 7;
            this.lblAppointments.Text = "Termini";
            this.lblAppointments.Click += new System.EventHandler(this.lblAppointments_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblClients);
            this.panel7.Controls.Add(this.pictureBox4);
            this.panel7.Location = new System.Drawing.Point(0, 234);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(118, 80);
            this.panel7.TabIndex = 9;
            this.panel7.Click += new System.EventHandler(this.panel7_Click);
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblClients.Location = new System.Drawing.Point(34, 57);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(43, 15);
            this.lblClients.TabIndex = 7;
            this.lblClients.Text = "Klijenti";
            this.lblClients.Click += new System.EventHandler(this.lblClients_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(33, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(47, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.lblServices);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 76);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(33, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblServices
            // 
            this.lblServices.AutoSize = true;
            this.lblServices.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblServices.Location = new System.Drawing.Point(36, 56);
            this.lblServices.Name = "lblServices";
            this.lblServices.Size = new System.Drawing.Size(43, 15);
            this.lblServices.TabIndex = 5;
            this.lblServices.Text = "Usluge";
            this.lblServices.Click += new System.EventHandler(this.lblServices_Click);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(-1, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(125, 76);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Location = new System.Drawing.Point(-1, 77);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(125, 76);
            this.panel6.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(-1, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(125, 76);
            this.panel4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "eWellness";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(242)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.lblLogout);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblUser);
            this.panel2.Location = new System.Drawing.Point(117, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 35);
            this.panel2.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.Location = new System.Drawing.Point(804, 469);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 42);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(727, 23);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Ime,
            this.Detalji,
            this.Edit,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(126, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(728, 380);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ime.DataPropertyName = "Name";
            this.Ime.HeaderText = "Name";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Detalji
            // 
            this.Detalji.HeaderText = "";
            this.Detalji.Name = "Detalji";
            this.Detalji.ReadOnly = true;
            this.Detalji.Text = "Detalji";
            this.Detalji.ToolTipText = "Detalji";
            this.Detalji.UseColumnTextForButtonValue = true;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Uredi";
            this.Edit.ToolTipText = "Uredi";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Briši";
            this.Delete.ToolTipText = "Briši";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lnkServiceCategories
            // 
            this.lnkServiceCategories.AutoSize = true;
            this.lnkServiceCategories.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lnkServiceCategories.Location = new System.Drawing.Point(133, 486);
            this.lnkServiceCategories.Name = "lnkServiceCategories";
            this.lnkServiceCategories.Size = new System.Drawing.Size(109, 15);
            this.lnkServiceCategories.TabIndex = 7;
            this.lnkServiceCategories.TabStop = true;
            this.lnkServiceCategories.Text = "Kategorije usluga >";
            this.lnkServiceCategories.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lnkServiceCategories.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkServiceCategories_LinkClicked);
            // 
            // lnkPaymentMethods
            // 
            this.lnkPaymentMethods.AutoSize = true;
            this.lnkPaymentMethods.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lnkPaymentMethods.Location = new System.Drawing.Point(133, 486);
            this.lnkPaymentMethods.Name = "lnkPaymentMethods";
            this.lnkPaymentMethods.Size = new System.Drawing.Size(99, 15);
            this.lnkPaymentMethods.TabIndex = 8;
            this.lnkPaymentMethods.TabStop = true;
            this.lnkPaymentMethods.Text = "Načini plaćanja >";
            this.lnkPaymentMethods.Visible = false;
            this.lnkPaymentMethods.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(224)))), ((int)(((byte)(147)))));
            this.lnkPaymentMethods.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPaymentMethods_LinkClicked);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 526);
            this.Controls.Add(this.lnkPaymentMethods);
            this.Controls.Add(this.lnkServiceCategories);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "eWellness :: Admin | Početna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblUser;
        private LinkLabel lblLogout;
        private Panel panel1;
        private Panel panel2;
        private Button btnAdd;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label lblServices;
        private Panel panel5;
        private Panel panel6;
        private Panel panel4;
        private Panel panel10;
        private Label lblPayments;
        private PictureBox pictureBox6;
        private Panel panel9;
        private Label lblDiscount;
        private PictureBox pictureBox5;
        private Panel panel8;
        private Label lblAppointments;
        private PictureBox pictureBox3;
        private Panel panel7;
        private Label lblClients;
        private PictureBox pictureBox4;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private LinkLabel lnkServiceCategories;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Ime;
        private DataGridViewButtonColumn Detalji;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
        private LinkLabel lnkPaymentMethods;
    }
}