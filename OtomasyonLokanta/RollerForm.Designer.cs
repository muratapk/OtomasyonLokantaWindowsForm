namespace OtomasyonLokanta
{
    partial class RollerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_Ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masa_Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Siparislers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personellers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masa Ad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 22);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(70, 92);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Masa Durum";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(364, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Silme";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(474, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Düzeltme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(474, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Arama";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Masa_Ad,
            this.Masa_Durum,
            this.Siparislers,
            this.Personellers});
            this.dataGridView1.Location = new System.Drawing.Point(53, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 251);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Masa_Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Masa_Ad
            // 
            this.Masa_Ad.DataPropertyName = "Masa_Ad";
            this.Masa_Ad.HeaderText = "Masa Adı";
            this.Masa_Ad.MinimumWidth = 6;
            this.Masa_Ad.Name = "Masa_Ad";
            this.Masa_Ad.Width = 125;
            // 
            // Masa_Durum
            // 
            this.Masa_Durum.DataPropertyName = "Masa_Durum";
            this.Masa_Durum.HeaderText = "Masa Durum";
            this.Masa_Durum.MinimumWidth = 6;
            this.Masa_Durum.Name = "Masa_Durum";
            this.Masa_Durum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Masa_Durum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Masa_Durum.Width = 125;
            // 
            // Siparislers
            // 
            this.Siparislers.DataPropertyName = "Siparislers";
            this.Siparislers.HeaderText = "Siparislers";
            this.Siparislers.MinimumWidth = 6;
            this.Siparislers.Name = "Siparislers";
            this.Siparislers.Visible = false;
            this.Siparislers.Width = 125;
            // 
            // Personellers
            // 
            this.Personellers.DataPropertyName = "Personellers";
            this.Personellers.HeaderText = "Personellers";
            this.Personellers.MinimumWidth = 6;
            this.Personellers.Name = "Personellers";
            this.Personellers.Visible = false;
            this.Personellers.Width = 125;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(605, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "Bul";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(23, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(155, 22);
            this.textBox3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Masa Adını Giriniz";
            // 
            // RollerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "RollerForm";
            this.Text = "Roller";
            this.Load += new System.EventHandler(this.Masalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masa_Ad;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Masa_Durum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Siparislers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personellers;
    }
}