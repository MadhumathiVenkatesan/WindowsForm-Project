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
using BussinessEntity;
using BussinessLogic;

namespace Ems
{
    public partial class Insertempdetails : Form
    {
        SqlConnection con;
        SqlDataAdapter ad;
        DataTable dt;
        SqlCommand cmd;
        string gender = string.Empty;
        string status = string.Empty;
        EmployeeEntity _empEmployeeEntity;
        Employee _employee;

        public Insertempdetails()
        {
            InitializeComponent();
            _empEmployeeEntity = new EmployeeEntity();
            _employee = new Employee();
            cmd = new SqlCommand();
            dt = new DataTable();
        }
       


        private void Dtp_dob_ValueChanged(object sender, EventArgs e)
        {
            int Age = DateTime.Now.Year - dtp_dob.Value.Year;
            txt_Age.Text = Convert.ToString(Age);
        }

        private void Insertempdetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True ");
            ad = new SqlDataAdapter("select Deptid from tblDepartments", con);
            ad.Fill(dt);
            cmb_Deptid.ValueMember = "tblDepartments";
            foreach (DataRow dr in dt.Rows)
            {
                cmb_Deptid.Items.Add(dr["Deptid"].ToString());
            }
            SqlDataAdapter ad1 = new SqlDataAdapter("select projectName from tblProject", con);
            DataTable dt3 = new DataTable();
            ad1.Fill(dt3);
            cmbProjectname.ValueMember = "tblProject";
            foreach(DataRow dr in dt3.Rows)
            {
                cmbProjectname.Items.Add(dr["projectName"].ToString());
            }


        }

        private void Cmb_Deptid_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
            ad = new SqlDataAdapter("select Deptname from tblDepartments where Deptid='" + cmb_Deptid.SelectedItem + "' ", con);
            DataTable dt2 = new DataTable();
            ad.Fill(dt2);



            foreach (DataRow item in dt2.Rows)
            {
                string deptname = (string)item["Deptname"].ToString();
                txt_deptname.Text = deptname;


            }
            if (cmb_Deptid.Text == "F001")
            {
                cmb_Designation.Items.Add("Chief financial Officer");
                cmb_Designation.Items.Add("Management Accountant");
                cmb_Designation.Items.Add("Financial Accountant");
                cmb_Designation.Items.Add("Internal Auditor");
                cmb_Designation.Items.Add("Credit Controller");
                cmb_Designation.Items.Add("Clerk");
            }
            else if (cmb_Deptid.Text == "HR001")
            {
                cmb_Designation.Items.Add("HR director");
                cmb_Designation.Items.Add("Senior Executive HR");
                cmb_Designation.Items.Add("HR adminstrator");
                cmb_Designation.Items.Add("HR supervisor");

            }
            else if (cmb_Deptid.Text == "IT001")
            {
                cmb_Designation.Items.Add("Software Engineer");
                cmb_Designation.Items.Add("Technical lead");
                cmb_Designation.Items.Add("Project Manager");
                cmb_Designation.Items.Add("Technical Architect");
                cmb_Designation.Items.Add("Team lead");
                cmb_Designation.Items.Add("Vice President - Delivery");
            }
            else if (cmb_Deptid.Text == "M001")
            {
                cmb_Designation.Items.Add("Cheif Marketing Officer");
                cmb_Designation.Items.Add("Marketing Analyst");
                cmb_Designation.Items.Add("Marketing consultant");
                cmb_Designation.Items.Add("Marketing manager");

            }
            else if (cmb_Deptid.Text == "OM001")
            {
                cmb_Designation.Items.Add("Operations Executive");
                cmb_Designation.Items.Add("Operation manager");
                cmb_Designation.Items.Add("Assistant manager");
                cmb_Designation.Items.Add("Process re-engineering manager");

            }
            else if (cmb_Deptid.Text == "PM001")
            {
                cmb_Designation.Items.Add("Business analayst");
                cmb_Designation.Items.Add("Chief product officer");
                cmb_Designation.Items.Add("Product manager");
                cmb_Designation.Items.Add("Product officer");

            }
            else if (cmb_Deptid.Text == "RD001")
            {
                cmb_Designation.Items.Add("Research and development Associative");
                cmb_Designation.Items.Add("Senior Research engineer");
                cmb_Designation.Items.Add("Research and development manager");

            }

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            if (ValidateControls())
            {

                if (rdo_Male.Checked)
                {
                    gender = rdo_Male.Text;
                }
                if (rdo_Female.Checked)
                {
                    gender = rdo_Female.Text;
                }
                if (rdo_Single.Checked)
                {
                    status = rdo_Single.Text;
                }
                if (rdo_Married.Checked)
                {
                    status = rdo_Married.Text;
                }
                if (rdo_Divorced.Checked)
                {
                    status = rdo_Divorced.Text;
                }
             
                DateTime dob = dtp_dob.Value;
                DateTime doj = dtp_doj.Value;
                int Salary = Convert.ToInt32(txt_Salary.Text);
                _empEmployeeEntity.ID = cmb_Empid.Text;
                _empEmployeeEntity.Name = txt_Empname.Text;
                _empEmployeeEntity.FName = txt_Firstname.Text;
                _empEmployeeEntity.LName = txt_Lastname.Text;
                _empEmployeeEntity.MiddleName = txt_Middlename.Text;
                _empEmployeeEntity.FatherName = txt_Fathername.Text;
                _empEmployeeEntity.Gender = gender;
                _empEmployeeEntity.DOB = dob;
                _empEmployeeEntity.Age = Convert.ToInt32(txt_Age.Text);
                _empEmployeeEntity.ContactNumber = txt_Contactno.Text;
                _empEmployeeEntity.Status = status;
                _empEmployeeEntity.Emailid = txt_emailid.Text;
                _empEmployeeEntity.Address = txt_Address.Text;
                _empEmployeeEntity.DepartmentId = cmb_Deptid.SelectedItem.ToString();
                _empEmployeeEntity.DepartmentName = txt_deptname.Text;
                _empEmployeeEntity.DesignationName=cmb_Designation.SelectedItem.ToString();
                _empEmployeeEntity.EmployeeType=cmb_Type.SelectedItem.ToString();
                _empEmployeeEntity.DOJ = doj;
                _empEmployeeEntity.Salary = txt_Salary.Text;
                _empEmployeeEntity.ProjectName = cmbProjectname.Text;
                _empEmployeeEntity.ReportingManager =txt_manager.Text;
                _empEmployeeEntity.ProjectHead = txt_Projecthead.Text;
                int i = _employee.InsertRecord(_empEmployeeEntity);
                if (i > 0)
                {
                    MessageBox.Show("Records inserted");
                }
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }


        public bool ValidateControls()
        {
            Control[] controls = { cmb_Empid, txt_Empname, txt_Firstname,txt_Lastname,txt_Fathername,txt_Age,txt_emailid,txt_Contactno,txt_Address,cmb_Deptid,txt_deptname,cmb_Designation,cmb_Type,txt_Salary,cmbProjectname };
            foreach (var control in controls.Where(e => String.IsNullOrWhiteSpace(e.Text)))
            {
                errorProvider1.SetError(control, "Please fill the required field");
                return false;
            }

            return true;
        }

        private void CmbProjectname_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
            ad = new SqlDataAdapter("select Reportingto,projectHead from tblProject where projectName='" + cmbProjectname.SelectedItem + "' ", con);
            DataTable dt2 = new DataTable();
            ad.Fill(dt2);



            foreach (DataRow item in dt2.Rows)
            {
                string reporting = (string)item["Reportingto"].ToString();
                txt_manager.Text = reporting;
                string projecthead = (string)item["projectHead"].ToString();
                txt_Projecthead.Text = projecthead;



            }
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            Employeeview ev = new Employeeview();
            ev.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Employee_details ed = new Employee_details();
            ed.Show();
            this.Hide();
        }
    }
}
