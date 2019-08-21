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
using System.Text.RegularExpressions;

namespace Ems
{
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

        //Username Validations

        private void txt_Username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Username.Text))
            {
                e.Cancel = true;
                txt_Username.Focus();
                errorProvider1.SetError(txt_Username, "Please enter the username");
            }
            else if (txt_Username.Text.Length >5)
            {
                e.Cancel = true;
                txt_Username.Focus();
                errorProvider1.SetError(txt_Username, "The username should be minimum of 5 characters");
            }
           

        }


        //Password Validations
        private void txt_Password_Validating(object sender, CancelEventArgs e)
        {
            Regex len = new Regex("^.{6,10}$");
            Regex num = new Regex("\\d");
            Regex alpha = new Regex("\\D");
            Regex special = new Regex("[><%#@]"); // Put  here more special characters

            if (len.IsMatch(txt_Password.Text) && num.IsMatch(txt_Password.Text) && alpha.IsMatch(txt_Password.Text) && special.IsMatch(txt_Password.Text))
            {

                e.Cancel = true;
                txt_Password.Focus();

            }


            else if ((string.IsNullOrEmpty(txt_Password.Text)))
            {
                e.Cancel = true;
                txt_Password.Focus();
                errorProvider1.SetError(txt_Password, "Password is not valid");
            }
        }



        // Checking whether the credentails are valid
        private void Btn_login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
            SqlDataAdapter ad = new SqlDataAdapter("select * from tblEmpLogin where username='"+txt_Username.Text+"' and password='"+txt_Password.Text+"' ", con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login succeed");
                Welcome we = new Welcome();
                we.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid credentials");
            }
   
          



        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Password.Clear();
          
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Employeeinfo ins = new Employeeinfo();
            ins.Show();
            this.Hide();

        }
    }
}
