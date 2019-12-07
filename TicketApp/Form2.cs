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
            UserRepository.InsertUser(user);

            Firm firm = new Firm();
            {
                firm.FirmName = txtFirm.Text;
                firm.Address = txtAddress.Text;
            }
            FirmRepository.InsertFirm(firm);

            Ticket ticket = new Ticket();
            {
                ticket.Title = txtTitle.Text;
                ticket.Description = txtAddress.Text;
                ticket.Detail = txtDetail.Text;
            }
            TicketRepository.InsertTicket(ticket);

        }

        private void frmSikayet_Load(object sender, EventArgs e)
        {

           
        }
    }
}
