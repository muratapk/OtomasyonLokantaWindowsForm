﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masalar yeni=new Masalar();
            yeni.MdiParent = this;
            yeni.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            KategoteriForm yeni= new KategoteriForm();  
            yeni.MdiParent = this;
            yeni.Show();
        }

        private void ekleToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            RollerForm yeni = new RollerForm();
            yeni.MdiParent = this;
            yeni.Show();
        }
    }
}
