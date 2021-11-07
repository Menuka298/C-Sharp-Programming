using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_UserName.Text;
            string pass = txt_Password.Text;

            if(username == "hms" && pass == "pass")
            {
                //MessageBox.Show("You Have Enterd Right Username & Password........");
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username Or Password.....");
            }
        }
    }
}
