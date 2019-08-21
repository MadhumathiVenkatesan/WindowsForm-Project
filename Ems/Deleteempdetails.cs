using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DatabaseLayer;
using BussinessEntity;
using BussinessLogic;

namespace Ems
{
    public partial class Deleteempdetails : Form
    {
        SqlConnection con;
        SqlDataAdapter ad;
        DataTable dt;
        DbConnection dbConnection;
        EmployeeEntity empentity;
        Employee employee;
        public Deleteempdetails()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
            dbConnection = new DbConnection();
            empentity = new EmployeeEntity();
            employee = new Employee();
        }

        private void Deleteempdetails_Load(object sender, EventArgs e)
        {
            var dt1 = dbConnection.CommonMethodSelection("select * from tblEmployee");
            dgdelete.DataSource = dt1;

        }

       

        private void Dgdelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = 0;
            rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgdelete.Rows[rowIndex];
                txtEmployeeId.Text = row.Cells[0].Value.ToString();
                txtEmployeename.Text = row.Cells[1].Value.ToString();
                txtDepartment.Text = row.Cells[14].Value.ToString();
                txtDesignation.Text = row.Cells[15].Value.ToString();
          
                
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = txtEmployeeId.Text;
            empentity.ID = id;
            employee.DeleteEmpRecord(empentity);
            MessageBox.Show("Record deleted");
            var dt1 = dbConnection.CommonMethodSelection("select * from tblEmployeeleave");
            dgdelete.DataSource = dt1;



        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            Employee_details ed = new Employee_details();
            ed.Show();
            this.Hide();
        }
    }
}
