using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewPatientRecord_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private static string connetionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\DB.mdb";
        private static OleDbConnection cnn;
        private static OleDbCommand cmd;

        private void button1_Click(object sender, EventArgs e)
        {
            cnn = new OleDbConnection(connetionString);
            cnn.Open();
            cmd = new OleDbCommand("INSERT INTO tblPatients ([patientname], [patientage], [address], [contact], [gender], [bloodgroup], [details]) VALUES ('" + textName.Text + "', " + textAge.Text + ",'" + textAddress.Text + "','" + textContactNumber.Text + "','"  + comboBoxGender.SelectedItem.ToString() + "','" + comboBoxBloodGroup.SelectedItem.ToString() + "','" + textDetails.Text +"')", cnn);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textName.Clear();
            textAddress.Clear();
            textAge.Clear();
            textContactNumber.Clear();
            textDetails.Clear();
        }

        private void btnFullHistoryOfThePatient_Click(object sender, EventArgs e)
        {

            PatientDetails ds = new PatientDetails();
            ds.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnHospitalInformation_Click(object sender, EventArgs e)
        {
            information ds = new information();
            ds.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            payment ds = new payment();
            ds.ShowDialog();
        }
    }
}
