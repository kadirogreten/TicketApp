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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblSikayetListele = new System.Windows.Forms.Label();
            this.dtgListele = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSikayetYaz = new System.Windows.Forms.Button();
            this.lblSikayetSahibiSirala = new System.Windows.Forms.Label();
            this.lblFirmaSirala = new System.Windows.Forms.Label();
            this.lblTicketSirala = new System.Windows.Forms.Label();
            this.pnlBig = new System.Windows.Forms.TableLayoutPanel();
            this.pnlLCenter = new System.Windows.Forms.TableLayoutPanel();
            this.lblDetail = new System.Windows.Forms.Label();
            this.pnlDeneme2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGizle = new System.Windows.Forms.Button();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.TableLayoutPanel();
            this.lblFirmName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListele)).BeginInit();
            this.pnlBig.SuspendLayout();
            this.pnlLCenter.SuspendLayout();
            this.pnlDeneme2.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblBaslik.Location = new System.Drawing.Point(508, 3);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(202, 52);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "ŞİKAYETLER";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSikayetListele
            // 
            this.lblSikayetListele.BackColor = System.Drawing.Color.Tan;
            this.lblSikayetListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayetListele.Location = new System.Drawing.Point(273, 6);
            this.lblSikayetListele.Name = "lblSikayetListele";
            this.lblSikayetListele.Size = new System.Drawing.Size(206, 53);
            this.lblSikayetListele.TabIndex = 1;
            this.lblSikayetListele.Text = "Şikayetleri Listele";
            this.lblSikayetListele.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSikayetListele.Click += new System.EventHandler(this.lblSikayetListele_Click);
            // 
            // dtgListele
            // 
            this.dtgListele.AllowUserToAddRows = false;
            this.dtgListele.AllowUserToDeleteRows = false;
            this.dtgListele.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgListele.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgListele.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Description,
            this.Detail,
            this.FirmName,
            this.Address,
            this.UserName,
            this.SurName});
            this.dtgListele.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgListele.Location = new System.Drawing.Point(278, 73);
            this.dtgListele.MultiSelect = false;
            this.dtgListele.Name = "dtgListele";
            this.dtgListele.ReadOnly = true;
            this.dtgListele.Size = new System.Drawing.Size(661, 458);
            this.dtgListele.TabIndex = 2;
            this.dtgListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListele_CellDoubleClick);
            // 
            // Title
            // 
            this.Title.HeaderText = "Şikayet Konusu";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 97;
            // 
            // Description
            // 
            this.Description.HeaderText = "Açıklamalar";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 86;
            // 
            // Detail
            // 
            this.Detail.HeaderText = "Detaylar";
            this.Detail.Name = "Detail";
            this.Detail.ReadOnly = true;
            this.Detail.Width = 71;
            // 
            // FirmName
            // 
            this.FirmName.HeaderText = "Firma Adı";
            this.FirmName.Name = "FirmName";
            this.FirmName.ReadOnly = true;
            this.FirmName.Width = 69;
            // 
            // Address
            // 
            this.Address.HeaderText = "Firma Adresi";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 82;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Şikayetçinin Adı";
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Width = 98;
            // 
            // SurName
            // 
            this.SurName.HeaderText = "Şikayetçinin Soyadı";
            this.SurName.Name = "SurName";
            this.SurName.ReadOnly = true;
            this.SurName.Width = 114;
            // 
            // btnSikayetYaz
            // 
            this.btnSikayetYaz.BackColor = System.Drawing.Color.Tan;
            this.btnSikayetYaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSikayetYaz.Location = new System.Drawing.Point(736, 1);
            this.btnSikayetYaz.Name = "btnSikayetYaz";
            this.btnSikayetYaz.Size = new System.Drawing.Size(203, 58);
            this.btnSikayetYaz.TabIndex = 3;
            this.btnSikayetYaz.Text = "Şikayet yaz";
            this.btnSikayetYaz.UseVisualStyleBackColor = false;
            this.btnSikayetYaz.Click += new System.EventHandler(this.btnSikayetYaz_Click);
            // 
            // lblSikayetSahibiSirala
            // 
            this.lblSikayetSahibiSirala.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSikayetSahibiSirala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSikayetSahibiSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSikayetSahibiSirala.Location = new System.Drawing.Point(14, 88);
            this.lblSikayetSahibiSirala.Name = "lblSikayetSahibiSirala";
            this.lblSikayetSahibiSirala.Size = new System.Drawing.Size(258, 26);
            this.lblSikayetSahibiSirala.TabIndex = 4;
            this.lblSikayetSahibiSirala.Text = "Şikayet Sahibine Göre Sırala";
            // 
            // lblFirmaSirala
            // 
            this.lblFirmaSirala.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblFirmaSirala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirmaSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaSirala.Location = new System.Drawing.Point(14, 145);
            this.lblFirmaSirala.Name = "lblFirmaSirala";
            this.lblFirmaSirala.Size = new System.Drawing.Size(258, 26);
            this.lblFirmaSirala.TabIndex = 5;
            this.lblFirmaSirala.Text = "Firma İsmine Göre Sırala";
            // 
            // lblTicketSirala
            // 
            this.lblTicketSirala.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblTicketSirala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTicketSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketSirala.Location = new System.Drawing.Point(14, 205);
            this.lblTicketSirala.Name = "lblTicketSirala";
            this.lblTicketSirala.Size = new System.Drawing.Size(258, 26);
            this.lblTicketSirala.TabIndex = 6;
            this.lblTicketSirala.Text = "Şikayet Konusuna Göre Sırala";
            // 
            // pnlBig
            // 
            this.pnlBig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlBig.ColumnCount = 1;
            this.pnlBig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBig.Controls.Add(this.pnlLCenter, 0, 1);
            this.pnlBig.Controls.Add(this.pnlDeneme2, 0, 3);
            this.pnlBig.Controls.Add(this.pnlBottom, 0, 2);
            this.pnlBig.Controls.Add(this.pnlTop, 0, 0);
            this.pnlBig.Location = new System.Drawing.Point(502, 202);
            this.pnlBig.Name = "pnlBig";
            this.pnlBig.RowCount = 4;
            this.pnlBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.85572F));
            this.pnlBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.14428F));
            this.pnlBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.pnlBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.pnlBig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlBig.Size = new System.Drawing.Size(260, 320);
            this.pnlBig.TabIndex = 7;
            this.pnlBig.Visible = false;
            // 
            // pnlLCenter
            // 
            this.pnlLCenter.BackColor = System.Drawing.Color.White;
            this.pnlLCenter.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlLCenter.ColumnCount = 1;
            this.pnlLCenter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.pnlLCenter.Controls.Add(this.lblDetail, 0, 0);
            this.pnlLCenter.Location = new System.Drawing.Point(3, 61);
            this.pnlLCenter.Name = "pnlLCenter";
            this.pnlLCenter.RowCount = 1;
            this.pnlLCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.29412F));
            this.pnlLCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.pnlLCenter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.pnlLCenter.Size = new System.Drawing.Size(251, 139);
            this.pnlLCenter.TabIndex = 31;
            // 
            // lblDetail
            // 
            this.lblDetail.AutoSize = true;
            this.lblDetail.BackColor = System.Drawing.Color.MintCream;
            this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDetail.ForeColor = System.Drawing.Color.Sienna;
            this.lblDetail.Location = new System.Drawing.Point(5, 2);
            this.lblDetail.Name = "lblDetail";
            this.lblDetail.Size = new System.Drawing.Size(240, 80);
            this.lblDetail.TabIndex = 28;
            this.lblDetail.Text = "DetailsDetailsDetailsDetailsDetailsDetailsDetailsDetailsDetailsDetailsDetailsDeta" +
    "ilsDetailsDetailsDetailsDetailsDetailsDetails";
            // 
            // pnlDeneme2
            // 
            this.pnlDeneme2.BackColor = System.Drawing.Color.Transparent;
            this.pnlDeneme2.ColumnCount = 2;
            this.pnlDeneme2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDeneme2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.pnlDeneme2.Controls.Add(this.btnGizle, 0, 0);
            this.pnlDeneme2.Controls.Add(this.btnCevapla, 1, 0);
            this.pnlDeneme2.Location = new System.Drawing.Point(3, 277);
            this.pnlDeneme2.Name = "pnlDeneme2";
            this.pnlDeneme2.RowCount = 1;
            this.pnlDeneme2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlDeneme2.Size = new System.Drawing.Size(251, 40);
            this.pnlDeneme2.TabIndex = 3;
            // 
            // btnGizle
            // 
            this.btnGizle.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGizle.Location = new System.Drawing.Point(3, 3);
            this.btnGizle.Name = "btnGizle";
            this.btnGizle.Size = new System.Drawing.Size(57, 34);
            this.btnGizle.TabIndex = 8;
            this.btnGizle.Text = "gizle";
            this.btnGizle.UseVisualStyleBackColor = false;
            this.btnGizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCevapla
            // 
            this.btnCevapla.BackColor = System.Drawing.Color.Tan;
            this.btnCevapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCevapla.Location = new System.Drawing.Point(66, 3);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(179, 34);
            this.btnCevapla.TabIndex = 4;
            this.btnCevapla.Text = "Şikayeti Cevapla";
            this.btnCevapla.UseVisualStyleBackColor = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlBottom.ColumnCount = 2;
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.pnlBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.pnlBottom.Controls.Add(this.lblFirmName, 0, 0);
            this.pnlBottom.Controls.Add(this.lblUser, 0, 0);
            this.pnlBottom.Location = new System.Drawing.Point(3, 206);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.RowCount = 1;
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.29412F));
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.pnlBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.pnlBottom.Size = new System.Drawing.Size(254, 65);
            this.pnlBottom.TabIndex = 29;
            // 
            // lblFirmName
            // 
            this.lblFirmName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblFirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmName.ForeColor = System.Drawing.Color.Sienna;
            this.lblFirmName.Location = new System.Drawing.Point(102, 2);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(143, 61);
            this.lblFirmName.TabIndex = 3;
            this.lblFirmName.Text = "Firma Adı ve Şehir";
            this.lblFirmName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUser.ForeColor = System.Drawing.Color.DarkGray;
            this.lblUser.Location = new System.Drawing.Point(5, 2);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(89, 61);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "KullanıcıAdSoyad";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTop
            // 
            this.pnlTop.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.pnlTop.ColumnCount = 1;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39759F));
            this.pnlTop.Controls.Add(this.lblTitle, 0, 0);
            this.pnlTop.Controls.Add(this.lblDescription, 0, 1);
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 2;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.29412F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlTop.Size = new System.Drawing.Size(254, 52);
            this.pnlTop.TabIndex = 28;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Sienna;
            this.lblTitle.Location = new System.Drawing.Point(5, 2);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(244, 22);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDescription.Location = new System.Drawing.Point(5, 27);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(244, 23);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 538);
            this.Controls.Add(this.pnlBig);
            this.Controls.Add(this.lblTicketSirala);
            this.Controls.Add(this.lblFirmaSirala);
            this.Controls.Add(this.lblSikayetSahibiSirala);
            this.Controls.Add(this.btnSikayetYaz);
            this.Controls.Add(this.dtgListele);
            this.Controls.Add(this.lblSikayetListele);
            this.Controls.Add(this.lblBaslik);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListele)).EndInit();
            this.pnlBig.ResumeLayout(false);
            this.pnlLCenter.ResumeLayout(false);
            this.pnlLCenter.PerformLayout();
            this.pnlDeneme2.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
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
        private System.Windows.Forms.TableLayoutPanel pnlBig;
        private System.Windows.Forms.TableLayoutPanel pnlLCenter;
        private System.Windows.Forms.Label lblDetail;
        private System.Windows.Forms.TableLayoutPanel pnlDeneme2;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.TableLayoutPanel pnlBottom;
        private System.Windows.Forms.Label lblFirmName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnGizle;
    }
}

