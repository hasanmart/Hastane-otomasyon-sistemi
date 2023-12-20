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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
            DisplayPat();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HASANN\DOCUMENTS\ABMHOSPITAL.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False");

        private void DisplayPat()
        {
            Con.Open();
            string Query = "Select * from HastaTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            PatAD.Text = "";
            PatTel.Text = "";
            PatAddress.Text = "";
            PatAlg.Text = "";
            PatCsCB.SelectedIndex = 0;
            PatHıvCB.SelectedIndex = 0;
            Key = 0;

        }
        private void PatEkle_Click(object sender, EventArgs e)
        {
            if (PatAD.Text == "" || PatAlg.Text == "" || PatTel.Text == "" || PatAddress.Text == "" || PatCsCB.SelectedIndex == -1 || PatHıvCB.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO HastaTBL(hastaAD,hastaTARİH,hastaCS,hastaEADRES,hastaTEL,hastaHIV,hastaALG)VALUES(@PA,@PD,@PC,@PADD,@PT,@PH,@PAL)", Con);
                    cmd.Parameters.AddWithValue("@PA", PatAD.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PC", PatCsCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PADD", PatAddress.Text);
                    cmd.Parameters.AddWithValue("@PT", PatTel.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHıvCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", PatAlg.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hasta Eklendi.");
                    Con.Close();
                    DisplayPat();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void PatDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatAD.Text = PatDGV.SelectedRows[0].Cells[1].Value.ToString();
            PatCsCB.SelectedItem = PatDGV.SelectedRows[0].Cells[2].Value.ToString();
            PatDOB.Text = PatDGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAddress.Text = PatDGV.SelectedRows[0].Cells[4].Value.ToString();
            PatTel.Text = PatDGV.SelectedRows[0].Cells[5].Value.ToString();
            PatHıvCB.SelectedItem = PatDGV.SelectedRows[0].Cells[6].Value.ToString();
            PatAlg.Text = PatDGV.SelectedRows[0].Cells[7].Value.ToString();
 
            
            if (PatAD.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(PatDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void PatSil_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Lütfen bir hasta seçiniz");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM HastaTBL WHERE hastaID=@PKey", Con);

                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hasta Silindi");
                    Con.Close();
                    DisplayPat();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PatEdit_Click(object sender, EventArgs e)
        {
            if (PatAD.Text == "" || PatAlg.Text == "" || PatTel.Text == "" || PatAddress.Text == "" || PatCsCB.SelectedIndex == -1 || PatHıvCB.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE HastaTBL SET hastaAD= @PA,hastaTARİH= @PD,hastaCS= @PC,hastaALG= @PAL,hastaTEL= @PT,hastaHIV= @PH,hastaEADRES= @PADD WHERE  hastaID= @PKey", Con);
                    cmd.Parameters.AddWithValue("@PA", PatAD.Text);
                    cmd.Parameters.AddWithValue("@PD", PatDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@PC", PatCsCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PADD", PatAddress.Text);
                    cmd.Parameters.AddWithValue("@PT", PatTel.Text);
                    cmd.Parameters.AddWithValue("@PH", PatHıvCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PAL", PatAlg.Text);
                    cmd.Parameters.AddWithValue("@PKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hasta Düzenlendi.");
                    Con.Close();
                    DisplayPat();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void testxpictureout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PatAddress_TextChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        private void label1_Click_1(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }
    }
}
