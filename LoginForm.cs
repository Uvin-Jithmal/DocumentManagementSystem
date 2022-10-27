using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerDetailsManagementSystem;

namespace ERP_System
{
    public partial class LoginForm : Form
    {
        Form mf = new MainForm();
        string dept;


        //Public variable to display logged user anme in main form
        public static string UserName;
        public static string Department;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(Form MainForm, int systemID)
        {
            InitializeComponent();
            mf = MainForm;
            txtusername.Select();
            txtusername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Please Enter UserName ");
                return;
            }
            if (String.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please Enter Password ");
                return;
            }


            if (txtusername.Text == "kalindu" && txtpassword.Text == "1234")
            {
                dept = "HR";
                // Application.Run(new MainForm());
                MessageBox.Show("Login Completed ! Welcome " + txtusername.Text);
                mf.Show();
                UserName = txtusername.Text;
                Department = "HR";
                return;
                this.Hide();
            }
            if (txtusername.Text == "uvin" && txtpassword.Text == "1234")
            {
                dept = "IT";
                MessageBox.Show("Login Completed ! Welcome " + txtusername.Text);
                mf.Show();
                UserName = txtusername.Text;
                Department = "IT";
                return;
                this.Close();
            }
            if (txtusername.Text == "ishini" && txtpassword.Text == "1234")
            {
                dept = "Finance";
                MessageBox.Show("Login Completed ! Welcome " + txtusername.Text);
                mf.Show();
                UserName = txtusername.Text;
                Department = "Finance";
                return;
                this.Close();
            }
            if (txtusername.Text == "shalini" && txtpassword.Text == "1234")
            {
                dept = "Finance";
                MessageBox.Show("Login Completed ! Welcome " + txtusername.Text);
                mf.Show();
                UserName = txtusername.Text;
                Department = "Finance";
                return;
                this.Close();
            }
            else
                MessageBox.Show("Invalid Username or Password !");
            txtusername.Refresh();
            txtpassword.Refresh();
        }




        private void button1_Click(object sender, EventArgs e)
        {



            ///////////

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
