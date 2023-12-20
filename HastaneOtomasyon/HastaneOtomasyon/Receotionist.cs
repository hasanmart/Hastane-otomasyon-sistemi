using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HastaneOtomasyon
{
    public partial class Receotionist : Form
    {
        public Receotionist()
        {
            InitializeComponent();
            DisplayRec();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HASANN\DOCUMENTS\ABMHOSPITAL.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False");
        private void DisplayRec()
        {
            Con.Open();
            string Query = "SELECT * FROM ResTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds =new DataSet();
            sda.Fill(ds);
            ResDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        
        private void RAddButton_Click(object sender, EventArgs e)
        {
            if (RName.Text == "" || RPassword.Text == "" || RTel.Text == "" || RAddress.Text == "")
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {
                
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO ResTBL(resAd,resTel,resAdres,resPas)VALUES(@RN,@RT,@RAD,@RP)", Con);
                    cmd.Parameters.AddWithValue("@RN", RName.Text);
                    cmd.Parameters.AddWithValue("@RT", RTel.Text);
                    cmd.Parameters.AddWithValue("@RAD", RAddress.Text);
                    cmd.Parameters.AddWithValue("@RP", RPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resepsiyonist Eklendi.");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RDelButton_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Lütfen bir Resepsiyonist seçiniz");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ResTBL WHERE resID=@RKey", Con);

                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resepsiyonist Silindi");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Receotionist_Load(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RName_TextChanged(object sender, EventArgs e)
        {

        }

        private void RTel_TextChanged(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void ResDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RName.Text = ResDGV.SelectedRows[0].Cells[1].Value.ToString();
            RTel.Text = ResDGV.SelectedRows[0].Cells[2].Value.ToString();
            RAddress.Text = ResDGV.SelectedRows[0].Cells[3].Value.ToString();
            RPassword.Text = ResDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (RName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(ResDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void REditButton_Click(object sender, EventArgs e)
        {
            if (RName.Text == "" || RPassword.Text == "" || RTel.Text == "" || RAddress.Text == "")
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE ResTBL SET resAd=@RN ,resTel=@RT ,resAdres=@RAD ,resPas=@RP WHERE resID=@RKey", Con);
                    cmd.Parameters.AddWithValue("@RN", RName.Text);
                    cmd.Parameters.AddWithValue("@RT", RTel.Text);
                    cmd.Parameters.AddWithValue("@RAD", RAddress.Text);
                    cmd.Parameters.AddWithValue("@RP", RPassword.Text);
                    cmd.Parameters.AddWithValue("@RKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Resepsiyonist Düzenlendi");
                    Con.Close();
                    DisplayRec();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void clear()
        {
            RName.Text = "";
            RPassword.Text = "";
            RTel.Text = "";
            RAddress.Text = "";
            Key = 0;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
        private void label3_Click_1(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }

        private void resMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
