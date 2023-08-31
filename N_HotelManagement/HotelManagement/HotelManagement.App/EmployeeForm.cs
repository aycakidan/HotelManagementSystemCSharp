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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        hotel_ManagementSystemEntities db = new hotel_ManagementSystemEntities();

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            RefreshList();

        }
        private void RefreshList()
        {
            var sqlQuery = "select * from employee";
            var listempData = db.Database.SqlQuery<employee>(sqlQuery).ToList();
            dataGridView1.DataSource = listempData;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var sqlQuery = "select * from employee";
            var listempData = db.Database.SqlQuery<employee>(sqlQuery).ToList();
            dataGridView1.DataSource = listempData;

            RefreshList();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    var empID = id_tb.Text;
        //    employee empModel = new employee
        //    {
        //        emp_id = Convert.ToInt32(id_tb.Text),

        //    };

        //    db.employee.Add(empModel);
        //    db.SaveChanges();


        //    Helper.Helpers.ShowMessage($" Name with {id_tb.Text}  employee is saved!");
        //    id_tb.Text = "";
        //}

       
    }
}





