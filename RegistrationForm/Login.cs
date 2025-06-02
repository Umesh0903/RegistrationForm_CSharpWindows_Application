using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;

namespace RegistrationForm
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void uname_Click(object sender, EventArgs e)
        {

        }

        private void pswd_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usertextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            string uname = usertextbox.Text.Trim();
            string pswd = pswdtextbox.Text.Trim();

            string connectionString = "Data Source=DESKTOP-RJ7FDJE\\SQLEXPRESS;Initial Catalog=mydb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT COUNT(1) FROM logindetail WHERE LOWER(UserName) = LOWER(@uname) AND LOWER(Password) = LOWER(@pswd)";
                    ;

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uname", uname);
                        cmd.Parameters.AddWithValue("@pswd", pswd);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            MessageBox.Show("Login Successful!");
                            // Redirect to another form or perform next action
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void pswdtextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
