namespace Ems
{
    partial class Projectdetials
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cmb_Projectid = new System.Windows.Forms.ComboBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.txt_Client = new System.Windows.Forms.TextBox();
            this.txt_Technology = new System.Windows.Forms.TextBox();
            this.txt_Reportingto = new System.Windows.Forms.TextBox();
            this.txt_Projecthead = new System.Windows.Forms.TextBox();
            this.txt_Projectname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dg_Projectdetails = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Projectdetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_View);
            this.groupBox1.Controls.Add(this.btn_Delete);
            this.groupBox1.Controls.Add(this.btn_Update);
            this.groupBox1.Controls.Add(this.cmb_Projectid);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Controls.Add(this.txt_Client);
            this.groupBox1.Controls.Add(this.txt_Technology);
            this.groupBox1.Controls.Add(this.txt_Reportingto);
            this.groupBox1.Controls.Add(this.txt_Projecthead);
            this.groupBox1.Controls.Add(this.txt_Projectname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 461);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter your Project details";
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(450, 392);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(104, 34);
            this.btn_View.TabIndex = 15;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.Btn_View_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(316, 392);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(104, 34);
            this.btn_Delete.TabIndex = 14;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(174, 392);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(104, 34);
            this.btn_Update.TabIndex = 13;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // cmb_Projectid
            // 
            this.cmb_Projectid.FormattingEnabled = true;
            this.cmb_Projectid.Location = new System.Drawing.Point(230, 48);
            this.cmb_Projectid.Name = "cmb_Projectid";
            this.cmb_Projectid.Size = new System.Drawing.Size(146, 31);
            this.cmb_Projectid.TabIndex = 12;
            this.cmb_Projectid.SelectedIndexChanged += new System.EventHandler(this.Cmb_Projectid_SelectedIndexChanged);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(21, 392);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(104, 34);
            this.btn_Insert.TabIndex = 2;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            // 
            // txt_Client
            // 
            this.txt_Client.Location = new System.Drawing.Point(230, 345);
            this.txt_Client.Multiline = true;
            this.txt_Client.Name = "txt_Client";
            this.txt_Client.Size = new System.Drawing.Size(180, 31);
            this.txt_Client.TabIndex = 11;
            // 
            // txt_Technology
            // 
            this.txt_Technology.Location = new System.Drawing.Point(230, 291);
            this.txt_Technology.Multiline = true;
            this.txt_Technology.Name = "txt_Technology";
            this.txt_Technology.Size = new System.Drawing.Size(180, 31);
            this.txt_Technology.TabIndex = 10;
            // 
            // txt_Reportingto
            // 
            this.txt_Reportingto.Location = new System.Drawing.Point(230, 231);
            this.txt_Reportingto.Multiline = true;
            this.txt_Reportingto.Name = "txt_Reportingto";
            this.txt_Reportingto.Size = new System.Drawing.Size(180, 31);
            this.txt_Reportingto.TabIndex = 9;
            // 
            // txt_Projecthead
            // 
            this.txt_Projecthead.Location = new System.Drawing.Point(230, 172);
            this.txt_Projecthead.Multiline = true;
            this.txt_Projecthead.Name = "txt_Projecthead";
            this.txt_Projecthead.Size = new System.Drawing.Size(247, 31);
            this.txt_Projecthead.TabIndex = 8;
            // 
            // txt_Projectname
            // 
            this.txt_Projectname.Location = new System.Drawing.Point(230, 108);
            this.txt_Projectname.Multiline = true;
            this.txt_Projectname.Name = "txt_Projectname";
            this.txt_Projectname.Size = new System.Drawing.Size(275, 34);
            this.txt_Projectname.TabIndex = 7;
            this.txt_Projectname.WordWrap = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.AliceBlue;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 33);
            this.label7.TabIndex = 5;
            this.label7.Text = "Client";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.AliceBlue;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 33);
            this.label6.TabIndex = 4;
            this.label6.Text = "Technology";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.AliceBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Reporting To";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.AliceBlue;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Project Head";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.AliceBlue;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Project Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.AliceBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Project Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dg_Projectdetails
            // 
            this.dg_Projectdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Projectdetails.Location = new System.Drawing.Point(637, 224);
            this.dg_Projectdetails.Name = "dg_Projectdetails";
            this.dg_Projectdetails.Size = new System.Drawing.Size(388, 153);
            this.dg_Projectdetails.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(804, 426);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 37);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Projectdetials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1123, 573);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dg_Projectdetails);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Projectdetials";
            this.Text = "Projectdetials";
            this.Load += new System.EventHandler(this.Projectdetials_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Projectdetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Client;
        private System.Windows.Forms.TextBox txt_Technology;
        private System.Windows.Forms.TextBox txt_Reportingto;
        private System.Windows.Forms.TextBox txt_Projecthead;
        private System.Windows.Forms.TextBox txt_Projectname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cmb_Projectid;
        private System.Windows.Forms.DataGridView dg_Projectdetails;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btnBack;
    }
}