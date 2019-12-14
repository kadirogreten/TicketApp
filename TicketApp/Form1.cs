using Models;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List < string > firm_names = FirmRepository.GetFirmNames();
            for (int i = 0; i < firm_names.Count; i++)
            {
                cmbFirma.Items.Add(firm_names[i]);
            }
            
            
                                                  
        }

        private void lblSikayetListele_Click(object sender, EventArgs e)
        {
            List<Complaint> complaints = new List<Complaint>();
            
            dtgListele.Rows.Clear();
            complaints = ComplaintRepository.GetComplaints();

            foreach (var item in complaints)
            {
                dtgListele.Rows.Add($"{item.Title}", $"{item.Description}", $"{item.Detail}", $"{item.FirmName}", $"{item.Address}", $"{item.UserName}", $"{item.UserSurName}", $"{item.UserPhone}");
               
            }

                                             
        }

        private void dtgListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*Datagriddeki şikayet listesinde şikayet hücresine çift tıklanınca şikayetin ayrıntılarını büyük panelde 
              görmek için buradakileri yaptık       */       
             
            
            //form açılırken panelin Visible'ı false olduğu için panel görünmeyecek. Hücreye tıklanınca true olup görünecek.
            pnlBig.Visible = true;

            // Ve hücrelerdeki değerler paneldeki labellara aktarılacak
            int selected = dtgListele.SelectedCells[0].RowIndex;
            string title = dtgListele.Rows[selected].Cells[0].Value.ToString();
            string description = dtgListele.Rows[selected].Cells[1].Value.ToString();
            string detail = dtgListele.Rows[selected].Cells[2].Value.ToString();
            string firm_name = dtgListele.Rows[selected].Cells[3].Value.ToString();
            string adress = dtgListele.Rows[selected].Cells[4].Value.ToString();
            string user_name = dtgListele.Rows[selected].Cells[5].Value.ToString();
            string user_surname = dtgListele.Rows[selected].Cells[6].Value.ToString();
            lblTitle.Text = title;
            lblDescription.Text = description;
            lblDetail.Text = detail;
            lblUser.Text = user_name + " " + user_surname;
            lblFirmName.Text = firm_name + " " + adress;                      

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Açılan paneli gizlemek için
            pnlBig.Visible = false;
        }

        private void btnSikayetYaz_Click(object sender, EventArgs e)
        {
            //şikayetin girileceği 2.formu oluştuduk.
            frmSikayet yeniForm = new frmSikayet();
            this.Hide();
            yeniForm.Show();
        }

        private void lblSikayetSahibiSirala_Click(object sender, EventArgs e)
        {
            //labele a tıklanınca username e göre sıralama yapılmasını sağladık.
            dtgListele.Rows.Clear();
            List<Complaint> complaints = ComplaintRepository.OrderComplaintsByUserName();

            foreach (var item in complaints)
            {
                dtgListele.Rows.Add($"{item.Title}", $"{item.Description}", $"{item.Detail}", $"{item.FirmName}", $"{item.Address}", $"{item.UserName}", $"{item.UserSurName}",  $"{item.UserPhone}");

            }
        }

        private void lblFirmaSirala_Click(object sender, EventArgs e)
        {
            dtgListele.Rows.Clear();
            //labele a tıklanınca firmname e göre sıralama yapılmasını sağladık.
            List<Complaint> complaints = ComplaintRepository.OrderComplaintsByFirmName();

            foreach (var item in complaints)
            {
                dtgListele.Rows.Add($"{item.Title}", $"{item.Description}", $"{item.Detail}", $"{item.FirmName}", $"{item.UserName}", $"{item.UserSurName}", $"{item.Address}", $"{item.UserPhone}");

            }

        }

        private void lblTicketSirala_Click(object sender, EventArgs e)
        {
            dtgListele.Rows.Clear();
            //labele a tıklanınca tittle başlığına göre sıralama yapılmasını sağladık.
            List<Complaint> complaints = ComplaintRepository.OrderComplaintsByTitle();

            foreach (var item in complaints)
            {
                dtgListele.Rows.Add($"{item.Title}", $"{item.Description}", $"{item.Detail}", $"{item.FirmName}", $"{item.UserName}", $"{item.UserSurName}", $"{item.Address}", $"{item.UserPhone}");

            }

        }

        
        private void dtgListele_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void cmbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgListele.Rows.Clear();
            string firm_name = cmbFirma.SelectedItem.ToString();
            List<Complaint> complaints = ComplaintRepository.GetComplaintsByFirmName(firm_name);

            foreach (var item in complaints)
            {
                dtgListele.Rows.Add($"{item.Title}", $"{item.Description}", $"{item.Detail}", $"{item.FirmName}", $"{item.UserName}", $"{item.UserSurName}", $"{item.Address}", $"{item.UserPhone}");

            }
            ;

        }
    }
}
