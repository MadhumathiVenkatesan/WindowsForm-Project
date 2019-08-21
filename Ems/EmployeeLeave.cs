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
    public partial class EmployeeLeave : Form
    {
        SqlConnection con;
        SqlDataAdapter ad;
        DbConnection dbConnection;
        DataTable dt;
        EmployeeLeaveEntity elv;
        Employee employee;
        public EmployeeLeave()
        {
            InitializeComponent();
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
            dbConnection = new DbConnection();
            elv = new EmployeeLeaveEntity();
            employee = new Employee();
        }

        private void EmployeeLeave_Load(object sender, EventArgs e)
        {
            var dt = dbConnection.CommonMethodSelection("select PK_Empid from tblEmployee");

            cmbEmployeeid.ValueMember = "tblEmployee";
            foreach (DataRow dr in dt.Rows)
            {
                cmbEmployeeid.Items.Add(dr["PK_Empid"].ToString());

            }
        }

        private void CmbEmployeeid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter ad1 = new SqlDataAdapter("select Empname,Deptname,Designation from tblEmployee where PK_Empid='" + cmbEmployeeid.SelectedItem + "' ", con);
            DataTable dt2 = new DataTable();
            ad1.Fill(dt2);
            foreach (DataRow item in dt2.Rows)
            {
                string Empname = (string)item["Empname"].ToString();
                txtEmployeename.Text = Empname;
                string Deptname = (string)item["Deptname"].ToString();
                txtDepartmentname.Text = Deptname;
                string Desingation = (string)item["Designation"].ToString();
                txtdesign.Text = Desingation;

            }
        }

        private void Dtp2To_ValueChanged(object sender, EventArgs e)
        {
            int Days = dtp2To.Value.Day - dtp1from.Value.Day;
            dtpDays.Text = Days.ToString();
        }

        private void BtnUpdateLeaveRecord_Click(object sender, EventArgs e)
        {
            elv.EmpId = cmbEmployeeid.SelectedItem.ToString();
            elv.EmpName = txtEmployeename.Text;
            elv.Deptname = txtDepartmentname.Text;
            elv.Designation = txtdesign.Text;
            elv.Reason = txtReason.SelectedItem.ToString();
            elv.From = dtp1from.Value;
            elv.To = dtp2To.Value;

            elv.Days = Convert.ToInt32(dtpDays.Text);
            elv.Status = cmbLStatus.SelectedItem.ToString();
            int i = employee.InsertEmployeeLeaveRecord(elv);
            if (i > 0)
            {
                MessageBox.Show("Record updated");
            }
        }

        private void Btn_UpdateStatus_Click(object sender, EventArgs e)
        {
            elv.EmpId = cmbEmployeeid.SelectedItem.ToString();
            elv.From = dtp1from.Value;
            elv.To = dtp2To.Value;
            elv.Days = Convert.ToInt32(dtpDays.Text);
            elv.Status = cmbLStatus.SelectedItem.ToString();
            employee.UpdateEmployeeLeaveRecord(elv);
            MessageBox.Show("Status updated");
        }

        private void BtnDeleteLeaveRecord_Click(object sender, EventArgs e)
        {
            elv.EmpId = cmbEmployeeid.SelectedItem.ToString();
            employee.DeleteEmployeeLeaveRecord(elv);
            MessageBox.Show("Record Deleted ");
        }


        private void Dgdeleteview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnViewLeavedetails_Click(object sender, EventArgs e)
        {
            var dt = dbConnection.CommonMethodSelection("select * from tblEmployeeLeave");
            dgdeleteview.DataSource = dt;

        }

        private void Dgdeleteview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = 0;
            rowIndex = e.RowIndex;
            if (rowIndex >= 0)
            {
                DataGridViewRow row = this.dgdeleteview.Rows[rowIndex];
                cmbEmployeeid.Text = row.Cells[0].Value.ToString();
                txtEmployeename.Text = row.Cells[1].Value.ToString();
                txtDepartmentname.Text = row.Cells[2].Value.ToString();
                txtdesign.Text = row.Cells[3].Value.ToString();
                txtReason.Text = row.Cells[4].Value.ToString();
                dtp1from.Value = Convert.ToDateTime(row.Cells[5].Value);
                dtp2To.Value = Convert.ToDateTime(row.Cells[6].Value);
                dtpDays.Text = row.Cells[7].Value.ToString();
                cmbLStatus.Text = row.Cells[8].Value.ToString();



            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            Welcome we = new Welcome();
            we.Show();
            this.Hide();
        }
    }
}


