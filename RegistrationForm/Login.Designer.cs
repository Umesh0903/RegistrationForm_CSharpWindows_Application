namespace RegistrationForm
{
    partial class Login
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
            this.uname = new System.Windows.Forms.Label();
            this.pswd = new System.Windows.Forms.Label();
            this.usertextbox = new System.Windows.Forms.TextBox();
            this.pswdtextbox = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uname
            // 
            this.uname.AutoSize = true;
            this.uname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname.Location = new System.Drawing.Point(146, 75);
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(89, 16);
            this.uname.TabIndex = 0;
            this.uname.Text = "User Name:";
            this.uname.Click += new System.EventHandler(this.uname_Click);
            // 
            // pswd
            // 
            this.pswd.AutoSize = true;
            this.pswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pswd.Location = new System.Drawing.Point(146, 135);
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(79, 16);
            this.pswd.TabIndex = 1;
            this.pswd.Text = "Password:";
            this.pswd.Click += new System.EventHandler(this.pswd_Click);
            // 
            // usertextbox
            // 
            this.usertextbox.Location = new System.Drawing.Point(262, 74);
            this.usertextbox.Multiline = true;
            this.usertextbox.Name = "usertextbox";
            this.usertextbox.Size = new System.Drawing.Size(185, 29);
            this.usertextbox.TabIndex = 2;
            this.usertextbox.TextChanged += new System.EventHandler(this.usertextbox_TextChanged);
            // 
            // pswdtextbox
            // 
            this.pswdtextbox.Location = new System.Drawing.Point(262, 134);
            this.pswdtextbox.Multiline = true;
            this.pswdtextbox.Name = "pswdtextbox";
            this.pswdtextbox.Size = new System.Drawing.Size(185, 29);
            this.pswdtextbox.TabIndex = 3;
            this.pswdtextbox.TextChanged += new System.EventHandler(this.pswdtextbox_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.Location = new System.Drawing.Point(308, 190);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 32);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.pswdtextbox);
            this.Controls.Add(this.usertextbox);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.uname);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uname;
        private System.Windows.Forms.Label pswd;
        private System.Windows.Forms.TextBox usertextbox;
        private System.Windows.Forms.TextBox pswdtextbox;
        private System.Windows.Forms.Button loginbtn;
    }
}