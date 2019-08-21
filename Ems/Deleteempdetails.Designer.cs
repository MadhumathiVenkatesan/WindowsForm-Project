namespace Ems
{
    partial class Deleteempdetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgdelete = new System.Windows.Forms.DataGridView();
            this.lblEmpid = new System.Windows.Forms.Label();
            this.lbl_Empname = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtEmployeename = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdelete)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Employee Information System";
            // 
            // dgdelete
            // 
            this.dgdelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdelete.Location = new System.Drawing.Point(75, 485);
            this.dgdelete.Name = "dgdelete";
            this.dgdelete.Size = new System.Drawing.Size(810, 249);
            this.dgdelete.TabIndex = 10;
            this.dgdelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgdelete_CellClick);
            // 
            // lblEmpid
            // 
            this.lblEmpid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpid.Location = new System.Drawing.Point(111, 69);
            this.lblEmpid.Name = "lblEmpid";
            this.lblEmpid.Size = new System.Drawing.Size(115, 23);
            this.lblEmpid.TabIndex = 11;
            this.lblEmpid.Text = "Employee Id";
            this.lblEmpid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Empname
            // 
            this.lbl_Empname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Empname.Location = new System.Drawing.Point(111, 128);
            this.lbl_Empname.Name = "lbl_Empname";
            this.lbl_Empname.Size = new System.Drawing.Size(154, 23);
            this.lbl_Empname.TabIndex = 12;
            this.lbl_Empname.Text = "Employee Name";
            this.lbl_Empname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesignation
            // 
            this.lblDesignation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignation.Location = new System.Drawing.Point(111, 247);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(119, 23);
            this.lblDesignation.TabIndex = 13;
            this.lblDesignation.Text = "Department";
            this.lblDesignation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(111, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Designation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(323, 64);
            this.txtEmployeeId.Multiline = true;
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(139, 28);
            this.txtEmployeeId.TabIndex = 15;
            // 
            // txtEmployeename
            // 
            this.txtEmployeename.Location = new System.Drawing.Point(323, 128);
            this.txtEmployeename.Multiline = true;
            this.txtEmployeename.Name = "txtEmployeename";
            this.txtEmployeename.Size = new System.Drawing.Size(190, 28);
            this.txtEmployeename.TabIndex = 16;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(323, 185);
            this.txtDesignation.Multiline = true;
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(190, 28);
            this.txtDesignation.TabIndex = 17;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(323, 247);
            this.txtDepartment.Multiline = true;
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(190, 28);
            this.txtDepartment.TabIndex = 18;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(329, 427);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEmpid);
            this.groupBox1.Controls.Add(this.txtEmployeeId);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.lbl_Empname);
            this.groupBox1.Controls.Add(this.lblDesignation);
            this.groupBox1.Controls.Add(this.txtDesignation);
            this.groupBox1.Controls.Add(this.txtEmployeename);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(108, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(709, 287);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(496, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 37);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.UseWaitCursor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Deleteempdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(955, 746);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgdelete);
            this.Controls.Add(this.label1);
            this.Name = "Deleteempdetails";
            this.Text = "Deleteempdetails";
            this.Load += new System.EventHandler(this.Deleteempdetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdelete)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgdelete;
        private System.Windows.Forms.Label lblEmpid;
        private System.Windows.Forms.Label lbl_Empname;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtEmployeename;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
    }
}