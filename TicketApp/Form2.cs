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
    public partial class frmSikayet : Form
    {
        public frmSikayet()
        {
            InitializeComponent();
        }
      
        private void btnSikayetGönder_Click(object sender, EventArgs e)
        {
            //texboxlardan gelen değerler user, firm ve ticket için eşleştirildi.
            User user = new User();
            {
                user.Name = txtUser.Text;
                user.Surname = txtSurname.Text;
                user.Phone = txtPhone.Text;
            }
            
            Firm firm = new Firm();
            {
                firm.FirmName = txtFirm.Text;
                firm.Address = txtAddress.Text;
            }

            Ticket ticket = new Ticket();
            {
                ticket.Title = txtTitle.Text;
                ticket.Description = txtAddress.Text;
                ticket.Detail = txtDetail.Text;
            }

             //texboxların boş geçilmemesi için yazdık.
            //messageboxta boş bırakılan alanın adı yer alsın diye yapılan array
            string[] txt_alan_adlari = {"İsim","Soyisim","Telefon","Firma adı","Firma adresi","Şikayet konusu","açıklama","Detaylar"};

            foreach (Control ctl in this.Controls)
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {                      
                       MessageBox.Show(txt_alan_adlari[ctl.TabIndex] + " alanı boş bırakılamaz");                     
                       
                    }
                }


            UserRepository.InsertUser(user);
            FirmRepository.InsertFirm(firm);
            TicketRepository.InsertTicket(ticket);
            MessageBox.Show("Şikayetiniz başarıyla gönderilmiştir.");
            MessageBox.Show("Anasayfaya yönlendirileceksiniz");
            Form1 anasayfa = new Form1();
            this.Hide();
            anasayfa.Show();
        }

        private void frmSikayet_Load(object sender, EventArgs e)
        {

           
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //phone texbox ına sadece rakam girilmesi için yaptık.
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }
}
}
