using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonLokanta
{
    public partial class RollerForm : Form
    {
        public RollerForm()
        {
            InitializeComponent();
        }
        LokantaDbEntities baglan=new LokantaDbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                    Masalars masabos = new Masalars();
                    masabos.Masa_Ad = textBox1.Text;
                    masabos.Masa_Durum = checkBox1.Checked;
                    baglan.Masalars.Add(masabos);
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
        void doldur()
        {
            var listem = baglan.Masalars.ToList();
            dataGridView1.DataSource = listem;
        }

        private void Masalar_Load(object sender, EventArgs e)
        {
            doldur();
            groupBox1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int satir=dataGridView1.CurrentCell.RowIndex;
            textBox2.Text = dataGridView1.Rows[satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[satir].Cells[1].Value.ToString();
            checkBox1.Checked =Convert.ToBoolean( dataGridView1.Rows[satir].Cells[2].Value);
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
                    DialogResult cevap=MessageBox.Show("Bu Kaydı Silmek İstiyor musunuz?","Dikkat Kayıt Silme",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (cevap == DialogResult.Yes)
                    {
                        int Id = Convert.ToInt16(textBox2.Text);
                        var bul = baglan.Masalars.Find(Id);
                        baglan.Masalars.Remove(bul);
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
                    int Id = Convert.ToInt16(textBox2.Text);
                    var bul = baglan.Masalars.Find(Id);
                    bul.Masa_Ad = textBox1.Text;
                    bul.Masa_Durum = checkBox1.Checked;

                    baglan.SaveChanges();
                    MessageBox.Show("Kaydınız Kaydınız Güncelleştirimiştir");
                    doldur();
                    temizle();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata Oluştu.",ex.Message);
            }
        }
        void temizle()
        {
            textBox1.Text= string.Empty;
            checkBox1.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ara = textBox3.Text;
            var sonuc=baglan.Masalars.Where(x=>x.Masa_Ad.Contains(ara)).ToList();
            dataGridView1.DataSource = sonuc;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
