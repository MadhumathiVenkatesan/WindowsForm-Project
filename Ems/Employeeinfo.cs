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
    public partial class Employeeinfo : Form
    {
        public Employeeinfo()
        {
            InitializeComponent();
        }

      

        private void Btn_Continue_Click(object sender, EventArgs e)
        {
            Loginform lf = new Loginform();
            lf.Show();
            this.Hide();
        }
    }
}
