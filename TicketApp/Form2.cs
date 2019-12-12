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
            {
                if (ctl is TextBox)
                {
                    if (ctl.Text == String.Empty)
                    {
                        MessageBox.Show(txt_alan_adlari[ctl.TabIndex] + " alanı boş bırakılamaz");
                        return;
                    }
                }
            }
               

            
            var result = UserRepository.InsertUser(user);
            var result_Firm = FirmRepository.InsertFirm(firm);
            var userId = 0;
            var firmId = 0;
            if (result > 0 && result_Firm > 0)
            {
                
                var users = UserRepository.GetUsers()
                .Where(a => (a.Name == user.Name) && (a.Surname == user.Surname) && (a.Phone == user.Phone)).Take(1);

                var firms = FirmRepository.GetFirms()
               .Where(a => (a.FirmName == firm.FirmName) && (a.Address == firm.Address)).Take(1);


                foreach (var item in users)
                {
                    userId = item.Id;
                }

                foreach (var item in firms)
                {
                    firmId = item.Id;
                }

                ticket.UserId = userId;
                ticket.FirmId = firmId;

                

                TicketRepository.InsertTicket(ticket);
                MessageBox.Show("Şikayetiniz başarıyla gönderilmiştir.");
                MessageBox.Show("Anasayfaya yönlendirileceksiniz");
                Form1 anasayfa = new Form1();
                this.Hide();
                anasayfa.Show();
            }
            else
            {

            }


           
        }

        private void frmSikayet_Load(object sender, EventArgs e)
        {

           
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //phone texbox ına sadece rakam girilmesi için yaptık.
            if (Char.IsNumber((char)e.KeyChar) || e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            var chars = txtPhone.Text.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]) || !Char.IsDigit(chars[i]) || Char.IsWhiteSpace(chars[i]))
                {
                    MessageBox.Show("Harf Giremezsiniz!");
                    txtPhone.Text = string.Empty;
                }
            }

        }
    }
}
