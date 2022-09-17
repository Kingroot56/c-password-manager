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


namespace Şifre_Yöneticisi
{
    public partial class Form1 : Form
    {

        SqlConnection baglantı;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }
        void getir()
        {
            baglantı = new SqlConnection("Data Source=DESKTOP-NJ1SBTD\\SQLEXPRESS;Initial Catalog=password;Integrated Security=True");
            baglantı.Open();
            da = new SqlDataAdapter("select * from pass",baglantı);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            a_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            k_ad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            p_ad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'passwordDataSet1.pass' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.passTableAdapter.Fill(this.passwordDataSet1.pass);
            
            getir();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
             id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
             a_ad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
             k_ad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
             p_ad.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into pass(app_name,user_name,password) values (@u_ad,@k_ad,@p_ad)";
            komut = new SqlCommand(sorgu,baglantı);
            komut.Parameters.AddWithValue("@u_ad",a_ad.Text);
            komut.Parameters.AddWithValue("@k_ad", k_ad.Text);
            komut.Parameters.AddWithValue("@p_ad",p_ad.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            getir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "delete from pass where id=@id";
                komut = new SqlCommand(sorgu, baglantı);
                komut.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
                baglantı.Open();
                komut.ExecuteNonQuery();
                baglantı.Close();
                getir();
                id.Text = "";
                a_ad.Text = "";
                k_ad.Text = "";
                p_ad.Text = "";
            }

            catch
            {
                a_ad.Text = "İD BOŞ OLAMAZ";
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu ="update pass set app_name=@u_ad,user_name=@k_ad,password=@p_ad where id=@id";
            komut = new SqlCommand(sorgu,baglantı);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));
            komut.Parameters.AddWithValue("@u_ad", a_ad.Text);
            komut.Parameters.AddWithValue("@k_ad", k_ad.Text);
            komut.Parameters.AddWithValue("@p_ad", p_ad.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            getir();
        }
    }
}
