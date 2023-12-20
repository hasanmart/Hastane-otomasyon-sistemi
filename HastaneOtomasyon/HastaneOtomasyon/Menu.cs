using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if(Login.Role == "Resepsiyonist")
            {
                resMenu.Enabled = false;
                doktorMenu.Enabled = false;
                labMenu.Enabled = false;
                preMenu.Enabled = false;
            }
            if (Login.Role == "Admin")
            {
                preMenu.Enabled = false;
            }
            if (Login.Role == "Doktor")
            {
                resMenu.Enabled = false;
                doktorMenu.Enabled = false;
                labMenu.Enabled = false;
            }
            CountPatients();
            CountDoctors();
            CountTest();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HASANN\DOCUMENTS\ABMHOSPITAL.MDF;Integrated Security=True;Connect Timeout=30");
        private void CountPatients()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From HastaTBL",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PatNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountDoctors()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From DoktorTBL", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DocNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void CountTest()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From TestTBL", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LabTestNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
        private void testxpictureout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hastaMenu_Click(object sender, EventArgs e)
        {
            Patient Obj = new Patient();
            Obj.Show();
            this.Hide();
        }

        private void doktorMenu_Click(object sender, EventArgs e)
        {
            DoktorYeni Obj = new DoktorYeni();
            Obj.Show();
            this.Hide();
        }

        private void labMenu_Click(object sender, EventArgs e)
        {
            LabTest Obj = new LabTest();
            Obj.Show();
            this.Hide();
        }

        private void resMenu_Click(object sender, EventArgs e)
        {
            Receotionist Obj = new Receotionist();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Prescriptions Obj = new Prescriptions();
            Obj.Show();
            this.Hide();
        }
    }
}
