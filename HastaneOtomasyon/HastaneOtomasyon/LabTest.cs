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
using System.Xml.Linq;

namespace HastaneOtomasyon
{
    public partial class LabTest : Form
    {
        public LabTest()
        {
            InitializeComponent();
            DisplayTest();
        }

        private void testxpictureout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HASANN\DOCUMENTS\ABMHOSPITAL.MDF;Integrated Security=True;Connect Timeout=30");

        private void DisplayTest()
        {
            Con.Open();
            string Query = "Select * from TestTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            testDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        int Key = 0;
        private void clear()
        {
            testAD.Text = "";
            testMaliyet.Text = "";
            Key = 0;

        }
        private void testKayıt_Click(object sender, EventArgs e)
        {
            if (testAD.Text == "" || testMaliyet.Text == "" )
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO TestTBL(testName,testCost)VALUES(@TN,@TC)", Con);
                    cmd.Parameters.AddWithValue("@TN", testAD.Text);
                    cmd.Parameters.AddWithValue("@TC", testMaliyet.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Eklendi.");
                    Con.Close();
                    DisplayTest();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void testDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            testAD.Text = testDGV.SelectedRows[0].Cells[1].Value.ToString();
            testMaliyet.Text = testDGV.SelectedRows[0].Cells[2].Value.ToString();
            if (testAD.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(testDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void testSil_Click(object sender, EventArgs e)
               {
                   if (Key == 0)
                   {
                       MessageBox.Show("Lütfen bir test seçiniz");
                   }
                   else
                   {

                       try
                       {
                           Con.Open();
                           SqlCommand cmd = new SqlCommand("DELETE FROM TestTBL WHERE testNum=@TKey", Con);

                           cmd.Parameters.AddWithValue("@TKey", Key);
                           cmd.ExecuteNonQuery();
                           MessageBox.Show("Test Silindi");
                           Con.Close();
                           DisplayTest();
                           clear();
                       }
                       catch (Exception ex)
                       {
                           MessageBox.Show(ex.Message);
                       }
                   }
               }
        private void testEdit_Click(object sender, EventArgs e)
        {
            if (testAD.Text == "" || testMaliyet.Text == "")
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE TestTBL SET testName= @TN,testCost=@TC where testNum=@TKey", Con);
                    cmd.Parameters.AddWithValue("@TN", testAD.Text);
                    cmd.Parameters.AddWithValue("@TC", testMaliyet.Text);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Test Düzenlendi.");
                    Con.Close();
                    DisplayTest();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void hastaMenu_Click(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }
        private void labMenu_Click(object sender, EventArgs e)
        {

        }

        private void testcikisyazi_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
