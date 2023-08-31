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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }
        hotel_ManagementSystemEntities db = new hotel_ManagementSystemEntities();

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotel_ManagementSystemDataSet1.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.hotel_ManagementSystemDataSet1.payment);

            RefreshList();
        }
        private void RefreshList()
        {
            var sqlQuery = "select * from payment";
            var listempData = db.Database.SqlQuery<payment>(sqlQuery).ToList();
            dataGridView1.DataSource = listempData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sqlQuery = "select * from payment";
            var listempData = db.Database.SqlQuery<payment>(sqlQuery).ToList();
            dataGridView1.DataSource = listempData;

            RefreshList();
        }
    }
}
