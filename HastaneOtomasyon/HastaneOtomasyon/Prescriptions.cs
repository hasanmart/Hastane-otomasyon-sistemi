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
    public partial class Prescriptions : Form
    {
        public Prescriptions()
        {
            InitializeComponent();
            DisplayPres();
            GetdocID();
            GethastaID();
            GettestID();
            
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
            MaliyetTb.Text = "";
            PİlaçName.Text = "";
            DName.Text = "";
            PName.Text = "";
            PTestName.Text = "";
            
           // Key = 0;

        }

        private void GunaGroupBox1_Click(object sender, EventArgs e)
        {
        
        }
        
        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
        
        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
        
        }
        
        private void Prescriptions_Load(object sender, EventArgs e)
        {
        
        }
        
        private void Label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        
        private void PictureBox2_Click(object sender, EventArgs e)
        {
        
        }
        private void GetDName()
        {
            Con.Open();
            string Query = "Select * From DoktorTBL where docID=" +dIDCB.SelectedValue.ToString()+ "";
            SqlCommand cmd =new SqlCommand(Query,Con);
            DataTable dt =new DataTable();
            SqlDataAdapter sda =new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DName.Text = dr["docName"].ToString();
            }
            Con.Close();
        }
        private void GetPName()
        {
            Con.Open();
            string Query = "Select * From HastaTBL where hastaID=" + pIDCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PName.Text = dr["hastaAD"].ToString();
            }
            Con.Close();
        }
        private void GetPTestName()
        {
            Con.Open();
            string Query = "Select * From TestTBL where testNum=" + tIDCB.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(Query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PTestName.Text = dr["testName"].ToString();
                MaliyetTb.Text = dr["testCost"].ToString();
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
            Con.Close() ;
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
        private void Testxpictureout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        int Key = 0;
        private void PresEKLE_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || DName.Text == "" || PTestName.Text == "" )
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO presTBL(docID,docAd,hastaID,hastaAD,labtestID,labtestAd,ilaclar,maliyet)VALUES(@DI,@DN,@PI,@PN,@TI,@TN,@İL,@MA)", Con);
                    cmd.Parameters.AddWithValue("@DI", dIDCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@DN", DName.Text);
                    cmd.Parameters.AddWithValue("@PI", pIDCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@PN", PName.Text);
                    cmd.Parameters.AddWithValue("@TI", tIDCB.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TN", PTestName.Text);
                    cmd.Parameters.AddWithValue("@İL", PİlaçName.Text);
                    cmd.Parameters.AddWithValue("@MA", MaliyetTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Reçete Eklendi.");
                    Con.Close();
                    DisplayPres();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PresYAZDIR_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void DIDCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetDName();
        }

        private void pIDCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPName();
        }

        private void tIDCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetPTestName();
        }

        private void PresDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ReçeteName.Text = "";
            ReçeteName.Text = "                                                      ABM Hospital\n\n" + "                                                         REÇETE               " + "\n*************************************************************************************************" + "\n" +DateTime.Today.Date + "\n\n\n               Doktor: "+ PresDGV.SelectedRows[0].Cells[2].Value.ToString()+"                         Hasta: "+PresDGV.SelectedRows[0].Cells[4].Value.ToString()+"\n\n\n               Test:"+PresDGV.SelectedRows[0].Cells[6].Value.ToString()+"                   "+"              İlaçlar: "+  PresDGV.SelectedRows[0].Cells[7].Value.ToString()+"\n\n\n\n\n\n                                                       ABM Hospital";             

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReçeteName.Text + "\n", new Font("Averia", 18, FontStyle.Regular), Brushes.Black, new Point(0, 0));
            e.Graphics.DrawString("\n\t" + "Onaylı  Belge", new Font("Averia", 15, FontStyle.Bold), Brushes.Green, new Point(300, 480));

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
