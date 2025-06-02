using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        ArrayList al;
        public Form1()
        {
            InitializeComponent();
            al = new ArrayList();
            al.Add("BA");
            al.Add("BCOM");
            al.Add("BBA");
            al.Add("BSC-IT");
            al.Add("BCA");
            al.Add("Btech");
            al.Add("MCA");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string data in al)
            {
                comboBox1.Items.Add(data);
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dotnetfs_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname, lname, email, qualification, technologies, gender, details;
            fname = textBox1.Text;
            lname = textBox2.Text;
            email = textBox3.Text;
            technologies = "";
            qualification = "";
            gender = "";

            if (fname == "")
            {
               MessageBox.Show("Please enter first name", "First Name" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (lname == "")
            {
               MessageBox.Show("Please enter last name", "Last Name" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (email == "")
            {
               MessageBox.Show("Please enter  email", "Email" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (comboBox1.SelectedItem != null)
            {
               qualification = comboBox1.SelectedItem.ToString();
                //  MessageBox.Show(qualification);
            }
            else
            {
               MessageBox.Show("Please select your qualification", "Qualification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (javafs.Checked == true)
            {
                technologies += javafs.Text + "\n";
            }
            if (dotnetfs.Checked == true)
            {
                technologies += dotnetfs.Text + "\n";

            }

            if (webfs.Checked == true)
            {
                technologies += webfs.Text + "\n";
            }
            //  MessageBox.Show(qualification+" "+ technologies.ToString());

            if (javafs.Checked == false && webfs.Checked == false && dotnetfs.Checked == false)
            {
                MessageBox.Show("Select your technologies", "Qualification", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (male.Checked == true)
            {
                gender = male.Text;
            }
            if (female.Checked == true)
            {
                gender = female.Text;
            }

            if (male.Checked == false && female.Checked == false)
            {
                MessageBox.Show("Please select gender", "Gender", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            details = "First Name: " + fname + "\n" + "Last Name: " + lname + "\n" + "Email: " + email + "\n" + "Qualification: " + qualification + "\n" + "Technologies: " + technologies + "\n" + "Gender: " + gender;

            info.Text = details;
            MessageBox.Show(details);

        }

        private void cancel_Click(object sender, EventArgs e)
        {
           details.Text = comboBox1.Text = textBox1.Text = textBox2.Text = textBox3.Text = "";
            javafs.Checked = dotnetfs.Checked = webfs.Checked = male.Checked = female.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

