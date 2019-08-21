USE [Employeeinfo]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_UpdateStatus]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateEmployeeDetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_UpdateEmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDepartmentDetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_UpdateDepartmentDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_SelectDetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_SelectDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectUpdatedetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_ProjectUpdatedetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectSelectdetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_ProjectSelectdetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectInsdetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_ProjectInsdetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectDeletedetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_ProjectDeletedetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertLeave]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_InsertLeave]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertEmployeeDetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_InsertEmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDepartmentDetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_InsertDepartmentDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteLeaverecord]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_DeleteLeaverecord]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteEmployeeDetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_DeleteEmployeeDetails]
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDepartmentDetails]    Script Date: 21-08-2019 18:26:19 ******/
DROP PROCEDURE IF EXISTS [dbo].[sp_DeleteDepartmentDetails]
GO
/****** Object:  Table [dbo].[tblProject]    Script Date: 21-08-2019 18:26:19 ******/
DROP TABLE IF EXISTS [dbo].[tblProject]
GO
/****** Object:  Table [dbo].[tblEmployeeleave]    Script Date: 21-08-2019 18:26:19 ******/
DROP TABLE IF EXISTS [dbo].[tblEmployeeleave]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 21-08-2019 18:26:19 ******/
DROP TABLE IF EXISTS [dbo].[tblEmployee]
GO
/****** Object:  Table [dbo].[tblEmpLogin]    Script Date: 21-08-2019 18:26:19 ******/
DROP TABLE IF EXISTS [dbo].[tblEmpLogin]
GO
/****** Object:  Table [dbo].[tblDepartments]    Script Date: 21-08-2019 18:26:19 ******/
DROP TABLE IF EXISTS [dbo].[tblDepartments]
GO
/****** Object:  Table [dbo].[tblDepartments]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDepartments](
	[Deptid] [varchar](50) NOT NULL,
	[Deptname] [varchar](50) NULL,
	[Deptdesc] [varchar](max) NULL,
 CONSTRAINT [PK_departments] PRIMARY KEY CLUSTERED 
(
	[Deptid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmpLogin]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmpLogin](
	[username] [char](10) NOT NULL,
	[password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployee]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployee](
	[PK_Empid] [varchar](50) NOT NULL,
	[Empname] [varchar](50) NOT NULL,
	[Firstname] [varchar](50) NOT NULL,
	[Middlename] [varchar](50) NULL,
	[Lastname] [varchar](50) NOT NULL,
	[Fathername] [varchar](50) NOT NULL,
	[Gender] [varchar](50) NOT NULL,
	[Bday] [date] NOT NULL,
	[Age] [int] NOT NULL,
	[Martialstatus] [varchar](50) NOT NULL,
	[Emailid] [varchar](max) NOT NULL,
	[Contactno] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[FK_Deptid] [varchar](50) NOT NULL,
	[Deptname] [varchar](50) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[DOJ] [date] NOT NULL,
	[Salary] [numeric](18, 0) NOT NULL,
	[Project] [varchar](50) NULL,
	[ReportingManager] [varchar](50) NULL,
	[ProjectHead] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PK_Empid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEmployeeleave]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblEmployeeleave](
	[Empid] [varchar](50) NOT NULL,
	[Employeename] [varchar](50) NOT NULL,
	[Departmentname] [varchar](50) NOT NULL,
	[Designation] [varchar](50) NOT NULL,
	[Reason] [varchar](50) NOT NULL,
	[LFrom] [datetime] NOT NULL,
	[LTo] [datetime] NOT NULL,
	[Days] [numeric](18, 0) NOT NULL,
	[Status] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblProject]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProject](
	[projectId] [varchar](50) NOT NULL,
	[projectName] [varchar](50) NOT NULL,
	[projectHead] [varchar](50) NOT NULL,
	[Reportingto] [varchar](50) NOT NULL,
	[Technology] [varchar](50) NOT NULL,
	[Client] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[projectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblDepartments] ([Deptid], [Deptname], [Deptdesc]) VALUES (N'F001', N'Finance And Account', N'The accounting department is responsible for a large number of administrative functions within an organizations.The business functions of a finance department typically include planning, organizing, auditing, accounting for and controlling its company''s finances. The finance department also usually produces the company''s financial statements')
GO
INSERT [dbo].[tblDepartments] ([Deptid], [Deptname], [Deptdesc]) VALUES (N'HR001', N'HumanResources', N'The human resources department handles a range of different functions within an organization. The department is responsible for hiring and firing employees, training workers, maintaining interoffice relationships and interpreting employment laws. The department works diligently behind the scenes to ensure an organization runs efficiently.')
GO
INSERT [dbo].[tblDepartments] ([Deptid], [Deptname], [Deptdesc]) VALUES (N'IT001', N'InformationTechnology', N'An IT organization (information technology organization) is the department within a company that is charged with establishing, monitoring and maintaining information technology systems and services. The information technology department in an organization is responsible for the architecture, hardware, software and networking of computers in the company.')
GO
INSERT [dbo].[tblDepartments] ([Deptid], [Deptname], [Deptdesc]) VALUES (N'M001', N'Marketing', N'The Marketing Department plays a vital role in promoting the business and mission of an organization. It serves as the face of your company, coordinating and producing all materials representing the business. It is the Marketing Department''s job to reach out to prospects, customers, investors and/or the community, while creating an overarching image that represents your company in a positive light.')
GO
INSERT [dbo].[tblDepartments] ([Deptid], [Deptname], [Deptdesc]) VALUES (N'OM001', N'OperationsManagement', N'Operations Management is a branch that deals with managing operations and processes within the organisation. Efficacious management of operations ensures successful delivery of the project. The operation managers optimises the operations by making judicious use of resources and capital.')
GO
INSERT [dbo].[tblDepartments] ([Deptid], [Deptname], [Deptdesc]) VALUES (N'PM001', N'ProductManagement', N'Product management is the practice of strategically driving the development, market launch, and continual support and improvement of a company’s products.Product management encompasses a large set of ongoing strategic responsibilities. ')
GO
INSERT [dbo].[tblDepartments] ([Deptid], [Deptname], [Deptdesc]) VALUES (N'RD001', N'Research and Development', N'Research development (RD) is a set of strategic, proactive, catalytic, and capacity-building activities designed to facilitate individual faculty members, teams of researchers, and central research administrations in attracting extramural research funding, creating relationships, and developing and implementing strategies that increase institutional competitiveness.')
GO
INSERT [dbo].[tblEmpLogin] ([username], [password]) VALUES (N'Admin     ', N'Admin@123')
GO
INSERT [dbo].[tblEmployeeleave] ([Empid], [Employeename], [Departmentname], [Designation], [Reason], [LFrom], [LTo], [Days], [Status]) VALUES (N'E001', N'Madhumathi Venkatesan				', N'sdsdcsdcsdcdscdcs', N'Software Engineer', N'Personal work', CAST(N'2019-08-20T21:57:00.000' AS DateTime), CAST(N'2019-08-22T21:57:00.000' AS DateTime), CAST(2 AS Numeric(18, 0)), N'Pending')
GO
INSERT [dbo].[tblProject] ([projectId], [projectName], [projectHead], [Reportingto], [Technology], [Client]) VALUES (N'FPR', N'Fake Product Review Monitoring', N'Arjun K', N'Sara', N'ASP.net C#', N'US')
GO
INSERT [dbo].[tblProject] ([projectId], [projectName], [projectHead], [Reportingto], [Technology], [Client]) VALUES (N'HCS', N'HealthCare Chat BOT System', N'Gugan', N'Saravanan', N'Artificial Intelligence', N'JPN')
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteDepartmentDetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteDepartmentDetails] 
	@deptId varchar(50)
	
AS
BEGIN
DELETE FROM tblDepartments where Deptid=@deptId
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteEmployeeDetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteEmployeeDetails] 
	@Empid varchar(50)
	
AS
BEGIN
DELETE FROM tblEmployee where PK_Empid=@EmpId
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteLeaverecord]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_DeleteLeaverecord] 
@Empid varchar(50)
	
	
	
	AS
BEGIN
	 DELETE FROM tblEmployeeleave where Empid=@Empid;
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertDepartmentDetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertDepartmentDetails] 
	@deptId varchar(50),
	@deptName varchar(50),
	@deptDescription varchar(MAX) null
AS
BEGIN
	INSERT INTO tblDepartments(Deptid, Deptname, Deptdesc) VALUES
	(@deptId, @deptName, @deptDescription)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertEmployeeDetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertEmployeeDetails] 
	@Empid varchar(50),
	@Empname varchar(50),
	@Firstname varchar(50),
	@Middlename varchar(50),
	@Lastname varchar(50),
	@Fathername varchar(50),
	@Gender char(10),
	@Bday date,
	@Age int,
	@Martialstatus varchar(50),
	@Emailid varchar(max),
	@Contactno varchar(50),
	@Address varchar(50),
	@Deptid varchar(50),
	@Deptname varchar(50),
	@Designation varchar(50),
	@Type varchar(50),
	@DOJ date,
	@Salary numeric(18,0),
     @Project varchar(50),
	@ReportingManager varchar(50),
	@ProjectHead varchar(50)

AS
BEGIN
	INSERT INTO tblEmployee(PK_Empid,Empname,Firstname,Middlename,Lastname,Fathername,Gender,Bday,Age,Martialstatus,Emailid,Contactno,Address,FK_Deptid,Deptname,Designation,Type,DOJ,Salary,Project,ReportingManager,ProjectHead)Values(@Empid,@Empname,@Firstname,@Middlename,@Lastname,@Fathername,@Gender,@Bday,@Age,@Martialstatus,@Emailid,@Contactno,@Address,@Deptid,@Deptname,@Designation,@Type,@DOJ,@Salary,@Project,@ReportingManager,@ProjectHead)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertLeave]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_InsertLeave] 
@Empid varchar(50),
	@Employeename varchar(50),
	@Departmentname varchar(50),
	@Designation varchar(50),
	@Reason varchar(50),
	@LFrom varchar(50),
	@LTo varchar(50),
	@Days varchar(50),
	@Status varchar(50)
	
AS
BEGIN
	INSERT INTO tblEmployeeleave(Empid,Employeename,Departmentname,Designation,Reason,LFrom,LTo,Days,Status)values(@Empid,@Employeename,@Departmentname,@Designation,@Reason,@LFrom,@LTo,@Days,@Status) 
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectDeletedetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ProjectDeletedetails] 
	@projectId varchar(50)
	
AS
BEGIN
	DELETE FROM tblProject WHERE projectId=@projectId;
	
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectInsdetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ProjectInsdetails] 
	@projectId varchar(50),
	@projectName varchar(50),
	@projectHead varchar(50),
	@Reportingto varchar(50),
	@Technology varchar(50),
	@Client varchar(50)
AS
BEGIN
	INSERT INTO tblProject(projectId,projectName,projectHead,Reportingto,Technology,Client)Values
	(@projectId,@projectName,@projectHead,@Reportingto,@Technology,@Client)
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectSelectdetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ProjectSelectdetails] 
	@projectId varchar(50)
	
AS
BEGIN
	SELECT projectId,projectName,projectHead,Reportingto,Technology,Client FROM tblProject WHERE projectId=@projectId;
	
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_ProjectUpdatedetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ProjectUpdatedetails] 
	@projectId varchar(50),
	@projectName varchar(50),
	@projectHead varchar(50),
	@Reportingto varchar(50),
	@Technology varchar(50),
	@Client varchar(50)
AS
BEGIN
	Update tblProject SET
	projectName=@projectName,projectHead=@projectHead,ReportingTo=@Reportingto,Technology=@Technology,client=@Client WHERE projectId=@projectId
	END

GO
/****** Object:  StoredProcedure [dbo].[sp_SelectDetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_SelectDetails] 
	@deptId varchar(50),
	@deptName varchar(50),
	@deptDescription varchar(MAX) null
AS
BEGIN
Select Deptid=@deptid,Deptname=@deptName,Deptdesc=@deptDescription from tblDepartments where Deptid=@deptid
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateDepartmentDetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateDepartmentDetails] 
	@deptId varchar(50),
	@deptName varchar(50),
	@deptDescription varchar(MAX) null
AS
BEGIN
     Update tblDepartments set Deptname=@deptName,Deptdesc=@deptDescription where Deptid=@deptId
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateEmployeeDetails]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateEmployeeDetails] 
	@Empid varchar(50),
	@Empname varchar(50),
	@Firstname varchar(50),
	@Middlename varchar(50),
	@Lastname varchar(50),
	@Fathername varchar(50),
	@Gender char(10),
	@Bday date,
	@Age int,
	@Martialstatus varchar(50),
	@Emailid varchar(max),
	@Contactno varchar(50),
	@Address varchar(50),
	@Deptid varchar(50),
	@Deptname varchar(50),
	@Designation varchar(50),
	@Type varchar(50),
	@DOJ date,
	@Salary numeric(18,0),
     @Project varchar(50),
	@ReportingManager varchar(50),
	@ProjectHead varchar(50)

AS
BEGIN
	UPDATE tblEmployee SET Empname=@Empname,Firstname=@Firstname,Middlename=@Middlename,Lastname=@Lastname,Fathername=@Fathername,Gender=@Gender,Bday=@Bday,Age=@Age,Martialstatus=@Martialstatus,Emailid=@Emailid,Contactno=@Contactno,Address=@Address,FK_Deptid=@Deptid,Deptname=@Deptname,Designation=@Designation,Type=@Type,DOJ=@DOJ,Salary=@Salary,Project=@Project,ReportingManager=@ReportingManager,ProjectHead=@ProjectHead where PK_Empid=@Empid
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStatus]    Script Date: 21-08-2019 18:26:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateStatus] 
@Empid varchar(50),
	
	
	@LFrom varchar(50),
	@LTo varchar(50),
	@Days varchar(50),
	@Status varchar(50)
	AS
BEGIN
	 UPDATE tblEmployeeleave SET LFrom=@LFrom,LTo=@LTo,Days=@Days,Status=@Status WHERE Empid=@Empid
	END

GO
