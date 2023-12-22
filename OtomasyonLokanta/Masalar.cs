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
    public partial class Masalar : Form
    {
        public Masalar()
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
                int Id = Convert.ToInt16(textBox2.Text);
                var bul = baglan.Masalars.Find(Id);
                baglan.Masalars.Remove(bul);
                baglan.SaveChanges();
                MessageBox.Show("Kaydınız Silimiştir");
                doldur();
            }
            catch (Exception)
            {

                MessageBox.Show("Kaydınız Silinmiştir.");
            }
           
        }
    }
}
