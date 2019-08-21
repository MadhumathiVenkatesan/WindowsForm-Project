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
using DatabaseLayer;
using BussinessEntity;
using BussinessLogic;
namespace Ems
{
    public partial class Department : Form
    {
        SqlConnection con;
        SqlCommand cmd=new SqlCommand();
        DbConnection dbConnection;

        DeparmentEntity deparmentEntity;
        Employee employee;

        public Department()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
            dbConnection = new DbConnection();
            deparmentEntity = new DeparmentEntity();
            employee = new Employee();
        }

        
        
        
        private void Department_Load(object sender, EventArgs e)
        {
            var dt = dbConnection.CommonMethodSelection("select Deptid from tblDepartments");
         
            cmb_deptid.ValueMember = "tblDepartments";
            foreach(DataRow dr in dt.Rows)
            {
                cmb_deptid.Items.Add(dr["deptid"].ToString());
            }
        


           
        }
        private void Btn_Search_Click(object sender, EventArgs e)
        {
            var dt = dbConnection.CommonMethodSelection("select * from tblDepartments where Deptid = '" + cmb_deptid.SelectedItem + "' ");

          
            dgrid_Deptinfo.DataSource = dt;
        }

        private void Btn_Listdept_Click(object sender, EventArgs e)
        {
            var dt = dbConnection.CommonMethodSelection("select * from tblDepartments");
            dgrid_Deptinfo.DataSource = dt;
        }

        


        private void Cmb_deptid_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var dt = dbConnection.CommonMethodSelection("select * from tblDepartments where Deptid = '" + cmb_deptid.SelectedItem + "' ");

            //var dt = dbConnection.GetDepartmentName(Convert.ToString(cmb_deptid.SelectedItem));
            foreach (DataRow item in dt.Rows)
            {
                string deptname = (string)item["Deptname"].ToString();
                txt_deptname.Text = deptname;
                string deptdescription = (string)item["Deptdesc"].ToString();
                txt_deptdescription.Text = deptdescription;
            }
        }

        

        private void Cmb_deptid_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            var dt = dbConnection.CommonMethodSelection("select * from tblDepartments where Deptid = '" + cmb_deptid.SelectedItem + "' ");

            // var dt = dbConnection.Cmb_deptid_SelectionChangeCommitted_1(Convert.ToString(cmb_deptid.SelectedItem));
            SqlDataAdapter ad1 = new SqlDataAdapter("select Deptname from tblDepartments where Deptid='" + cmb_deptid + "'", con);
            DataTable dt2 = new DataTable();
            ad1.Fill(dt2);
            
        }

        private void Btn_Adddepartments_Click(object sender, EventArgs e)
        {
            //int dt = dbConnection.Btn_Adddepartments_Click(Convert.ToString(cmb_deptid.Text), txt_deptname.Text, txt_deptdescription.Text);
            deparmentEntity.DeptId = Convert.ToString(cmb_deptid.Text);
            deparmentEntity.DeptName = txt_deptname.Text;
            deparmentEntity.DeptDescription = txt_deptdescription.Text;
           int i=employee.InsertDepartmentRecord(deparmentEntity);
            if (i > 0)
            {
                MessageBox.Show(" Row(s) Inserted ");
                cmb_deptid.Text = " ";
                txt_deptname.Clear();
                txt_deptdescription.Clear();
            }            
        }

        private void Btn_Updatedepartments_Click(object sender, EventArgs e)
        {
            //int dt = dbConnection.Btn_Updatedepartments_Click(Convert.ToString(cmb_deptid.Text), txt_deptname.Text, txt_deptdescription.Text);
            deparmentEntity.DeptId = Convert.ToString(cmb_deptid.Text);
            deparmentEntity.DeptName = txt_deptname.Text;
            deparmentEntity.DeptDescription = txt_deptdescription.Text;
            int i = employee.UpdateDepartmentRecord(deparmentEntity);

            cmb_deptid.Text = " ";
            txt_deptname.Clear();
            txt_deptdescription.Clear();
            MessageBox.Show("Row(s) updated");
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            //int dt = dbConnection.Btn_Delete_Click(Convert.ToString(cmb_deptid.Text));
            deparmentEntity.DeptId = Convert.ToString(cmb_deptid.Text);
            int i = employee.DeleteDepartmentRecord(deparmentEntity);

            MessageBox.Show(" Row(s) Deleted ");
            cmb_deptid.Text = " ";
            txt_deptname.Clear();
            txt_deptdescription.Clear();
            
        }

        private void Btn_view_Click(object sender, EventArgs e)
        {
            deparmentEntity.DeptId = Convert.ToString(cmb_deptid.Text);
            deparmentEntity.DeptName = txt_deptname.Text;
            deparmentEntity.DeptDescription = txt_deptdescription.Text;

            var dt = employee.SelectDepartmentRecord(deparmentEntity);
         
            dgrid_Deptinfo.DataSource = dt;
          
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Welcome we = new Welcome();
            we.Show();
            this.Hide();
        }
    }
}
