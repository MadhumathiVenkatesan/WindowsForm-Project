using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ems
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

       

        private void Btn_Departments_Click(object sender, EventArgs e)
        {
            Department dt = new Department();
            dt.Show();
            this.Hide();
        }

        private void Btn_Employeedetails_Click(object sender, EventArgs e)
        {
            Employee_details details = new Employee_details();
            details.Show();
            this.Hide();
        }

        private void Btn_Project_Click(object sender, EventArgs e)
        {
            Projectdetials pd = new Projectdetials();
            pd.Show();
            this.Hide();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void BtnLeave_Click(object sender, EventArgs e)
        {
            EmployeeLeave el = new EmployeeLeave();
            el.Show();
            this.Hide();
        }

        private void LlbAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Aboutcs ab = new Aboutcs();
            ab.Show();
            this.Hide();
        }

        private void LlbOpenings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Job_openings jo = new Job_openings();
            jo.Show();
            this.Hide();
        }
    }
}
