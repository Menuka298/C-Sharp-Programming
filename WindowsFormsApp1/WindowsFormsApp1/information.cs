using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class information : Form
    {
        public information()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private static string connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";
        private static OleDbConnection cnn;
        private static OleDbCommand cmd;
        private void information_Load(object sender, EventArgs e)
        {
            cnn = new OleDbConnection(connetionString);
            cnn.Open();
            cmd = new OleDbCommand("SELECT COUNT(*) FROM tblPatients", cnn);
            int count = (int)cmd.ExecuteScalar();
            txtpat.Text = count.ToString();
            cnn.Close();
        }

        private void txtpat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }
    }
}
