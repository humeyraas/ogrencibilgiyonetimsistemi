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

namespace ogrencibilgiyonetimsistemi
{
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
        }
      
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-U5TLUJP;Initial Catalog=ogrenci_bilgi_yonetim;Integrated Security=True;TrustServerCertificate=True");


        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from dersler", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ders_id"].ToString();
                ekle.SubItems.Add(oku["dersAdi"].ToString());
                ekle.SubItems.Add(oku["ogretmen_id"].ToString());


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
            string kayit = ("insert into dersler(dersAdi,ogretmen_id) values (@ad,@ogretmen)");
            SqlCommand komut = new SqlCommand(kayit, baglan);
            komut.Parameters.AddWithValue("@ad", tbAd.Text);
            komut.Parameters.AddWithValue("@ogretmen", tbOgretmenid.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Eklendi.");
            verilerigoster();
            tbAd.Clear();
            tbOgretmenid.Clear();
        }
        int id = 0;

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from dersler where ders_id = (" + id + ")", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("Veri silindi.");
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            tbAd.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbOgretmenid.Text = listView1.SelectedItems[0].SubItems[2].Text;
            
        }

        private void btnVeriGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update dersler set DersAdi = '" + tbAd.Text.ToString() + "' , ogretmen_id='" + tbOgretmenid.Text.ToString() + "'where ders_id =" + id + "", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("Veri güncellendi.");
            tbAd.Clear();
            tbOgretmenid.Clear();
        }

        private void btnOgrenciler_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  
            form1.Show();
           
        }

        private void btnOgretmen_Click(object sender, EventArgs e)
        {
            FormOgretmen formogretmen = new FormOgretmen(); 
            formogretmen.Show();
           
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            Notlar notlar = new Notlar();
            notlar.Show();
           
        }

        private void Dersler_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }






}
