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
using static System.Net.WebRequestMethods;


namespace Film_Arşiv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int say = 0;

        SqlConnection dbbağlanti = new SqlConnection("Data Source=DESKTOP-0DOOTGM\\SQLEXPRESS01;Initial Catalog=FilmArşiv;Integrated Security=True");

        DataSet1TableAdapters.Table_FilmlerTableAdapter filmler = new DataSet1TableAdapters.Table_FilmlerTableAdapter();

        void tabloyenile()
        {
            dataGridView1.DataSource = filmler.GetData();

        }


        private void buttonFilmEkle_Click(object sender, EventArgs e)
        {
            filmler.FilmEkle(textBoxFilmAd.Text, comboBoxKatFilm.Text, textBoxFilmLink.Text);
            MessageBox.Show("Film " + textBoxFilmAd.Text + " Başarılı Şekilde Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabloyenile();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Film Adı";
            textBox1.ForeColor = Color.Gray;

            tabloyenile();
            katagoriçek();
        }


        void katagoriçek()
        {
            dbbağlanti.Open();

            SqlCommand cekkata = new SqlCommand("Select * from Table_FilmKat", dbbağlanti);


            SqlDataReader rd = cekkata.ExecuteReader();

            while (rd.Read())
            {

                comboBoxKatFilm.Items.Add(rd[1].ToString());
            }
            dbbağlanti.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        string dd;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                webBrowser1.Navigate(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            catch
            {
                webBrowser1.Navigate(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
          

        }

        public void webpro()
        {
            webBrowser1.Navigate("");
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonhak_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Proje Y.ALPARSLAN Tarafından Yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.BackColor = Color.Pink;
        }

        private void buttonrnkdgs_Click(object sender, EventArgs e)
        {
            
            
            
            say++;
            if (say == 1)
            {
                this.BackColor = Color.Pink;


            }
            else if(say == 2)
            {
                this.BackColor = Color.GhostWhite;
            }
         
            else if (say == 2)
            {
                this.BackColor = Color.BurlyWood;
            }
            else if (say == 3)
            {
                this.BackColor = Color.Brown;
            }
            else if (say == 4)
            {
                this.BackColor = Color.Blue;
            }
            else if (say == 5)
            {
                this.BackColor = Color.AntiqueWhite;
            }
            else if (say == 6)
            {
                this.BackColor = Color.MistyRose;
                say = 0;
            }
        }

        private void buttontamekran_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbbağlanti.Open();

            SqlCommand cekkata = new SqlCommand("Select FilmAd,Link from Table_Filmler where FilmAd=@p1", dbbağlanti);
            cekkata.Parameters.AddWithValue("@p1", textBox1.Text);

            SqlDataAdapter drt = new SqlDataAdapter(cekkata);

            DataTable dt = new DataTable();

            drt.Fill(dt);

            dataGridView1.DataSource = dt;
           


          //  dataGridView1.DataSource = cekkata;


            
            
            cekkata.ExecuteNonQuery();
            MessageBox.Show("Bu Proje Y.ALPARSLAN Tarafından Yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            dbbağlanti.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="Film Adı")
            {
                textBox1.Clear();
                textBox1.ForeColor = Color.Black;
            }
        }
    }
}
