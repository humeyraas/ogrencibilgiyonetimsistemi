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
namespace ogrencibilgiyonetimsistemi
{
    public partial class FormOgretmen : Form
    {
        public FormOgretmen()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-U5TLUJP;Initial Catalog=ogrenci_bilgi_yonetim;Integrated Security=True;TrustServerCertificate=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from ogretmen", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ogretmen_id"].ToString();
                ekle.SubItems.Add(oku["ad"].ToString());
                ekle.SubItems.Add(oku["soyad"].ToString());
                ekle.SubItems.Add(oku["telno"].ToString());

                listView1.Items.Add(ekle);

            }
            baglan.Close();




        }

        private void btnVeriGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void btnveriKaydet_Click(object sender, EventArgs e)
        {
            baglan.Open();
            string kayit = ("insert into ogretmen(ad,soyad,telno) values (@ad,@soyad,@telno)");
            SqlCommand komut = new SqlCommand(kayit, baglan);
            komut.Parameters.AddWithValue("@ad", tbAd.Text);
            komut.Parameters.AddWithValue("@soyad", tbSoyad.Text);
            komut.Parameters.AddWithValue("@telno", tbTelefon.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Eklendi.");
            verilerigoster();
            tbAd.Clear();
            tbSoyad.Clear();
            tbTelefon.Clear();
        }


        int id = 0;

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from ogretmen where ogretmen_id = (" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("Veri silindi.");
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            tbAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbSoyad.Text = listView1.SelectedItems[0].SubItems[2].Text;
            tbTelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void btnVeriGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update ogretmen set ad = '" + tbAd.Text.ToString() + "' ,soyad ='" + tbSoyad.Text.ToString() + "' , telno='" + tbTelefon.Text.ToString() + "'where ogretmen_id =" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("Veri güncellendi.");
            tbAd.Clear();
            tbSoyad.Clear();    
            tbTelefon.Clear();

        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
            
        }

        private void btnDersler_Click(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();
            dersler.Show();
            
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            Notlar notlar = new Notlar();
            notlar.Show();
           
        }

        private void FormOgretmen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }


}

