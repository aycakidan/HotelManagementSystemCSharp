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
    public partial class ReservationForm : Form
    {
        public ReservationForm()
        {
            InitializeComponent();
        }
        hotel_ManagementSystemEntities db = new hotel_ManagementSystemEntities();

        private void ReservationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementSystemDataSet1.guestReservation' table. You can move, or remove it, as needed.
            this.guestReservationTableAdapter.Fill(this.hotel_ManagementSystemDataSet1.guestReservation);
            RefreshList();

        }
        private void RefreshList()
        {
            var sqlQuery = "select res_id, guest_id, room_no, checkIN, checkOUT from guestReservation";
            var listRestData = db.Database.SqlQuery<guestReservation>(sqlQuery).ToList();
            dataGridView1.DataSource = listRestData;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime( in_tb.Text);
            guestReservation resModel = new guestReservation
            {
                checkIN = Convert.ToDateTime(in_tb.Text),
                checkOUT = Convert.ToDateTime( out_tb.Text),
            };

            db.guestReservation.Add(resModel);
            db.SaveChanges();


            Helper.Helpers.ShowMessage($" Date with  {in_tb.Text} {out_tb.Text} is added");
            in_tb.Text = "";
            out_tb.Text = "";
            
            RefreshList();
        }
    }
}
