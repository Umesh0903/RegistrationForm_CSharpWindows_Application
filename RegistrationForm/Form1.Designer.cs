namespace RegistrationForm
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
            this.fname = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.qualification = new System.Windows.Forms.Label();
            this.technologies = new System.Windows.Forms.Label();
            this.gender = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webfs = new System.Windows.Forms.CheckBox();
            this.javafs = new System.Windows.Forms.CheckBox();
            this.dotnetfs = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.details = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(111, 57);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(81, 15);
            this.fname.TabIndex = 0;
            this.fname.Text = "First Name:";
            // 
            // lname
            // 
            this.lname.AutoSize = true;
            this.lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lname.Location = new System.Drawing.Point(111, 103);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(80, 15);
            this.lname.TabIndex = 1;
            this.lname.Text = "Last Name:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(111, 158);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(48, 15);
            this.email.TabIndex = 2;
            this.email.Text = "Email:";
            // 
            // qualification
            // 
            this.qualification.AutoSize = true;
            this.qualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qualification.Location = new System.Drawing.Point(111, 204);
            this.qualification.Name = "qualification";
            this.qualification.Size = new System.Drawing.Size(92, 15);
            this.qualification.TabIndex = 3;
            this.qualification.Text = "Qualification:";
            // 
            // technologies
            // 
            this.technologies.AutoSize = true;
            this.technologies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technologies.Location = new System.Drawing.Point(111, 257);
            this.technologies.Name = "technologies";
            this.technologies.Size = new System.Drawing.Size(97, 15);
            this.technologies.TabIndex = 4;
            this.technologies.Text = "Technologies:";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(111, 369);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(58, 15);
            this.gender.TabIndex = 5;
            this.gender.Text = "Gender:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(222, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 32);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(222, 103);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 31);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 152);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(163, 32);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 204);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webfs);
            this.groupBox1.Controls.Add(this.javafs);
            this.groupBox1.Controls.Add(this.dotnetfs);
            this.groupBox1.Location = new System.Drawing.Point(222, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // webfs
            // 
            this.webfs.AutoSize = true;
            this.webfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webfs.Location = new System.Drawing.Point(17, 63);
            this.webfs.Name = "webfs";
            this.webfs.Size = new System.Drawing.Size(75, 19);
            this.webfs.TabIndex = 2;
            this.webfs.Text = "Web FS";
            this.webfs.UseVisualStyleBackColor = true;
            // 
            // javafs
            // 
            this.javafs.AutoSize = true;
            this.javafs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.javafs.Location = new System.Drawing.Point(17, 38);
            this.javafs.Name = "javafs";
            this.javafs.Size = new System.Drawing.Size(76, 19);
            this.javafs.TabIndex = 1;
            this.javafs.Text = "Java FS";
            this.javafs.UseVisualStyleBackColor = true;
            // 
            // dotnetfs
            // 
            this.dotnetfs.AutoSize = true;
            this.dotnetfs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotnetfs.Location = new System.Drawing.Point(17, 13);
            this.dotnetfs.Name = "dotnetfs";
            this.dotnetfs.Size = new System.Drawing.Size(73, 19);
            this.dotnetfs.TabIndex = 0;
            this.dotnetfs.Text = ".Net FS";
            this.dotnetfs.UseVisualStyleBackColor = true;
            this.dotnetfs.CheckedChanged += new System.EventHandler(this.dotnetfs_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.female);
            this.groupBox2.Controls.Add(this.male);
            this.groupBox2.Location = new System.Drawing.Point(222, 346);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 61);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(79, 19);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(73, 19);
            this.female.TabIndex = 1;
            this.female.TabStop = true;
            this.female.Text = "Female";
            this.female.UseVisualStyleBackColor = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(6, 19);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(57, 19);
            this.male.TabIndex = 0;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.Location = new System.Drawing.Point(472, 57);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(56, 15);
            this.details.TabIndex = 12;
            this.details.Text = "Details:";
            this.details.Click += new System.EventHandler(this.label1_Click);
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(475, 87);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(246, 158);
            this.info.TabIndex = 13;
            this.info.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.Location = new System.Drawing.Point(475, 278);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(88, 29);
            this.register.TabIndex = 14;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(633, 278);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(88, 29);
            this.cancel.TabIndex = 15;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.register);
            this.Controls.Add(this.info);
            this.Controls.Add(this.details);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.technologies);
            this.Controls.Add(this.qualification);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.Label lname;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label qualification;
        private System.Windows.Forms.Label technologies;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox dotnetfs;
        private System.Windows.Forms.CheckBox javafs;
        private System.Windows.Forms.CheckBox webfs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button cancel;
    }
}

