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

namespace WinFormsApp1
{
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        void VeriCek()
        {
            con = new SqlConnection(@"server=DESKTOP-CGLV6T1\TEW_SQLEXPRESS;Initial Catalog=RentaCar;Integrated Security=True");
            da = new SqlDataAdapter("Select * from car", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "car");
            dtg_car.DataSource = ds.Tables["car"];
            con.Close();

        }
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
           
            cmd.CommandText = "insert into car(car_id,car_name,car_color,car_brand,kiralanma_durumu) values(" + txt_aracno.Text + ",'" + txt_aracad.Text + "','" + txt_aracrenk.Text + "','" + txt_aracmarka.Text +"','"+txt_arackiralanma +"')";
            cmd.ExecuteNonQuery();
            con.Close();
            VeriCek();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {
            VeriCek();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;

           
            cmd.CommandText = "update car set car_name='" + txt_aracad.Text + "',car_color='" + txt_aracrenk.Text + "' ,car_brand='" + txt_aracmarka.Text +"',kiralanma_durumu='"+txt_arackiralanma+ "' where car_id=" + txt_aracno.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            VeriCek();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "delete from car where car_id=" + txt_aracno.Text + "";
            cmd.ExecuteNonQuery();
            con.Close();
            VeriCek();
        }
    }
}
