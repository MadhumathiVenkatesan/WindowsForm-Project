namespace Ems
{
    partial class Department
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
            this.lbl_deptdescription = new System.Windows.Forms.Label();
            this.lbl_deptname = new System.Windows.Forms.Label();
            this.lbl_deptid = new System.Windows.Forms.Label();
            this.txt_deptdescription = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Listdept = new System.Windows.Forms.Button();
            this.btn_Adddepartments = new System.Windows.Forms.Button();
            this.btn_Updatedepartments = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_deptid = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.txt_deptname = new System.Windows.Forms.TextBox();
            this.dgrid_Deptinfo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Deptinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_deptdescription
            // 
            this.lbl_deptdescription.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deptdescription.Location = new System.Drawing.Point(11, 119);
            this.lbl_deptdescription.Name = "lbl_deptdescription";
            this.lbl_deptdescription.Size = new System.Drawing.Size(142, 33);
            this.lbl_deptdescription.TabIndex = 7;
            this.lbl_deptdescription.Text = "Description";
            // 
            // lbl_deptname
            // 
            this.lbl_deptname.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deptname.Location = new System.Drawing.Point(11, 65);
            this.lbl_deptname.Name = "lbl_deptname";
            this.lbl_deptname.Size = new System.Drawing.Size(156, 33);
            this.lbl_deptname.TabIndex = 6;
            this.lbl_deptname.Text = "Department name";
            // 
            // lbl_deptid
            // 
            this.lbl_deptid.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deptid.Location = new System.Drawing.Point(13, 33);
            this.lbl_deptid.Name = "lbl_deptid";
            this.lbl_deptid.Size = new System.Drawing.Size(142, 33);
            this.lbl_deptid.TabIndex = 5;
            this.lbl_deptid.Text = "Department id";
            // 
            // txt_deptdescription
            // 
            this.txt_deptdescription.BackColor = System.Drawing.SystemColors.Window;
            this.txt_deptdescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deptdescription.Location = new System.Drawing.Point(159, 116);
            this.txt_deptdescription.Multiline = true;
            this.txt_deptdescription.Name = "txt_deptdescription";
            this.txt_deptdescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_deptdescription.Size = new System.Drawing.Size(215, 81);
            this.txt_deptdescription.TabIndex = 10;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(17, 106);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 36);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_Listdept
            // 
            this.btn_Listdept.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listdept.Location = new System.Drawing.Point(149, 105);
            this.btn_Listdept.Name = "btn_Listdept";
            this.btn_Listdept.Size = new System.Drawing.Size(172, 36);
            this.btn_Listdept.TabIndex = 12;
            this.btn_Listdept.Text = "List Departments";
            this.btn_Listdept.UseVisualStyleBackColor = true;
            this.btn_Listdept.Click += new System.EventHandler(this.Btn_Listdept_Click);
            // 
            // btn_Adddepartments
            // 
            this.btn_Adddepartments.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adddepartments.Location = new System.Drawing.Point(29, 203);
            this.btn_Adddepartments.Name = "btn_Adddepartments";
            this.btn_Adddepartments.Size = new System.Drawing.Size(147, 62);
            this.btn_Adddepartments.TabIndex = 13;
            this.btn_Adddepartments.Text = "Add new department";
            this.btn_Adddepartments.UseVisualStyleBackColor = true;
            this.btn_Adddepartments.Click += new System.EventHandler(this.Btn_Adddepartments_Click);
            // 
            // btn_Updatedepartments
            // 
            this.btn_Updatedepartments.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Updatedepartments.Location = new System.Drawing.Point(208, 216);
            this.btn_Updatedepartments.Name = "btn_Updatedepartments";
            this.btn_Updatedepartments.Size = new System.Drawing.Size(125, 33);
            this.btn_Updatedepartments.TabIndex = 14;
            this.btn_Updatedepartments.Text = "update";
            this.btn_Updatedepartments.UseVisualStyleBackColor = true;
            this.btn_Updatedepartments.Click += new System.EventHandler(this.Btn_Updatedepartments_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(29, 271);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(125, 36);
            this.btn_Delete.TabIndex = 15;
            this.btn_Delete.Text = "delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_deptid);
            this.panel1.Controls.Add(this.cmb_deptid);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.btn_Listdept);
            this.panel1.Location = new System.Drawing.Point(24, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 154);
            this.panel1.TabIndex = 18;
            // 
            // cmb_deptid
            // 
            this.cmb_deptid.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_deptid.FormattingEnabled = true;
            this.cmb_deptid.Location = new System.Drawing.Point(181, 33);
            this.cmb_deptid.Name = "cmb_deptid";
            this.cmb_deptid.Size = new System.Drawing.Size(121, 27);
            this.cmb_deptid.TabIndex = 14;
            this.cmb_deptid.SelectedIndexChanged += new System.EventHandler(this.Cmb_deptid_SelectedIndexChanged_1);
            this.cmb_deptid.SelectionChangeCommitted += new System.EventHandler(this.Cmb_deptid_SelectionChangeCommitted_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Controls.Add(this.btn_view);
            this.groupBox2.Controls.Add(this.txt_deptname);
            this.groupBox2.Controls.Add(this.lbl_deptname);
            this.groupBox2.Controls.Add(this.lbl_deptdescription);
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.txt_deptdescription);
            this.groupBox2.Controls.Add(this.btn_Updatedepartments);
            this.groupBox2.Controls.Add(this.btn_Adddepartments);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(24, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 313);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create new Department";
            // 
            // btn_view
            // 
            this.btn_view.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(209, 271);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(125, 33);
            this.btn_view.TabIndex = 18;
            this.btn_view.Text = "view";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.Btn_view_Click);
            // 
            // txt_deptname
            // 
            this.txt_deptname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_deptname.Location = new System.Drawing.Point(193, 65);
            this.txt_deptname.Name = "txt_deptname";
            this.txt_deptname.Size = new System.Drawing.Size(141, 26);
            this.txt_deptname.TabIndex = 17;
            // 
            // dgrid_Deptinfo
            // 
            this.dgrid_Deptinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgrid_Deptinfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgrid_Deptinfo.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgrid_Deptinfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgrid_Deptinfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgrid_Deptinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_Deptinfo.Location = new System.Drawing.Point(501, 155);
            this.dgrid_Deptinfo.Name = "dgrid_Deptinfo";
            this.dgrid_Deptinfo.Size = new System.Drawing.Size(414, 226);
            this.dgrid_Deptinfo.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 48);
            this.label1.TabIndex = 20;
            this.label1.Text = "Department Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(650, 416);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 37);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1069, 689);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgrid_Deptinfo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Name = "Department";
            this.Text = "Department";
            this.Load += new System.EventHandler(this.Department_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Deptinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_deptdescription;
        private System.Windows.Forms.Label lbl_deptname;
        private System.Windows.Forms.Label lbl_deptid;
        private System.Windows.Forms.TextBox txt_deptdescription;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Listdept;
        private System.Windows.Forms.Button btn_Adddepartments;
        private System.Windows.Forms.Button btn_Updatedepartments;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgrid_Deptinfo;
        private System.Windows.Forms.TextBox txt_deptname;
        private System.Windows.Forms.ComboBox cmb_deptid;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
    }
}