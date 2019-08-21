namespace Ems
{
    partial class Employeeinfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employeeinfo));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(601, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Information System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Continue.Location = new System.Drawing.Point(412, 557);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(222, 35);
            this.btn_Continue.TabIndex = 1;
            this.btn_Continue.Text = "Click to Continue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.Btn_Continue_Click);
            // 
            // Employeeinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1032, 617);
            this.Controls.Add(this.btn_Continue);
            this.Controls.Add(this.label1);
            this.Name = "Employeeinfo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Employeeinfo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Continue;
    }
}