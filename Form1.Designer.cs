namespace Navises_Array
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblfavoritecolor = new System.Windows.Forms.Label();
            this.lblsaying = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.cbfavoritecolor = new System.Windows.Forms.ComboBox();
            this.txtsaying = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.lblage = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.lblbirthday = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.cbsoccer = new System.Windows.Forms.CheckBox();
            this.cbvolleyball = new System.Windows.Forms.CheckBox();
            this.cbbasketball = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(64, 50);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(75, 28);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(50, 96);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(89, 28);
            this.lblgender.TabIndex = 2;
            this.lblgender.Text = "Gender";
            // 
            // lblfavoritecolor
            // 
            this.lblfavoritecolor.AutoSize = true;
            this.lblfavoritecolor.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfavoritecolor.Location = new System.Drawing.Point(15, 388);
            this.lblfavoritecolor.Name = "lblfavoritecolor";
            this.lblfavoritecolor.Size = new System.Drawing.Size(161, 28);
            this.lblfavoritecolor.TabIndex = 3;
            this.lblfavoritecolor.Text = "Favorite Color";
            // 
            // lblsaying
            // 
            this.lblsaying.AutoSize = true;
            this.lblsaying.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsaying.Location = new System.Drawing.Point(40, 441);
            this.lblsaying.Name = "lblsaying";
            this.lblsaying.Size = new System.Drawing.Size(83, 28);
            this.lblsaying.TabIndex = 4;
            this.lblsaying.Text = "Saying";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(145, 50);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 31);
            this.txtName.TabIndex = 5;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbmale.Location = new System.Drawing.Point(145, 96);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(78, 30);
            this.rbmale.TabIndex = 6;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbfemale.Location = new System.Drawing.Point(229, 96);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(99, 30);
            this.rbfemale.TabIndex = 7;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // cbfavoritecolor
            // 
            this.cbfavoritecolor.FormattingEnabled = true;
            this.cbfavoritecolor.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Pink"});
            this.cbfavoritecolor.Location = new System.Drawing.Point(183, 394);
            this.cbfavoritecolor.Name = "cbfavoritecolor";
            this.cbfavoritecolor.Size = new System.Drawing.Size(121, 21);
            this.cbfavoritecolor.TabIndex = 11;
            // 
            // txtsaying
            // 
            this.txtsaying.Location = new System.Drawing.Point(130, 443);
            this.txtsaying.Multiline = true;
            this.txtsaying.Name = "txtsaying";
            this.txtsaying.Size = new System.Drawing.Size(185, 64);
            this.txtsaying.TabIndex = 15;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnadd.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(46, 554);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(78, 39);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndisplay
            // 
            this.btndisplay.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btndisplay.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndisplay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndisplay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndisplay.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndisplay.Location = new System.Drawing.Point(330, 554);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(117, 39);
            this.btndisplay.TabIndex = 17;
            this.btndisplay.Text = "DISPLAY";
            this.btndisplay.UseVisualStyleBackColor = false;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnupdate.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(183, 554);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(112, 39);
            this.btnupdate.TabIndex = 18;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(12, 9);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(75, 28);
            this.lblid.TabIndex = 19;
            this.lblid.Text = "Name";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(122, 332);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(60, 31);
            this.txtage.TabIndex = 63;
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblage.Location = new System.Drawing.Point(41, 332);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(54, 28);
            this.lblage.TabIndex = 62;
            this.lblage.Text = "Age";
            // 
            // dtpicker
            // 
            this.dtpicker.Location = new System.Drawing.Point(130, 295);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(221, 20);
            this.dtpicker.TabIndex = 61;
            this.dtpicker.ValueChanged += new System.EventHandler(this.dtpicker_ValueChanged);
            // 
            // lblbirthday
            // 
            this.lblbirthday.AutoSize = true;
            this.lblbirthday.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbirthday.Location = new System.Drawing.Point(21, 288);
            this.lblbirthday.Name = "lblbirthday";
            this.lblbirthday.Size = new System.Drawing.Size(102, 28);
            this.lblbirthday.TabIndex = 60;
            this.lblbirthday.Text = "Birthday";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(122, 238);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(287, 31);
            this.txtemail.TabIndex = 59;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(41, 238);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(69, 28);
            this.lblemail.TabIndex = 58;
            this.lblemail.Text = "Email";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(122, 191);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(287, 31);
            this.txtaddress.TabIndex = 57;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(21, 191);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(97, 28);
            this.lbladdress.TabIndex = 56;
            this.lbladdress.Text = "Address";
            // 
            // cbsoccer
            // 
            this.cbsoccer.AutoSize = true;
            this.cbsoccer.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsoccer.Location = new System.Drawing.Point(371, 147);
            this.cbsoccer.Name = "cbsoccer";
            this.cbsoccer.Size = new System.Drawing.Size(93, 30);
            this.cbsoccer.TabIndex = 55;
            this.cbsoccer.Text = "Soccer";
            this.cbsoccer.UseVisualStyleBackColor = true;
            // 
            // cbvolleyball
            // 
            this.cbvolleyball.AutoSize = true;
            this.cbvolleyball.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbvolleyball.Location = new System.Drawing.Point(249, 147);
            this.cbvolleyball.Name = "cbvolleyball";
            this.cbvolleyball.Size = new System.Drawing.Size(127, 30);
            this.cbvolleyball.TabIndex = 54;
            this.cbvolleyball.Text = "Volleyball";
            this.cbvolleyball.UseVisualStyleBackColor = true;
            // 
            // cbbasketball
            // 
            this.cbbasketball.AutoSize = true;
            this.cbbasketball.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbasketball.Location = new System.Drawing.Point(122, 147);
            this.cbbasketball.Name = "cbbasketball";
            this.cbbasketball.Size = new System.Drawing.Size(130, 30);
            this.cbbasketball.TabIndex = 53;
            this.cbbasketball.Text = "Basketball";
            this.cbbasketball.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Hobbies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(515, 660);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.dtpicker);
            this.Controls.Add(this.lblbirthday);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.cbsoccer);
            this.Controls.Add(this.cbvolleyball);
            this.Controls.Add(this.cbbasketball);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndisplay);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtsaying);
            this.Controls.Add(this.cbfavoritecolor);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblsaying);
            this.Controls.Add(this.lblfavoritecolor);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblfavoritecolor;
        private System.Windows.Forms.Label lblsaying;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnupdate;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.RadioButton rbmale;
        public System.Windows.Forms.RadioButton rbfemale;
        public System.Windows.Forms.ComboBox cbfavoritecolor;
        public System.Windows.Forms.TextBox txtsaying;
        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label lblbirthday;
        public System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblemail;
        public System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label lbladdress;
        public System.Windows.Forms.CheckBox cbsoccer;
        public System.Windows.Forms.CheckBox cbvolleyball;
        public System.Windows.Forms.CheckBox cbbasketball;
        private System.Windows.Forms.Label label1;
    }
}

