using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskerOtomasyon
{
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        ArrayList askerler = new ArrayList();
        ArrayList sehirler = new ArrayList();
        ArrayList yedeksehir = new ArrayList();
        ArrayList atama = new ArrayList();


        

        private ListBox[] listBoxes;
        public Form2()
        {
            InitializeComponent();
            InitializeListBoxes();
        }
        private void InitializeListBoxes()
        {
            listBoxes = new ListBox[] { listBox2, listBox3, listBox4, listBox5, listBox6, listBox7, listBox8 };
        }
        private void btndagit_Click(object sender, EventArgs e)
        {
            foreach (var listBox in listBoxes)
            {
                listBox.Items.Clear();
            }
            List<string> listbox1Data = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listbox1Data.Add(listBox1.Items[i].ToString());
            }

            Random random = new Random();
            foreach (var listBox in listBoxes)
            {
                List<string> selectedData = listbox1Data.OrderBy(item => random.Next()).Take(10).ToList();
                foreach (var data in selectedData)
                {
                    listBox.Items.Add(data);
                    listbox1Data.Remove(data);

                }
            }

        } 



        private void Form2_Load_1(object sender, EventArgs e)
        {
            listBox1.Hide();
            try
            {
                string connectionString = "Data Source=DARK;Initial Catalog=askerotomasyon;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "select askerler.isim,askerler.soyisim,taburlar.Adı from askerler,taburlar";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            string ad = reader["isim"].ToString();
                            string Soyad = reader["soyisim"].ToString();
                            string sehir = reader["Adı"].ToString();

                            listBox1.Items.Add(ad +" "+ Soyad + " - " + sehir);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Verileri getirme hatası: " + ex.Message);
            }
        }
    }
}
