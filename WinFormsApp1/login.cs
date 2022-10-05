using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;


        private void btn_giris_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection();
            //con = new SqlConnection(@"server = DESKTOP-CGLV6T1\TEW_SQLEXPRESS; Initial Catalog = RentaCar; Integrated Security = True;TrustServerCertificate=True");
            //con.Open();
            //string user = txt_kadi.Text;
            //string pass = txt_pass.Text;
            //SqlCommand cmd = new SqlCommand("SELECT user_ad,user_pass from user where user_ad='"+user+"'AND user_pass='"+pass+"");
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable();
            //da.Fill(dt);
            //if(dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Giriş başarılı");
            //    CarForm carForm=new CarForm();
            //    carForm.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Giriş başarısız");
            //}
            //con.Close();
            con = new SqlConnection(@"server=DESKTOP-CGLV6T1\TEW_SQLEXPRESS; Initial Catalog=RentaCar; Integrated Security=True");
            cmd = new SqlCommand("Select * from user  where user_ad=@kadi AND user_pass=pass", con);
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@kadi", txt_kadi);
            cmd.Parameters.AddWithValue("@pass", txt_pass);
            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Tebrikler Başarılı Bir Şekilde Giriş Yaptınız");
                CarForm carForm = new CarForm();
                carForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınızı veya Şifrenizi Kontrol Ediniz");

            }
            con.Close();


        }
    }
    }


