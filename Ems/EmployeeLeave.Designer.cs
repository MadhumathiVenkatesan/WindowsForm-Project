namespace Ems
{
    partial class EmployeeLeave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeLeave));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgdeleteview = new System.Windows.Forms.DataGridView();
            this.btnViewLeavedetails = new System.Windows.Forms.Button();
            this.btnDeleteLeaveRecord = new System.Windows.Forms.Button();
            this.btn_UpdateStatus = new System.Windows.Forms.Button();
            this.btnUpdateLeaveRecord = new System.Windows.Forms.Button();
            this.dtpDays = new System.Windows.Forms.TextBox();
            this.dtp2To = new System.Windows.Forms.DateTimePicker();
            this.cmbLStatus = new System.Windows.Forms.ComboBox();
            this.dtp1from = new System.Windows.Forms.DateTimePicker();
            this.txtReason = new System.Windows.Forms.ComboBox();
            this.txtdesign = new System.Windows.Forms.TextBox();
            this.txtDepartmentname = new System.Windows.Forms.TextBox();
            this.cmbEmployeeid = new System.Windows.Forms.ComboBox();
            this.txtEmployeename = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdeleteview)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Wheat;
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.dgdeleteview);
            this.groupBox2.Controls.Add(this.btnViewLeavedetails);
            this.groupBox2.Controls.Add(this.btnDeleteLeaveRecord);
            this.groupBox2.Controls.Add(this.btn_UpdateStatus);
            this.groupBox2.Controls.Add(this.btnUpdateLeaveRecord);
            this.groupBox2.Controls.Add(this.dtpDays);
            this.groupBox2.Controls.Add(this.dtp2To);
            this.groupBox2.Controls.Add(this.cmbLStatus);
            this.groupBox2.Controls.Add(this.dtp1from);
            this.groupBox2.Controls.Add(this.txtReason);
            this.groupBox2.Controls.Add(this.txtdesign);
            this.groupBox2.Controls.Add(this.txtDepartmentname);
            this.groupBox2.Controls.Add(this.cmbEmployeeid);
            this.groupBox2.Controls.Add(this.txtEmployeename);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(101, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(923, 671);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Leave Details";
            // 
            // dgdeleteview
            // 
            this.dgdeleteview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdeleteview.Location = new System.Drawing.Point(106, 509);
            this.dgdeleteview.Name = "dgdeleteview";
            this.dgdeleteview.Size = new System.Drawing.Size(744, 167);
            this.dgdeleteview.TabIndex = 27;
            this.dgdeleteview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgdeleteview_CellClick);
            this.dgdeleteview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgdeleteview_CellContentClick);
            // 
            // btnViewLeavedetails
            // 
            this.btnViewLeavedetails.Location = new System.Drawing.Point(720, 340);
            this.btnViewLeavedetails.Name = "btnViewLeavedetails";
            this.btnViewLeavedetails.Size = new System.Drawing.Size(203, 33);
            this.btnViewLeavedetails.TabIndex = 26;
            this.btnViewLeavedetails.Text = "View Leave info";
            this.btnViewLeavedetails.UseVisualStyleBackColor = true;
            this.btnViewLeavedetails.Click += new System.EventHandler(this.BtnViewLeavedetails_Click);
            // 
            // btnDeleteLeaveRecord
            // 
            this.btnDeleteLeaveRecord.Location = new System.Drawing.Point(714, 267);
            this.btnDeleteLeaveRecord.Name = "btnDeleteLeaveRecord";
            this.btnDeleteLeaveRecord.Size = new System.Drawing.Size(203, 33);
            this.btnDeleteLeaveRecord.TabIndex = 25;
            this.btnDeleteLeaveRecord.Text = "Delete Leave Record";
            this.btnDeleteLeaveRecord.UseVisualStyleBackColor = true;
            this.btnDeleteLeaveRecord.Click += new System.EventHandler(this.BtnDeleteLeaveRecord_Click);
            // 
            // btn_UpdateStatus
            // 
            this.btn_UpdateStatus.Location = new System.Drawing.Point(714, 199);
            this.btn_UpdateStatus.Name = "btn_UpdateStatus";
            this.btn_UpdateStatus.Size = new System.Drawing.Size(203, 33);
            this.btn_UpdateStatus.TabIndex = 24;
            this.btn_UpdateStatus.Text = "Update Leave Status";
            this.btn_UpdateStatus.UseVisualStyleBackColor = true;
            this.btn_UpdateStatus.Click += new System.EventHandler(this.Btn_UpdateStatus_Click);
            // 
            // btnUpdateLeaveRecord
            // 
            this.btnUpdateLeaveRecord.Location = new System.Drawing.Point(714, 140);
            this.btnUpdateLeaveRecord.Name = "btnUpdateLeaveRecord";
            this.btnUpdateLeaveRecord.Size = new System.Drawing.Size(203, 33);
            this.btnUpdateLeaveRecord.TabIndex = 23;
            this.btnUpdateLeaveRecord.Text = "Update Leave Record";
            this.btnUpdateLeaveRecord.UseVisualStyleBackColor = true;
            this.btnUpdateLeaveRecord.Click += new System.EventHandler(this.BtnUpdateLeaveRecord_Click);
            // 
            // dtpDays
            // 
            this.dtpDays.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDays.Location = new System.Drawing.Point(504, 421);
            this.dtpDays.Multiline = true;
            this.dtpDays.Name = "dtpDays";
            this.dtpDays.Size = new System.Drawing.Size(167, 28);
            this.dtpDays.TabIndex = 22;
            // 
            // dtp2To
            // 
            this.dtp2To.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2To.Location = new System.Drawing.Point(504, 376);
            this.dtp2To.Name = "dtp2To";
            this.dtp2To.Size = new System.Drawing.Size(200, 32);
            this.dtp2To.TabIndex = 21;
            this.dtp2To.ValueChanged += new System.EventHandler(this.Dtp2To_ValueChanged);
            // 
            // cmbLStatus
            // 
            this.cmbLStatus.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLStatus.FormattingEnabled = true;
            this.cmbLStatus.Items.AddRange(new object[] {
            "Approved",
            "Pending",
            "Rejected"});
            this.cmbLStatus.Location = new System.Drawing.Point(504, 472);
            this.cmbLStatus.Name = "cmbLStatus";
            this.cmbLStatus.Size = new System.Drawing.Size(121, 31);
            this.cmbLStatus.TabIndex = 20;
            // 
            // dtp1from
            // 
            this.dtp1from.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1from.Location = new System.Drawing.Point(504, 328);
            this.dtp1from.Name = "dtp1from";
            this.dtp1from.Size = new System.Drawing.Size(200, 32);
            this.dtp1from.TabIndex = 19;
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.FormattingEnabled = true;
            this.txtReason.Items.AddRange(new object[] {
            "Personal work",
            "Relative expired",
            "Sick ",
            "Time Off to vote"});
            this.txtReason.Location = new System.Drawing.Point(504, 277);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(121, 31);
            this.txtReason.TabIndex = 18;
            // 
            // txtdesign
            // 
            this.txtdesign.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesign.Location = new System.Drawing.Point(504, 227);
            this.txtdesign.Multiline = true;
            this.txtdesign.Name = "txtdesign";
            this.txtdesign.Size = new System.Drawing.Size(167, 28);
            this.txtdesign.TabIndex = 17;
            // 
            // txtDepartmentname
            // 
            this.txtDepartmentname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentname.Location = new System.Drawing.Point(504, 172);
            this.txtDepartmentname.Multiline = true;
            this.txtDepartmentname.Name = "txtDepartmentname";
            this.txtDepartmentname.Size = new System.Drawing.Size(167, 28);
            this.txtDepartmentname.TabIndex = 16;
            // 
            // cmbEmployeeid
            // 
            this.cmbEmployeeid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeid.FormattingEnabled = true;
            this.cmbEmployeeid.Location = new System.Drawing.Point(504, 65);
            this.cmbEmployeeid.Name = "cmbEmployeeid";
            this.cmbEmployeeid.Size = new System.Drawing.Size(121, 27);
            this.cmbEmployeeid.TabIndex = 15;
            this.cmbEmployeeid.SelectedIndexChanged += new System.EventHandler(this.CmbEmployeeid_SelectedIndexChanged);
            // 
            // txtEmployeename
            // 
            this.txtEmployeename.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeename.Location = new System.Drawing.Point(504, 120);
            this.txtEmployeename.Multiline = true;
            this.txtEmployeename.Name = "txtEmployeename";
            this.txtEmployeename.Size = new System.Drawing.Size(167, 28);
            this.txtEmployeename.TabIndex = 14;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(312, 472);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 23);
            this.label18.TabIndex = 13;
            this.label18.Text = "Leave status";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(312, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 23);
            this.label15.TabIndex = 12;
            this.label15.Text = "No of days";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(312, 376);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 11;
            this.label14.Text = "To";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(312, 328);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 10;
            this.label13.Text = "From";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(312, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 9;
            this.label12.Text = "Reason";
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(312, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(163, 23);
            this.label19.TabIndex = 8;
            this.label19.Text = "Department name";
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(312, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 23);
            this.label17.TabIndex = 6;
            this.label17.Text = "Employeename";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(312, 232);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(139, 23);
            this.label16.TabIndex = 5;
            this.label16.Text = "Designation";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(312, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Empid";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(23, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 247);
            this.panel2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(370, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(402, 43);
            this.label11.TabIndex = 1;
            this.label11.Text = "Employee Leave Information";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(776, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 37);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // EmployeeLeave
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1062, 749);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Name = "EmployeeLeave";
            this.Load += new System.EventHandler(this.EmployeeLeave_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdeleteview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLeave;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cmbAbsent;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDeptname;
        private System.Windows.Forms.TextBox txtEmpname;
        private System.Windows.Forms.ComboBox cmbEmpid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateLeaveStatus;
        private System.Windows.Forms.Button btnUpdateLeave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox dtpDays;
        private System.Windows.Forms.DateTimePicker dtp2To;
        private System.Windows.Forms.ComboBox cmbLStatus;
        private System.Windows.Forms.DateTimePicker dtp1from;
        private System.Windows.Forms.ComboBox txtReason;
        private System.Windows.Forms.TextBox txtdesign;
        private System.Windows.Forms.TextBox txtDepartmentname;
        private System.Windows.Forms.ComboBox cmbEmployeeid;
        private System.Windows.Forms.TextBox txtEmployeename;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnViewLeavedetails;
        private System.Windows.Forms.Button btnDeleteLeaveRecord;
        private System.Windows.Forms.Button btn_UpdateStatus;
        private System.Windows.Forms.Button btnUpdateLeaveRecord;
        private System.Windows.Forms.DataGridView dgdeleteview;
        private System.Windows.Forms.Button btnBack;
    }
}