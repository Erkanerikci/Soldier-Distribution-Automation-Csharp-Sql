using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AskerOtomasyon
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;



        void AskerGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DARK;Initial Catalog=askerotomasyon;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM askerler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        void TaburGetir()
        {
            baglanti = new SqlConnection(@"Data Source=DARK;Initial Catalog=askerotomasyon;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM taburlar", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AskerGetir();
            TaburGetir();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtaskerid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtasker1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtasker2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }
        private void dataGridView2_CellEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            txttaburid.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            txttabur1.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void asker_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO askerler(isim, soyisim) VALUES(@isim, @soyisim)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@isim", txtasker1.Text);
            komut.Parameters.AddWithValue("@soyisim", txtasker2.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AskerGetir();
        }

        private void asker_guncelle_Click(object sender, EventArgs e)
        {


            string sorgu = "UPDATE askerler SET isim=@isim,soyisim=@soyisim WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtaskerid.Text));
            komut.Parameters.AddWithValue("@isim", (txtasker1.Text));
            komut.Parameters.AddWithValue("@soyisim", (txtasker2.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AskerGetir();

        }

        private void asker_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM askerler WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txtaskerid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            AskerGetir();
        }

        private void taburlar_ekle_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO taburlar(Adý) VALUES(@Adý)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Adý", txttabur1.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TaburGetir();
        }

        private void taburlar_guncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "UPDATE taburlar SET Adý=@Adý WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txttaburid.Text));
            komut.Parameters.AddWithValue("@Adý", (txttabur1.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TaburGetir();
        }

        private void taburlar_sil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM taburlar WHERE id=@id";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@id", Convert.ToInt32(txttaburid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            TaburGetir();
        }

        private void btngec_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        
    }
}
