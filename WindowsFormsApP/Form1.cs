using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApP
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            username.Focus();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        //    String usr, pswd;
        //    usr = username.Text;
        //    pswd = pwd.Text;
        //    if (String.IsNullOrEmpty(usr))
        //    {
        //        ltxt.Text = "Please Enter the UserName";
        //       ltxt.Visible = true;
        //   }
         }
        private void button1_Click(object sender, EventArgs e)
        {
            String usr, pswd;
            usr = username.Text;
            pswd = pwd.Text;

            if (usr == "Admin" && pswd == "12345")
            {
                MessageBox.Show("Login Successful");
                username.Text = null;
                pwd.Text = null;
                
            }
            else
            {
                MessageBox.Show("Login Failed Please try again");
                username.Text = null;
                pwd.Text = null;
                username.Focus();
            }
        }


    }
}