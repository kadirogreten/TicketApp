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
            //User user = UserRepository.GetUserById(1);

            //MessageBox.Show($"{user.Name}");

            //List<User> users = UserRepository.GetUsers();

            //foreach (var item in users)
            //{
            //    MessageBox.Show($"{item.Name}");
            //}


            //User user = new User
            //{
            //    Name = "Doğan",
            //    Surname = "Öztürk",
            //    Phone = "00000000",
            //    IsActive = true
            //};

            //var data = UserRepository.InsertUser(user);

            //MessageBox.Show(data.ToString());
                                                  
        }

        private void lblSikayetListele_Click(object sender, EventArgs e)
        {

            List<Complaint> complaints = TicketRepository.GetComplaints();
            
            foreach (var item in complaints)
            {
                dtgListele.Rows.Add($"{item.Title}", $"{item.Description}", $"{item.Detail}", $"{item.FirmName}", $"{item.UserName}", $"{item.UserSurName}", $"{item.Address}");
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
            string description = dtgListele.Rows[selected].Cells[0].Value.ToString();
            string detail = dtgListele.Rows[selected].Cells[0].Value.ToString();
            string firm_name = dtgListele.Rows[selected].Cells[0].Value.ToString();
            string adress = dtgListele.Rows[selected].Cells[0].Value.ToString();
            string user_name = dtgListele.Rows[selected].Cells[0].Value.ToString();
            string user_surname = dtgListele.Rows[selected].Cells[0].Value.ToString();
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
            Form frmSikayet = new Form();
            frmSikayet.MdiParent = this;
            frmSikayet.Show();


        }
    }
}
