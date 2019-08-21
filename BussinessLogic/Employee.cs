using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessEntity;
using DatabaseLayer;
using System.Data;
namespace BussinessLogic
{
    public class Employee
    {
        DbConnection _dbConnection;
        DataTable dt = new DataTable();
        
        public int InsertRecord(EmployeeEntity employee)
        {
                _dbConnection = new DbConnection();

                return _dbConnection.SetValueInDb(new SqlParameter[]
                {
                        new SqlParameter("@Empid", employee.ID),
                        new SqlParameter("@Empname", employee.Name),
                        new SqlParameter("@Firstname", employee.FName),
                        new SqlParameter("@Middlename", employee.MiddleName),
                        new SqlParameter("@Lastname", employee.LName),
                        new SqlParameter("@Fathername", employee.FatherName),
                        new SqlParameter("@Gender", employee.Gender),
                        new SqlParameter("@Bday", employee.DOB.Date),
                        new SqlParameter("@Age", employee.Age),
                        new SqlParameter("@Martialstatus", employee.Status),
                          new SqlParameter("@Emailid", employee.Emailid),
                        new SqlParameter("@Contactno", employee.ContactNumber),
                        new SqlParameter("@Address",employee.Address),
                        new SqlParameter("@Deptid",employee.DepartmentId),
                        new SqlParameter("@Deptname", employee.DepartmentName),
                        new SqlParameter("@Designation", employee.DesignationName),
                        new SqlParameter("@Type", employee.EmployeeType),
                        new SqlParameter("@DOJ", employee.DOJ.Date),
                        new SqlParameter("@Salary", employee.Salary),
                        new SqlParameter("@Project", employee.ProjectName),
                        new SqlParameter("@ReportingManager", employee.ReportingManager),
                        new SqlParameter("@ProjectHead", employee.ProjectHead),
                       
                 }, "sp_InsertEmployeeDetails");
        }
        public int UpdateEmpRecord(EmployeeEntity employee)
        {
            _dbConnection = new DbConnection();

            return _dbConnection.SetValueInDb(new SqlParameter[]
            {
                        new SqlParameter("@Empid", employee.ID),
                        new SqlParameter("@Empname", employee.Name),
                        new SqlParameter("@Firstname", employee.FName),
                        new SqlParameter("@Middlename", employee.MiddleName),
                        new SqlParameter("@Lastname", employee.LName),
                        new SqlParameter("@Fathername", employee.FatherName),
                        new SqlParameter("@Gender", employee.Gender),
                        new SqlParameter("@Bday", employee.DOB.Date),
                        new SqlParameter("@Age", employee.Age),
                        new SqlParameter("@Martialstatus", employee.Status),
                          new SqlParameter("@Emailid", employee.Emailid),
                        new SqlParameter("@Contactno", employee.ContactNumber),
                        new SqlParameter("@Address",employee.Address),
                        new SqlParameter("@Deptid",employee.DepartmentId),
                        new SqlParameter("@Deptname", employee.DepartmentName),
                        new SqlParameter("@Designation", employee.DesignationName),
                        new SqlParameter("@Type", employee.EmployeeType),
                        new SqlParameter("@DOJ", employee.DOJ.Date),
                        new SqlParameter("@Salary", employee.Salary),
                        new SqlParameter("@Project", employee.ProjectName),
                        new SqlParameter("@ReportingManager", employee.ReportingManager),
                        new SqlParameter("@ProjectHead", employee.ProjectHead),
                       

             }, "sp_UpdateEmployeeDetails");
        }

        public int DeleteEmpRecord(EmployeeEntity employee)
        {
            _dbConnection = new DbConnection();

            return _dbConnection.SetValueInDb(new SqlParameter[]
            {
                        new SqlParameter("@Empid", employee.ID),
                       


             }, "sp_DeleteEmployeeDetails");
        }
        public int InsertDepartmentRecord(DeparmentEntity department )
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
                new SqlParameter("@deptId",department.DeptId),
            new SqlParameter("@deptName",department.DeptName),
            new SqlParameter("@deptDescription",department.DeptDescription)
            }, "sp_InsertDepartmentDetails");
        }
        public int UpdateDepartmentRecord(DeparmentEntity department)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
                new SqlParameter("@deptId",department.DeptId),
            new SqlParameter("@deptName",department.DeptName),
            new SqlParameter("@deptDescription",department.DeptDescription)
            }, "sp_UpdateDepartmentDetails");
        }
        public int DeleteDepartmentRecord(DeparmentEntity department)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
                new SqlParameter("@deptId",department.DeptId),
           
            }, "sp_DeleteDepartmentDetails");
        }
        public DataTable SelectDepartmentRecord(DeparmentEntity department)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SelectValueInDb(new SqlParameter[] {
                new SqlParameter("@deptId",department.DeptId),
                 new SqlParameter("@deptName",department.DeptName),
            new SqlParameter("@deptDescription",department.DeptDescription)

            }, "sp_SelectDetails");
        }

        public int InsertProjectRecord(ProjectEntity project)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
                new SqlParameter("@projectId",project.projectId),
            new SqlParameter("@projectName",project.projectName),
            new SqlParameter("@projectHead",project.projectHead),
             new SqlParameter("@Reportingto",project.reportingTo),
              new SqlParameter("@Technology",project.technology),
               new SqlParameter("@Client",project.client),
            }, "sp_ProjectInsdetails");
        }
            public int UpdateProjectRecord(ProjectEntity project)
            {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
                new SqlParameter("@projectId",project.projectId),
            new SqlParameter("@projectName",project.projectName),
            new SqlParameter("@projectHead",project.projectHead),
             new SqlParameter("@Reportingto",project.reportingTo),
              new SqlParameter("@Technology",project.technology),
               new SqlParameter("@Client",project.client),
            }, "sp_ProjectUpdatedetails");
        
        }
        public int DeleteProjectRecord(ProjectEntity project)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
                new SqlParameter("@projectId",project.projectId),
            },"sp_ProjectDeletedetails");
        }
        public DataTable SelectProjectRecord(ProjectEntity project)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SelectValueInDb(new SqlParameter[] {
                new SqlParameter("@projectId",project.projectId),
            }, "sp_ProjectDeletedetails");

        }
        public int InsertEmployeeLeaveRecord(EmployeeLeaveEntity leave)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
                new SqlParameter("@EmpId",leave.EmpId),
            new SqlParameter("@EmployeeName",leave.EmpName),
            new SqlParameter("@DepartmentName",leave.Deptname),
             new SqlParameter("@Designation",leave.Designation),
              new SqlParameter("@Reason",leave.Reason),
               new SqlParameter("@LFrom",leave.From),
                 new SqlParameter("@LTo",leave.To),
                   new SqlParameter("@Days",leave.Days),
                     new SqlParameter("@Status",leave.Status),
            }, "sp_InsertLeave");
        }
        public int UpdateEmployeeLeaveRecord(EmployeeLeaveEntity leave)
        {
            _dbConnection = new DbConnection();
            return _dbConnection.SetValueInDb(new SqlParameter[] {
               new SqlParameter("@Empid",leave.EmpId),
               new SqlParameter("@LFrom",leave.From),
                 new SqlParameter("@LTo",leave.To),
                   new SqlParameter("@Days",leave.Days),
                     new SqlParameter("@Status",leave.Status),
            }, "sp_UpdateStatus");
        }
            public int DeleteEmployeeLeaveRecord(EmployeeLeaveEntity leave)
            {
                _dbConnection = new DbConnection();
                return _dbConnection.SetValueInDb(new SqlParameter[] {
               new SqlParameter("@Empid",leave.EmpId),
              
            }, "sp_DeleteLeaverecord");
            }

        }

}
