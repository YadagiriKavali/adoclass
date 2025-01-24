namespace ADO.net_demoApp
{
    partial class Form1
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnGetAllEmp = new System.Windows.Forms.Button();
            this.txtSalfilter = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFornKey = new System.Windows.Forms.Button();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnpicbroser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtGetIdBasePic = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(46, 32);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(209, 23);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(12, 105);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(100, 23);
            this.btninsert.TabIndex = 1;
            this.btninsert.Text = "Insert";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(12, 79);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 2;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(224, 79);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(110, 20);
            this.txtSalary.TabIndex = 3;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(118, 79);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 4;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(224, 105);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(110, 23);
            this.btndelete.TabIndex = 5;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(118, 105);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 23);
            this.btnupdate.TabIndex = 6;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnGetAllEmp
            // 
            this.btnGetAllEmp.Location = new System.Drawing.Point(12, 134);
            this.btnGetAllEmp.Name = "btnGetAllEmp";
            this.btnGetAllEmp.Size = new System.Drawing.Size(100, 23);
            this.btnGetAllEmp.TabIndex = 7;
            this.btnGetAllEmp.Text = "GetAll Employe";
            this.btnGetAllEmp.UseVisualStyleBackColor = true;
            this.btnGetAllEmp.Click += new System.EventHandler(this.btnGetAllEmp_Click);
            // 
            // txtSalfilter
            // 
            this.txtSalfilter.Location = new System.Drawing.Point(118, 134);
            this.txtSalfilter.Name = "txtSalfilter";
            this.txtSalfilter.Size = new System.Drawing.Size(100, 20);
            this.txtSalfilter.TabIndex = 8;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(224, 134);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 23);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "More then Salary";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(118, 236);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(100, 20);
            this.txtpassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(118, 199);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "UserLogin";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(135, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFornKey
            // 
            this.btnFornKey.Location = new System.Drawing.Point(15, 294);
            this.btnFornKey.Name = "btnFornKey";
            this.btnFornKey.Size = new System.Drawing.Size(100, 23);
            this.btnFornKey.TabIndex = 18;
            this.btnFornKey.Text = "FornKey";
            this.btnFornKey.UseVisualStyleBackColor = true;
            this.btnFornKey.Click += new System.EventHandler(this.btnFornKey_Click);
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(234, 306);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(100, 23);
            this.btnPic.TabIndex = 19;
            this.btnPic.Text = "Inser_pic";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnpicbroser
            // 
            this.btnpicbroser.Location = new System.Drawing.Point(234, 277);
            this.btnpicbroser.Name = "btnpicbroser";
            this.btnpicbroser.Size = new System.Drawing.Size(100, 23);
            this.btnpicbroser.TabIndex = 20;
            this.btnpicbroser.Text = "Broser";
            this.btnpicbroser.UseVisualStyleBackColor = true;
            this.btnpicbroser.Click += new System.EventHandler(this.btnpicbroser_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(224, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 103);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // txtGetIdBasePic
            // 
            this.txtGetIdBasePic.Location = new System.Drawing.Point(340, 279);
            this.txtGetIdBasePic.Name = "txtGetIdBasePic";
            this.txtGetIdBasePic.Size = new System.Drawing.Size(123, 20);
            this.txtGetIdBasePic.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "GetPhotoDb";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGetpicfromDb);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtGetIdBasePic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnpicbroser);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.btnFornKey);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txtSalfilter);
            this.Controls.Add(this.btnGetAllEmp);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.btnConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnGetAllEmp;
        private System.Windows.Forms.TextBox txtSalfilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFornKey;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnpicbroser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtGetIdBasePic;
        private System.Windows.Forms.Button button2;
    }
}

