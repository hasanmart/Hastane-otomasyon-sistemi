using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneOtomasyon
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void logClear_Click(object sender, EventArgs e)
        {
            roleCB.SelectedIndex = 0;
            logName.Text = "";
            logPass.Text = "";

        }

        private void roleCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=C:\USERS\HASANN\DOCUMENTS\ABMHOSPITAL.MDF;Integrated Security=True;Connect Timeout=30");

        public static string Role;
        private void logButton_Click(object sender, EventArgs e)
        {
            if(roleCB.SelectedIndex == -1)
            {
                MessageBox.Show("Yetkinizi giriniz");
            }
            else if(roleCB.SelectedIndex == 0)
            {
                if(logName.Text == "" || logPass.Text == "")
                {
                    MessageBox.Show("Admin ad ve şifrenizi giriniz.");
                }
                else if(logName.Text == "Admin" &&  logPass.Text == "abm123")
                {
                    Role = "Admin";
                    Menu Obj = new Menu();
                    Obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("HATALI Admin ad veya şifresi girdiniz.");
                }
            }
            else if (roleCB.SelectedIndex == 1)
            {
                if (logName.Text == "" || logPass.Text == "")
                {
                    MessageBox.Show("Doktor adı ve şifrenizi giriniz.");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From DoktorTBL where docName='"+logName.Text+"'and docPass='"+logPass.Text+"'",Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Doktor";
                        Menu Obj = new Menu();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Doktor Bulunamadı !!");
                    }
                    Con.Close();
                }
            }
            else
            {
                if (logName.Text == "" || logPass.Text == "")
                {
                    MessageBox.Show("Tıbbi Sekreter adı ve şifrenizi giriniz.");
                }
                else
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From ResTBL where resAd='" + logName.Text + "'and resPas='" + logPass.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        Role = "Resepsiyonist";
                        Menu Obj = new Menu();
                        Obj.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Tıbbi Sekreter Bulunamadı !!");
                    }
                    Con.Close();
                }
            }
        }

        private void gunaPictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void passsecret_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (logPass.PasswordChar.ToString() == "*")
            {
                logPass.PasswordChar = char.Parse("\0");
                passsecret.Text = "Gizle";
            }
            else
            {
                logPass.PasswordChar = char.Parse("*");
                passsecret.Text = "Göster";
            }

        }
    }
}
