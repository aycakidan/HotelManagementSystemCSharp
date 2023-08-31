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
    public partial class GuestForm : Form
    {
        public GuestForm()
        {
            InitializeComponent();
        }

        hotel_ManagementSystemEntities db = new hotel_ManagementSystemEntities();
        private void GuestForm_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emptyRoom = db.Database.SqlQuery<int>(@"
select room_id from room r
where r.room_id NOT IN(select distinct room_id from guest)
").ToList();

            if (emptyRoom.Count == 0)
            {
                Helper.Helpers.ShowMessage("There is no empty room! You cannot save any guest!");
                return;
            }
            

            guest guestModel = new guest
            {
                guest_name = txtName.Text,
                guest_surname = txtSurname.Text,
                phone = txtPhone.Text,
                gender = txtGender.Text,              
                room_id = emptyRoom.FirstOrDefault(),
               

            };

            db.guest.Add(guestModel);
            db.SaveChanges();

          
            Helper.Helpers.ShowMessage($" Name with {txtName.Text} {txtSurname.Text}guest is saved!");
            txtName.Text = "";
            txtSurname.Text = "";
            txtPhone.Text = "";
            txtGender.Text = "";
            
            
            RefreshList();
        }

        private void RefreshList()
        {
            var sqlQuery = " EXEC guest_procedure;";  // STORAGE PROCEDURE IS APPLIED (join tables)
            var listGuestData = db.Database.SqlQuery<guest>(sqlQuery).ToList();
            dgGuest.DataSource = listGuestData;
           
        }

        
    }
}
