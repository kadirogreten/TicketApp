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
            int k = 0;

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {

                    control.TabIndex = k;
                    k++;
                }
            }

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

            List<string> txt_alan_adlari = new List<string>();
            foreach (Control ctl in this.Controls)
            {
                if (ctl is TextBox)
                {
                    txt_alan_adlari.Add(ctl.Name.Substring(3, ctl.Name.Length - 3));

                    foreach (var item in txt_alan_adlari)
                    {
                        if (ctl.Text == String.Empty)
                        {


                            MessageBox.Show(item + " alanı boş bırakılamaz");
                            return;
                        }
                    }


                }
            }

            UserRepository.InsertUser(user);
            ticket.UserId = UserRepository.GetUserCurrentId();
            FirmRepository.InsertFirm(firm);
            ticket.FirmId = FirmRepository.GetFirmCurrentId();

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
