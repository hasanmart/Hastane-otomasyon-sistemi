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
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
            DisplayDoc();
        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void BunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HASANN\DOCUMENTS\ABMHOSPITAL.MDF;Integrated Security=True;Connect Timeout=30");

        private void DisplayDoc()
        {
            Con.Open();
            string Query = "Select * from DoktorTBL";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DocDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Clear()
        {
            DocName.Text = "";
            DocTel.Text = "";
            DocAddress.Text = "";
            DocPassword.Text = "";
            DocExp.Text = "";
            DocCsCB.SelectedIndex = 0;
            DocSpCB.SelectedIndex = 0;
            Key=0;

        }
        private void GunaButton1_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || DocPassword.Text == "" || DocTel.Text == "" || DocAddress.Text == "" || DocCsCB.SelectedIndex == -1 || DocSpCB.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO DoktorTBL(docName,docDob,docCs,docUzm,docDeneyim,docTel,docAdres,docPass)VALUES(@DN,@DD,@DC,@DS,@DE,@DT,@DA,@DP)", Con);
                    cmd.Parameters.AddWithValue("@DN", DocName.Text);
                    cmd.Parameters.AddWithValue("@DT", DocTel.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddress.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPassword.Text);
                    cmd.Parameters.AddWithValue("@DC", DocCsCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExp.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doktor Eklendi.");
                    Con.Close();
                    DisplayDoc();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        int Key = 0;
        private void DocDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocName.Text = DocDGV.SelectedRows[0].Cells[1].Value.ToString();
            DocCsCB.SelectedItem = DocDGV.SelectedRows[0].Cells[2].Value.ToString();
            DocSpCB.SelectedItem = DocDGV.SelectedRows[0].Cells[3].Value.ToString();
            DocDOB.Text = DocDGV.SelectedRows[0].Cells[4].Value.ToString();
            DocExp.Text = DocDGV.SelectedRows[0].Cells[5].Value.ToString();
            DocTel.Text = DocDGV.SelectedRows[0].Cells[6].Value.ToString();
            DocAddress.Text = DocDGV.SelectedRows[0].Cells[7].Value.ToString();
            DocPassword.Text = DocDGV.SelectedRows[0].Cells[8].Value.ToString();
            if (DocName.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(DocDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DSil_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Lütfen bir doktor seçiniz");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM DoktorTBL WHERE docID=@DKey", Con);

                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doktor Silindi");
                    Con.Close();
                    DisplayDoc();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        

        private void DEdit_Click(object sender, EventArgs e)
        {
            if (DocName.Text == "" || DocPassword.Text == "" || DocTel.Text == "" || DocAddress.Text == "" || DocCsCB.SelectedIndex == -1 || DocSpCB.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Ekleme Yapınız!!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE DoktorTBL SET DocName= @DN,DocDob= @DD,docCs= @DC,docUzm= @DS,docDeneyim= @DE,docTel= @DT,docAdres= @DA,docPass= @DP WHERE DocID = @DKey", Con);
                    cmd.Parameters.AddWithValue("@DN", DocName.Text);
                    cmd.Parameters.AddWithValue("@DD", DocDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@DC", DocCsCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DS", DocSpCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@DE", DocExp.Text);
                    cmd.Parameters.AddWithValue("@DT", DocTel.Text);
                    cmd.Parameters.AddWithValue("@DA", DocAddress.Text);
                    cmd.Parameters.AddWithValue("@DP", DocPassword.Text);
                    cmd.Parameters.AddWithValue("@DKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Doktor Düzenledi.");
                    Con.Close();
                    DisplayDoc();
                    Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label9_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Menu Obj = new Menu();
            Obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DocCsCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
