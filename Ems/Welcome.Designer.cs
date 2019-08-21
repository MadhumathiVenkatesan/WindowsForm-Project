namespace Ems
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Project = new System.Windows.Forms.Button();
            this.btn_Employeedetails = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btn_Departments = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.llbAbout = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.llbOpenings = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Project);
            this.panel1.Controls.Add(this.btn_Employeedetails);
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.btn_Departments);
            this.panel1.Location = new System.Drawing.Point(116, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 64);
            this.panel1.TabIndex = 0;
            // 
            // btn_Project
            // 
            this.btn_Project.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Project.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Project.Location = new System.Drawing.Point(695, 14);
            this.btn_Project.Name = "btn_Project";
            this.btn_Project.Size = new System.Drawing.Size(151, 39);
            this.btn_Project.TabIndex = 5;
            this.btn_Project.Text = "Projects";
            this.btn_Project.UseVisualStyleBackColor = false;
            this.btn_Project.Click += new System.EventHandler(this.Btn_Project_Click);
            // 
            // btn_Employeedetails
            // 
            this.btn_Employeedetails.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Employeedetails.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employeedetails.Location = new System.Drawing.Point(227, 14);
            this.btn_Employeedetails.Name = "btn_Employeedetails";
            this.btn_Employeedetails.Size = new System.Drawing.Size(198, 39);
            this.btn_Employeedetails.TabIndex = 3;
            this.btn_Employeedetails.Text = "Employee details";
            this.btn_Employeedetails.UseVisualStyleBackColor = false;
            this.btn_Employeedetails.Click += new System.EventHandler(this.Btn_Employeedetails_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.BackColor = System.Drawing.Color.CadetBlue;
            this.btnLeave.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.Location = new System.Drawing.Point(481, 14);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(150, 39);
            this.btnLeave.TabIndex = 1;
            this.btnLeave.Text = "Leave Status";
            this.btnLeave.UseVisualStyleBackColor = false;
            this.btnLeave.Click += new System.EventHandler(this.BtnLeave_Click);
            // 
            // btn_Departments
            // 
            this.btn_Departments.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Departments.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Departments.Location = new System.Drawing.Point(14, 14);
            this.btn_Departments.Name = "btn_Departments";
            this.btn_Departments.Size = new System.Drawing.Size(140, 39);
            this.btn_Departments.TabIndex = 2;
            this.btn_Departments.Text = "Departments";
            this.btn_Departments.UseVisualStyleBackColor = false;
            this.btn_Departments.Click += new System.EventHandler(this.Btn_Departments_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(23, 151);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 386);
            this.panel2.TabIndex = 1;
            // 
            // llbAbout
            // 
            this.llbAbout.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbAbout.ForeColor = System.Drawing.SystemColors.Control;
            this.llbAbout.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.llbAbout.Location = new System.Drawing.Point(47, 44);
            this.llbAbout.Name = "llbAbout";
            this.llbAbout.Size = new System.Drawing.Size(191, 32);
            this.llbAbout.TabIndex = 2;
            this.llbAbout.TabStop = true;
            this.llbAbout.Text = "About";
            this.llbAbout.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.llbAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbAbout_LinkClicked);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.llbOpenings);
            this.panel3.Controls.Add(this.llbAbout);
            this.panel3.Location = new System.Drawing.Point(786, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 166);
            this.panel3.TabIndex = 3;
            // 
            // llbOpenings
            // 
            this.llbOpenings.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbOpenings.ForeColor = System.Drawing.SystemColors.Control;
            this.llbOpenings.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.llbOpenings.Location = new System.Drawing.Point(47, 105);
            this.llbOpenings.Name = "llbOpenings";
            this.llbOpenings.Size = new System.Drawing.Size(182, 32);
            this.llbOpenings.TabIndex = 3;
            this.llbOpenings.TabStop = true;
            this.llbOpenings.Text = "Job Openings";
            this.llbOpenings.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.llbOpenings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbOpenings_LinkClicked);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1108, 621);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel llbAbout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel llbOpenings;
        private System.Windows.Forms.Button btn_Employeedetails;
        private System.Windows.Forms.Button btn_Departments;
        private System.Windows.Forms.Button btn_Project;
    }
}