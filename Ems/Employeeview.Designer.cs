namespace Ems
{
    partial class Employeeview
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
            this.dgEmployeeinfo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Totalemployee = new System.Windows.Forms.Label();
            this.txt_totalemployee = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEmployeeinfo
            // 
            this.dgEmployeeinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployeeinfo.Location = new System.Drawing.Point(52, 149);
            this.dgEmployeeinfo.Name = "dgEmployeeinfo";
            this.dgEmployeeinfo.Size = new System.Drawing.Size(883, 320);
            this.dgEmployeeinfo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 41);
            this.label2.TabIndex = 27;
            this.label2.Text = "Employee Information System";
            // 
            // lbl_Totalemployee
            // 
            this.lbl_Totalemployee.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Totalemployee.Location = new System.Drawing.Point(234, 515);
            this.lbl_Totalemployee.Name = "lbl_Totalemployee";
            this.lbl_Totalemployee.Size = new System.Drawing.Size(258, 32);
            this.lbl_Totalemployee.TabIndex = 28;
            this.lbl_Totalemployee.Text = "Total number of employees";
            this.lbl_Totalemployee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_totalemployee
            // 
            this.txt_totalemployee.Location = new System.Drawing.Point(522, 515);
            this.txt_totalemployee.Multiline = true;
            this.txt_totalemployee.Name = "txt_totalemployee";
            this.txt_totalemployee.Size = new System.Drawing.Size(132, 29);
            this.txt_totalemployee.TabIndex = 29;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(430, 566);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 37);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.UseWaitCursor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Employeeview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(982, 615);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txt_totalemployee);
            this.Controls.Add(this.lbl_Totalemployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgEmployeeinfo);
            this.Name = "Employeeview";
            this.Text = "Employeeview";
            this.Load += new System.EventHandler(this.Employeeview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployeeinfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployeeinfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Totalemployee;
        private System.Windows.Forms.TextBox txt_totalemployee;
        private System.Windows.Forms.Button btnBack;
    }
}