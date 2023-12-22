using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtomasyonLokanta
{
    public partial class KategoteriForm : Form
    {
        public KategoteriForm()
        {
            InitializeComponent();
        }
        LokantaDbEntities baglan=new LokantaDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                    Kategoriler kate = new Kategoriler();
                    kate.Kategori_Ad = textBox1.Text;
                    
                    baglan.Kategoriler.Add(kate);
                    baglan.SaveChanges();
                    MessageBox.Show("Kaydınız Yapılmıştır");
                    doldur();
                    temizle();
                

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Arama Yapmadınız veya Tablodan Kayıt Seçmediniz");
                }
                else
                {
                    DialogResult cevap = MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz?", "Dikkat Kayıt Silme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt16(textBox2.Text);
                        var bul = baglan.Kategoriler.Find(Id);
                        baglan.Kategoriler.Remove(bul);
                        baglan.SaveChanges();
                        MessageBox.Show("Kaydınız Silimiştir");
                        doldur();
                        temizle();
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu.", ex.Message);
            }
        }
        void doldur()
        {
            var listem = baglan.Kategoriler.ToList();
            dataGridView1.DataSource = listem;
        }
        void temizle()
        {
            textBox1.Text = string.Empty;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == string.Empty)
                {
                    MessageBox.Show("Arama Yapmadınız veya Tablodan Kayıt Seçmediniz");
                }
                else
                {
                    int Id = Convert.ToInt16(textBox2.Text);
                    var bul = baglan.Kategoriler.Find(Id);
                    bul.Kategori_Ad = textBox1.Text;
                    

                    baglan.SaveChanges();
                    MessageBox.Show("Kaydınız Kaydınız Güncelleştirimiştir");
                    doldur();
                    temizle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu.", ex.Message);
            }
        }

        private void KategoteriForm_Load(object sender, EventArgs e)
        {
            doldur();
            groupBox1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir = dataGridView1.CurrentCell.RowIndex;
            textBox2.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ara = textBox3.Text;
            var sonuc = baglan.Kategoriler.Where(x => x.Kategori_Ad.Contains(ara)).ToList();
            dataGridView1.DataSource = sonuc;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
