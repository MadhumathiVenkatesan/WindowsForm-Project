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
using DatabaseLayer;

namespace Ems
{
    public partial class Updateempdetails : Form
    {
        SqlConnection con;
        SqlDataAdapter ad;
        DataTable dt = new DataTable();
        EmployeeEntity _empEmployeeEntity;
        Employee _employee;
        string gender = string.Empty;
        string status = string.Empty;
        DbConnection _dbConnection;


        public Updateempdetails()
        {
            InitializeComponent();
            _empEmployeeEntity = new EmployeeEntity();
            _employee = new Employee();
            _dbConnection = new DbConnection();
            
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void Updateempdetails_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True ");
            ad = new SqlDataAdapter("select PK_Empid from tblEmployee", con);


            ad.Fill(dt);
            cmbEmpid.ValueMember = "tblEmployee";
            foreach (DataRow dr in dt.Rows)
            {
                cmbEmpid.Items.Add(dr["PK_Empid"].ToString());
            }

        }

        private void CmbEmpid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter ad1 = new SqlDataAdapter("select Empname,Firstname,Middlename,Lastname,Fathername,Gender,Bday,Age,Martialstatus,Emailid,Contactno,Address,FK_Deptid,Deptname,Designation,Type,DOJ,Salary,Project,ReportingManager,ProjectHead from tblEmployee where PK_Empid='" + cmbEmpid.SelectedItem + "' ", con);
            DataTable dt2 = new DataTable();
            ad1.Fill(dt2);
            foreach (DataRow item in dt2.Rows)
            {
                string Empname = (string)item["Empname"].ToString();
                txt_Empname.Text = Empname;
                string Firstname = (string)item["Firstname"].ToString();
                txt_Firstname.Text = Firstname;
                string Middlename = (string)item["Middlename"].ToString();
                txt_Middlename.Text = Middlename;
                string Lastname = (string)item["Lastname"].ToString();
                txt_Lastname.Text = Lastname;
                string Fathername = (string)item["Fathername"].ToString();
                txt_Fathername.Text = Fathername;
                string Gender = (string)item["Gender"].ToString();
                if (item["Gender"].ToString() == "Male")
                {
                    rdo_Male.Checked = true;
                }
                else
                {
                    rdo_Female.Checked = true;
                }
                dtp_dob.Value = (DateTime)item["Bday"];
                string reporting = (string)item["ReportingManager"].ToString();
                int age = (int)item["Age"];
                txt_Age.Text = age.ToString();
                if (item["Martialstatus"].ToString() == "Single")
                {
                    rdo_Single.Checked = true;
                }
                else if (item["Martialstatus"].ToString() == "Married")
                {
                    rdo_Married.Checked = true;
                }
                else
                {
                    rdo_Divorced.Checked = true;
                }
                string mailid = (string)item["Emailid"].ToString();
                txt_emailid.Text = mailid;

                txt_manager.Text = reporting;
                string projecthead = (string)item["projectHead"].ToString();
                txt_Projecthead.Text = projecthead;
                string contactno = (string)item["Contactno"].ToString();
                txt_Contactno.Text = contactno;
                string address = (string)item["Address"].ToString();
                txt_Address.Text = address;
                string deptid = (string)item["FK_Deptid"].ToString();
                cmb_Deptid.Text = deptid;

                string deptname = (string)item["Deptname"].ToString();
                txt_deptname.Text = address;
                string designation = (string)item["Designation"].ToString();
                cmb_Designation.Text = designation;
                string type = (string)item["Type"].ToString();
                cmb_Type.Text = type;
                string salary = (string)item["Salary"].ToString();
                txt_Salary.Text = salary;
                string project = (string)item["Project"].ToString();
                cmbProjectname.Text = project;


            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
           
           
            
            _empEmployeeEntity.ID = cmbEmpid.Text;
            _empEmployeeEntity.Name = txt_Empname.Text;
            _empEmployeeEntity.FName = txt_Firstname.Text;
            _empEmployeeEntity.LName = txt_Lastname.Text;
            _empEmployeeEntity.MiddleName = txt_Middlename.Text;
            _empEmployeeEntity.FatherName = txt_Fathername.Text;
            _empEmployeeEntity.Gender = gender;
            DateTime dob = dtp_dob.Value;
            _empEmployeeEntity.DOB = dob;
            _empEmployeeEntity.Age = Convert.ToInt32(txt_Age.Text);
            _empEmployeeEntity.ContactNumber = txt_Contactno.Text;
            _empEmployeeEntity.Status = status;
            _empEmployeeEntity.Emailid = txt_emailid.Text;
            _empEmployeeEntity.Address = txt_Address.Text;
            _empEmployeeEntity.DepartmentId = cmb_Deptid.Text;
            _empEmployeeEntity.DepartmentName = txt_deptname.Text;
            _empEmployeeEntity.DesignationName = cmb_Designation.Text;
        
            _empEmployeeEntity.EmployeeType = cmb_Type.Text;
            DateTime doj = dtp_doj.Value;
            _empEmployeeEntity.DOJ = doj;
            int Salary = Convert.ToInt32(txt_Salary.Text);
            _empEmployeeEntity.Salary = txt_Salary.Text;
            _empEmployeeEntity.ProjectName = cmbProjectname.Text;
            _empEmployeeEntity.ReportingManager = txt_manager.Text;
            _empEmployeeEntity.ProjectHead = txt_Projecthead.Text;
            int i = _employee.UpdateEmpRecord(_empEmployeeEntity);
            MessageBox.Show("Record updated");
        }

        private void Btnview_Click(object sender, EventArgs e)
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
