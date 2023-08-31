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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }
        hotel_ManagementSystemEntities db = new hotel_ManagementSystemEntities();

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementSystemDataSet1.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotel_ManagementSystemDataSet1.room);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            room roomType = new room
            {
               room_Type=comboBox1.Text,


            };

            db.room.Add(roomType);
            db.SaveChanges();


            Helper.Helpers.ShowMessage($" Name with {comboBox1.Text}room is saved!");
            comboBox1.Text = "";
           

            RefreshList();
        }

        private void RefreshList()
        {
            var sqlQuery = "select * from room"; 
            var listGuestData = db.Database.SqlQuery<room>(sqlQuery).ToList();
            dataGridView1.DataSource = listGuestData;

        }
    }
    }
}
