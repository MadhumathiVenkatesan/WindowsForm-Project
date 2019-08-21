namespace Ems
{
    partial class Employee_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_details));
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btnEmpdelete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Updateemployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Insert.Image = ((System.Drawing.Image)(resources.GetObject("btn_Insert.Image")));
            this.btn_Insert.Location = new System.Drawing.Point(489, 100);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(130, 130);
            this.btn_Insert.TabIndex = 4;
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // btnEmpdelete
            // 
            this.btnEmpdelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEmpdelete.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpdelete.Image")));
            this.btnEmpdelete.Location = new System.Drawing.Point(489, 423);
            this.btnEmpdelete.Name = "btnEmpdelete";
            this.btnEmpdelete.Size = new System.Drawing.Size(130, 130);
            this.btnEmpdelete.TabIndex = 5;
            this.btnEmpdelete.UseVisualStyleBackColor = false;
            this.btnEmpdelete.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("btn_Search.Image")));
            this.btn_Search.Location = new System.Drawing.Point(732, 233);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(130, 130);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_Updateemployee
            // 
            this.btn_Updateemployee.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_Updateemployee.Image = ((System.Drawing.Image)(resources.GetObject("btn_Updateemployee.Image")));
            this.btn_Updateemployee.Location = new System.Drawing.Point(253, 233);
            this.btn_Updateemployee.Name = "btn_Updateemployee";
            this.btn_Updateemployee.Size = new System.Drawing.Size(130, 130);
            this.btn_Updateemployee.TabIndex = 7;
            this.btn_Updateemployee.UseVisualStyleBackColor = false;
            this.btn_Updateemployee.Click += new System.EventHandler(this.Btn_Updateemployee_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Add employee";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 44);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update\r\n employee details\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(723, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Search employee details\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(480, 556);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 44);
            this.label4.TabIndex = 12;
            this.label4.Text = "Delete\r\n employee details\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(276, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(601, 57);
            this.label5.TabIndex = 13;
            this.label5.Text = "Employee Information System";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(506, 636);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 37);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Employee_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1241, 696);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Updateemployee);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btnEmpdelete);
            this.Controls.Add(this.btn_Insert);
            this.Name = "Employee_details";
            this.Text = "Employee_details";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btnEmpdelete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Updateemployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
    }
}