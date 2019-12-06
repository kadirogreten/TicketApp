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
    }
}
