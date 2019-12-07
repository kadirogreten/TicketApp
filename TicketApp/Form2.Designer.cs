namespace TicketApp
{
    partial class frmSikayet
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirm = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirm = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lvlTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDetail = new System.Windows.Forms.TextBox();
            this.lblDetail = new System.Windows.Forms.Label();
            this.btnSikayetGönder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(183, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 0;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(183, 38);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(183, 64);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 2;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(45, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(71, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Adınızı Giriniz:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(45, 45);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(88, 13);
            this.lblSurname.TabIndex = 4;
            this.lblSurname.Text = "Soyadınızı Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Telefon Numaranızı Giriniz:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(471, 45);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(106, 13);
            this.lblAddress.TabIndex = 9;
            this.lblAddress.Text = "Firma Adresini Giriniz:";
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.Location = new System.Drawing.Point(471, 19);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(95, 13);
            this.lblFirm.TabIndex = 8;
            this.lblFirm.Text = "Firma Adını Giriniz: ";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(609, 38);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // txtFirm
            // 
            this.txtFirm.Location = new System.Drawing.Point(609, 12);
            this.txtFirm.Name = "txtFirm";
            this.txtFirm.Size = new System.Drawing.Size(100, 20);
            this.txtFirm.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(48, 132);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(661, 20);
            this.txtTitle.TabIndex = 10;
            // 
            // lvlTitle
            // 
            this.lvlTitle.AutoSize = true;
            this.lvlTitle.Location = new System.Drawing.Point(48, 116);
            this.lvlTitle.Name = "lvlTitle";
            this.lvlTitle.Size = new System.Drawing.Size(121, 13);
            this.lvlTitle.TabIndex = 11;
            this.lvlTitle.Text = "Şikayet Başlığınu Giriniz:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(45, 155);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 13);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Açıklama Giriniz:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(48, 171);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(661, 20);
            this.txtDescription.TabIndex = 12;
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(48, 224);
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(661, 129);
            this.txtDetail.TabIndex = 14;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.Location = new System.Drawing.Point(48, 208);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(82, 13);
            this.lblDetail.TabIndex = 15;
            this.lblDetail.Text = "Detayları Giriniz:";
            // 
            // btnSikayetGönder
            // 
            this.btnSikayetGönder.Location = new System.Drawing.Point(208, 376);
            this.btnSikayetGönder.Name = "btnSikayetGönder";
            this.btnSikayetGönder.Size = new System.Drawing.Size(345, 23);
            this.btnSikayetGönder.TabIndex = 16;
            this.btnSikayetGönder.Text = "Şikayeti Gönder";
            this.btnSikayetGönder.UseVisualStyleBackColor = true;
            this.btnSikayetGönder.Click += new System.EventHandler(this.btnSikayetGönder_Click);
            // 
            // frmSikayet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSikayetGönder);
            this.Controls.Add(this.lblDetail);
            this.Controls.Add(this.txtDetail);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lvlTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFirm);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFirm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtUser);
            this.Name = "frmSikayet";
            this.Text = "Şikayet";
            this.Load += new System.EventHandler(this.frmSikayet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirm;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lvlTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDetail;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.Button btnSikayetGönder;
    }
}