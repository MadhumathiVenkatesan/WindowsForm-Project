using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessEntity;
using BussinessLogic;
using System.Data.SqlClient;

namespace Ems
{
    public partial class Employeeview : Form
    {
        Employee employee;
        SqlConnection con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
        public Employeeview()
        {
            InitializeComponent();
            employee = new Employee();
        }

        private void Employeeview_Load(object sender, EventArgs e)
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from tblEmployee",con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dgEmployeeinfo.DataSource = dt;
             int total=Convert.ToInt32(dgEmployeeinfo.RowCount-1);
            txt_totalemployee.Text = total.ToString();


        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            Employee_details ed = new Employee_details();
            ed.Show();
            this.Hide();

        }
    }
}
