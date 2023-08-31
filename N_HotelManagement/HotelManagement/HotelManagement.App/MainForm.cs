using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.App
{
    public partial class MainForm : Form
    {
        private string loginUserName = "";
        public MainForm(string loginUser)
        {
            InitializeComponent();
            loginUserName = loginUser;
            this.Text = $"Hotel Management - Welcome {loginUserName}";
        }

        private void guestProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuestForm frm = new GuestForm();
            frm.Show();
        }

        private void employeeProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.Show();
        }

        private void roomProessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomForm room = new RoomForm();
            room.Show();
        }

        private void reservationProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationForm res = new ReservationForm();
            res.Show();
        }

        private void paymentProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentForm pay = new PaymentForm();
            pay.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Room kayıtları atmak için insert yapıldı sonra kapatıldı..

//            hotel_ManagementSystemEntities db = new hotel_ManagementSystemEntities();

//            for (int i = 1040; i < 2080; i++)
//            {
//                string query = @"
//INSERT INTO [dbo].[room]
//           ([room_No]
//           ,[room_Type])
//     VALUES
//           (" + i + "," +
//           "'Suit')";
//                db.Database.ExecuteSqlCommand(query);
                
//                try
//                {
//                    db.SaveChanges();
//                }
//                catch (Exception)
//                {
//                }
//            }
        }
    }
}
