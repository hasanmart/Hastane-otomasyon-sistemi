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
    public partial class Reçete : Form
    {
        public Reçete()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HASANN\DOCUMENTS\ABMHOSPITAL.MDF;Integrated Security=True;Connect Timeout=30");

        private void DisplayPres()
        {
            Con.Open();
            string Query = "Select * from presTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PresDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            dIDCB.SelectedIndex = 0;
            pIDCB.SelectedIndex = 0;
            tIDCB.SelectedIndex = 0;
            DName.Text = "";
            PName.Text = "";
            PTestName.Text = "";

            // Key = 0;

        }
        private void GetDName()
        {
            Con.Open();
            string Query = "Select * From DoktorTBL where docID=" + dIDCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DName.Text = dr["docName"].ToString();
            }
            Con.Close();
        }
        private void GetdocID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select docID From DoktorTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("docID", typeof(int));
            dt.Load(rdr);
            dIDCB.ValueMember = "docID";
            dIDCB.DataSource = dt;
            Con.Close();
        }
        private void GethastaID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select hastaID From HastaTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("hastaID", typeof(int));
            dt.Load(rdr);
            pIDCB.ValueMember = "hastaID";
            pIDCB.DataSource = dt;
            Con.Close();
        }
        private void GettestID()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select testNum From TestTBL", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("testNum", typeof(int));
            dt.Load(rdr);
            tIDCB.ValueMember = "testNum";
            tIDCB.DataSource = dt;
            Con.Close();
        }
        private void testxpictureout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void presEKLE_Click(object sender, EventArgs e)
        {

        }

        private void PresYAZDIR_Click(object sender, EventArgs e)
        {

        }

        private void DName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PTestName_TextChanged(object sender, EventArgs e)
        {

        }

        private void PName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
