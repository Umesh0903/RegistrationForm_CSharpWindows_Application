using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class MyMenu : Form
    {
        public MyMenu()
        {
            InitializeComponent();
        }

        private void MyMenu_Load(object sender, EventArgs e)
        {

        }

        private void existingUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            //login.MdiParent = this;
            login.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            //form1.MdiParent = this;
            form1.Show();
        }
    }
}
