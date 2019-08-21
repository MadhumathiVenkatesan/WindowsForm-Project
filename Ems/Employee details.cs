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
    public partial class Employee_details : Form
    {
        public Employee_details()
        {
            InitializeComponent();
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            Insertempdetails ins = new Insertempdetails();
            ins.Show();
            this.Hide();
        }

        private void Btn_Updateemployee_Click(object sender, EventArgs e)
        {
            Updateempdetails ins = new Updateempdetails();
            ins.Show();
            
            this.Hide();
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Employeeview ev = new Employeeview();
            ev.Show();
            this.Hide();
        }

        private void BtnEmpdelete_Click(object sender, EventArgs e)
        {
          
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Deleteempdetails ev = new Deleteempdetails();
            ev.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {

            Welcome we = new Welcome();
            we.Show();
            this.Hide();
        }
    }
}
