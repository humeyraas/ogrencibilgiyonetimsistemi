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
    public partial class Notlar : Form
    {
        public Notlar()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-U5TLUJP;Initial Catalog=ogrenci_bilgi_yonetim;Integrated Security=True;TrustServerCertificate=True");


        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from ogrenci_ders", baglan);
            SqlDataReader sqlDataReader = komut.ExecuteReader();
            using (SqlDataReader oku = sqlDataReader)
            {
                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["ders_id"].ToString();
                    ekle.SubItems.Add(oku["ogrenci_id"].ToString());
                    ekle.SubItems.Add(oku["notu"].ToString());


                    listView1.Items.Add(ekle);

                }
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
            string kayit = ("insert into ogrenci_ders(ders_id,ogrenci_id,notu) values (@dersid,@ogrenciid,@notu)");
            SqlCommand komut = new SqlCommand(kayit, baglan);
            komut.Parameters.AddWithValue("@dersid", tbDersid.Text);
            komut.Parameters.AddWithValue("@ogrenciid", tbOgrenciid.Text);
            komut.Parameters.AddWithValue("@notu", tbNotu.Text);
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Eklendi.");
            verilerigoster();
            tbDersid.Clear();
            tbOgrenciid.Clear();
            tbNotu.Clear();

        }
        int id = 0;
        int id2 = 0;

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Delete from ogrenci_ders where ders_id = (" + id + ") and ogrenci_id = ("+ id2 + ")" , baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("Veri silindi.");

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            id2 = int.Parse(listView1.SelectedItems[0].SubItems[1].Text);
            tbDersid.Text = listView1.SelectedItems[0].SubItems[0].Text;
            tbOgrenciid.Text = listView1.SelectedItems[0].SubItems[1].Text;
            tbNotu.Text = listView1.SelectedItems[0].SubItems[2].Text;

        }

        private void btnVeriGuncelle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("update ogrenci_ders set ders_id = '"+ tbDersid.Text.ToString() + " ', ogrenci_id='" + tbOgrenciid.Text.ToString() + "' , notu = '" + tbNotu.Text.ToString() + "'where ders_id =" + id + " and ogrenci_id =" + id2 +" " , baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            verilerigoster();
            MessageBox.Show("Veri güncellendi.");
            tbDersid.Clear();
            tbOgrenciid.Clear();
            tbNotu.Clear();

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

        private void btnDersler_Click(object sender, EventArgs e)
        {
            Dersler dersler = new Dersler();    
            dersler.Show();
            
        }

        private void Notlar_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
