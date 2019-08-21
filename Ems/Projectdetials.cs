using DatabaseLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseLayer;
using BussinessEntity;
using BussinessLogic;

using System.Data.Common;
using dbConnection = DatabaseLayer.DbConnection;
using System.Data.SqlClient;

namespace Ems
{
    public partial class Projectdetials : Form
    {
        SqlConnection con;
        SqlDataAdapter ad;
        DataTable dt = new DataTable();
        SqlCommand cmd;
        SqlDataReader ExecuteReader;
        ProjectEntity proentity;
        Employee emp;
        public Projectdetials()
        {
            InitializeComponent();
            proentity = new ProjectEntity();
            emp = new Employee();
           
           

        }

        private void Projectdetials_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True ");
            ad = new SqlDataAdapter("select projectId from tblProject", con);
            ad.Fill(dt);
            cmb_Projectid.ValueMember = "tblProject";
            foreach (DataRow dr in dt.Rows)
            {
                cmb_Projectid.Items.Add(dr["projectId"].ToString());
            }





        }

        private void Cmb_Projectid_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True ");
            ad=new SqlDataAdapter("select * from tblProject where projectid = '" + cmb_Projectid.SelectedItem + "' ",con);

            ad.Fill(dt);
            DataTable dt1 = new DataTable();
            ad.Fill(dt1);
            dg_Projectdetails.DataSource = dt1;
            foreach (DataRow item in dt.Rows)
            {
                string Projectname = (string)item["projectName"].ToString();
                txt_Projectname.Text = Projectname;
                string Projecthead = (string)item["projectHead"].ToString();
                txt_Projecthead.Text = Projecthead;
                string Reportingto = (string)item["Reportingto"].ToString();
                txt_Reportingto.Text = Reportingto;
                string Technology = (string)item["Technology"].ToString();
                txt_Technology.Text = Technology;
                string client = (string)item["Client"].ToString();
                txt_Client.Text = client;
                
                

            }


           
            

        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            proentity.projectId = cmb_Projectid.Text;
            proentity.projectName= txt_Projectname.Text;
            proentity.projectHead = txt_Projecthead.Text;
            proentity.reportingTo = txt_Reportingto.Text;
            proentity.technology = txt_Technology.Text;
            proentity.client = txt_Client.Text;
            int i = emp.InsertProjectRecord(proentity);
           
            cmb_Projectid.Text = " ";
            txt_Projectname.Clear();
            txt_Projecthead.Clear();
            txt_Reportingto.Clear();
            txt_Technology.Clear();
            txt_Client.Clear();
          
            con.Close();
         
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            this.dg_Projectdetails.DataSource = null;
            proentity.projectId = cmb_Projectid.Text;
            proentity.projectName = txt_Projectname.Text;
            proentity.projectHead = txt_Projecthead.Text;
            proentity.reportingTo = txt_Reportingto.Text;
            proentity.technology = txt_Technology.Text;
            proentity.client = txt_Client.Text;
            int i = emp.UpdateProjectRecord(proentity);
            MessageBox.Show("Project Reocord Updated");
            
           
            cmb_Projectid.Text = " ";
            txt_Projectname.Clear();
            txt_Projecthead.Clear();
            txt_Reportingto.Clear();
            txt_Technology.Clear();
            txt_Client.Clear();
           
            con.Close();

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            proentity.projectId = cmb_Projectid.Text;
            int i = emp.DeleteProjectRecord(proentity);
            MessageBox.Show("Project Record deleted");
         
            cmb_Projectid.Text = " ";
            txt_Projectname.Clear();
            txt_Projecthead.Clear();
            txt_Reportingto.Clear();
            txt_Technology.Clear();
            txt_Client.Clear();
            this.dg_Projectdetails.DataSource = null;
            con.Close();
        }

        private void Btn_View_Click(object sender, EventArgs e)
        {
            this.dg_Projectdetails.DataSource = null;
            con = new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True ");
            ad = new SqlDataAdapter("select * from tblProject", con);
            DataTable dt2 = new DataTable();
            ad.Fill(dt2);
            dg_Projectdetails.DataSource = dt2;
           

            con.Close();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Welcome we = new Welcome();
            we.Show();
            this.Hide();
        }
    }
}
