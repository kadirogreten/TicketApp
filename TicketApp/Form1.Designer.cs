namespace TicketApp
{
    partial class Form1
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
            this.lblSikayet = new System.Windows.Forms.Label();
            this.lblSikayetListele = new System.Windows.Forms.Label();
            this.dtgListele = new System.Windows.Forms.DataGridView();
            this.btnSikayetYaz = new System.Windows.Forms.Button();
            this.lblSikayetSahibiSirala = new System.Windows.Forms.Label();
            this.lblFirmaSirala = new System.Windows.Forms.Label();
            this.lblTicketSirala = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListele)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSikayet
            // 
            this.lblSikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayet.Location = new System.Drawing.Point(512, 18);
            this.lblSikayet.Name = "lblSikayet";
            this.lblSikayet.Size = new System.Drawing.Size(202, 52);
            this.lblSikayet.TabIndex = 0;
            this.lblSikayet.Text = "ŞİKAYETLER";
            // 
            // lblSikayetListele
            // 
            this.lblSikayetListele.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSikayetListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayetListele.Location = new System.Drawing.Point(37, 106);
            this.lblSikayetListele.Name = "lblSikayetListele";
            this.lblSikayetListele.Size = new System.Drawing.Size(204, 39);
            this.lblSikayetListele.TabIndex = 1;
            this.lblSikayetListele.Text = "Şikayetleri Listele";
            this.lblSikayetListele.Click += new System.EventHandler(this.lblSikayetListele_Click);
            // 
            // dtgListele
            // 
            this.dtgListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.Detail,
            this.FirmName,
            this.Address,
            this.UserName,
            this.SurName});
            this.dtgListele.Location = new System.Drawing.Point(283, 106);
            this.dtgListele.Name = "dtgListele";
            this.dtgListele.Size = new System.Drawing.Size(744, 356);
            this.dtgListele.TabIndex = 2;
            // 
            // btnSikayetYaz
            // 
            this.btnSikayetYaz.Location = new System.Drawing.Point(1051, 187);
            this.btnSikayetYaz.Name = "btnSikayetYaz";
            this.btnSikayetYaz.Size = new System.Drawing.Size(113, 90);
            this.btnSikayetYaz.TabIndex = 3;
            this.btnSikayetYaz.Text = "Şikayet Yazmak İçin Tıklayınız";
            this.btnSikayetYaz.UseVisualStyleBackColor = true;
            // 
            // lblSikayetSahibiSirala
            // 
            this.lblSikayetSahibiSirala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblSikayetSahibiSirala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSikayetSahibiSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayetSahibiSirala.Location = new System.Drawing.Point(12, 176);
            this.lblSikayetSahibiSirala.Name = "lblSikayetSahibiSirala";
            this.lblSikayetSahibiSirala.Size = new System.Drawing.Size(265, 26);
            this.lblSikayetSahibiSirala.TabIndex = 4;
            this.lblSikayetSahibiSirala.Text = "Şikayet Sahibine Göre Sırala";
            // 
            // lblFirmaSirala
            // 
            this.lblFirmaSirala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblFirmaSirala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirmaSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaSirala.Location = new System.Drawing.Point(12, 251);
            this.lblFirmaSirala.Name = "lblFirmaSirala";
            this.lblFirmaSirala.Size = new System.Drawing.Size(265, 26);
            this.lblFirmaSirala.TabIndex = 5;
            this.lblFirmaSirala.Text = "Firma İsmine Göre Sırala";
            // 
            // lblTicketSirala
            // 
            this.lblTicketSirala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTicketSirala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketSirala.Location = new System.Drawing.Point(12, 323);
            this.lblTicketSirala.Name = "lblTicketSirala";
            this.lblTicketSirala.Size = new System.Drawing.Size(265, 26);
            this.lblTicketSirala.TabIndex = 6;
            this.lblTicketSirala.Text = "Şikayet Konusuna Göre Sırala";
            // 
            // Title
            // 
            this.Title.HeaderText = "Şikayet Konusu";
            this.Title.Name = "Title";
            // 
            // Description
            // 
            this.Description.HeaderText = "Açıklamalar";
            this.Description.Name = "Description";
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detaylar";
            this.Detail.Name = "Detail";
            // 
            // FirmName
            // 
            this.FirmName.HeaderText = "Firma Adı";
            this.FirmName.Name = "FirmName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Firma Adresi";
            this.Address.Name = "Address";
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Şikayetçinin Adı";
            this.UserName.Name = "UserName";
            // 
            // SurName
            // 
            this.SurName.HeaderText = "Şikayetçinin Soyadı";
            this.SurName.Name = "SurName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 505);
            this.Controls.Add(this.lblTicketSirala);
            this.Controls.Add(this.lblFirmaSirala);
            this.Controls.Add(this.lblSikayetSahibiSirala);
            this.Controls.Add(this.btnSikayetYaz);
            this.Controls.Add(this.dtgListele);
            this.Controls.Add(this.lblSikayetListele);
            this.Controls.Add(this.lblSikayet);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSikayet;
        private System.Windows.Forms.Label lblSikayetListele;
        private System.Windows.Forms.DataGridView dtgListele;
        private System.Windows.Forms.Button btnSikayetYaz;
        private System.Windows.Forms.Label lblSikayetSahibiSirala;
        private System.Windows.Forms.Label lblFirmaSirala;
        private System.Windows.Forms.Label lblTicketSirala;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurName;
    }
}

