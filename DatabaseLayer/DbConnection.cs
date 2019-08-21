using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessEntity;

namespace DatabaseLayer
{
    public class DbConnection
    {
        SqlConnection con;
        SqlDataAdapter ad;
        SqlCommand cmd;
        DataTable dt;
        
        public DbConnection()
        {
            con= new SqlConnection(@"Data Source=ATMECSBLRLT-040\SQLEXPRESS01;Initial Catalog=Employeeinfo;Integrated Security=True");
            
        }
       
       

        public DataTable CommonMethodSelection(string query)
        {
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            dt = new DataTable();
            ad.Fill(dt);
            con.Close();
            return dt;
        }

     
        public int Btn_Updatedepartments_Click(string deptid, string deptname, string deptdesc)
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UpdateDepartmentDetails ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@deptId", deptid);
            cmd.Parameters.AddWithValue("@deptName", deptname);
            cmd.Parameters.AddWithValue("@deptDescription", deptdesc);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
      

        public int Btn_Delete_Click(string deptid)
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DeleteDepartmentDetails ";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@deptId", deptid);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
            
        }

        public DataTable GetDepartmentName(string deptid)
        {
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select Deptname,Deptdesc from tblDepartments where Deptid='" + deptid + "' ", con);
            con.Open();       
            var dr= cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();
            return dt;
        }




        public int SetValueInDb(SqlParameter[] parameters, string procName)
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(parameters);      
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
        public DataTable SelectValueInDb(SqlParameter[] parameters, string procName)
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = procName;
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(parameters);
            con.Open();
            SqlDataReader dr= cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }
    }

    }


