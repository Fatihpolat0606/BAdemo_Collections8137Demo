namespace Collections8137Demo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bKaydet = new System.Windows.Forms.Button();
            this.tbNotOrtalamasi = new System.Windows.Forms.TextBox();
            this.cbMezun = new System.Windows.Forms.CheckBox();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.rbKadin = new System.Windows.Forms.RadioButton();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.tbSoyadi = new System.Windows.Forms.TextBox();
            this.tbAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbSil = new System.Windows.Forms.LinkLabel();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.nudIdGuncelle = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.bGuncelle = new System.Windows.Forms.Button();
            this.tbNotOrtalamasiGuncelle = new System.Windows.Forms.TextBox();
            this.cbMezunGuncelle = new System.Windows.Forms.CheckBox();
            this.rbErkekGuncelle = new System.Windows.Forms.RadioButton();
            this.rbKadinGuncelle = new System.Windows.Forms.RadioButton();
            this.dtpDogumTarihiGuncelle = new System.Windows.Forms.DateTimePicker();
            this.tbSoyadiGuncelle = new System.Windows.Forms.TextBox();
            this.tbAdiGuncelle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbGetir = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOgrenciler);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Listesi";
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Location = new System.Drawing.Point(6, 22);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.RowTemplate.Height = 25;
            this.dgvOgrenciler.Size = new System.Drawing.Size(764, 166);
            this.dgvOgrenciler.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bKaydet);
            this.groupBox2.Controls.Add(this.tbNotOrtalamasi);
            this.groupBox2.Controls.Add(this.cbMezun);
            this.groupBox2.Controls.Add(this.rbErkek);
            this.groupBox2.Controls.Add(this.rbKadin);
            this.groupBox2.Controls.Add(this.dtpDogumTarihi);
            this.groupBox2.Controls.Add(this.tbSoyadi);
            this.groupBox2.Controls.Add(this.tbAdi);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(18, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Öğrenci";
            // 
            // bKaydet
            // 
            this.bKaydet.Location = new System.Drawing.Point(212, 231);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(75, 23);
            this.bKaydet.TabIndex = 2;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.UseVisualStyleBackColor = true;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // tbNotOrtalamasi
            // 
            this.tbNotOrtalamasi.Location = new System.Drawing.Point(108, 187);
            this.tbNotOrtalamasi.Name = "tbNotOrtalamasi";
            this.tbNotOrtalamasi.Size = new System.Drawing.Size(179, 23);
            this.tbNotOrtalamasi.TabIndex = 3;
            // 
            // cbMezun
            // 
            this.cbMezun.AutoSize = true;
            this.cbMezun.Checked = true;
            this.cbMezun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMezun.Location = new System.Drawing.Point(108, 160);
            this.cbMezun.Name = "cbMezun";
            this.cbMezun.Size = new System.Drawing.Size(15, 14);
            this.cbMezun.TabIndex = 2;
            this.cbMezun.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(169, 123);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(53, 19);
            this.rbErkek.TabIndex = 2;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadin
            // 
            this.rbKadin.AutoSize = true;
            this.rbKadin.Checked = true;
            this.rbKadin.Location = new System.Drawing.Point(108, 123);
            this.rbKadin.Name = "rbKadin";
            this.rbKadin.Size = new System.Drawing.Size(55, 19);
            this.rbKadin.TabIndex = 2;
            this.rbKadin.TabStop = true;
            this.rbKadin.Text = "Kadın";
            this.rbKadin.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(108, 86);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(179, 23);
            this.dtpDogumTarihi.TabIndex = 2;
            // 
            // tbSoyadi
            // 
            this.tbSoyadi.Location = new System.Drawing.Point(108, 56);
            this.tbSoyadi.Name = "tbSoyadi";
            this.tbSoyadi.Size = new System.Drawing.Size(179, 23);
            this.tbSoyadi.TabIndex = 2;
            // 
            // tbAdi
            // 
            this.tbAdi.Location = new System.Drawing.Point(108, 22);
            this.tbAdi.Name = "tbAdi";
            this.tbAdi.Size = new System.Drawing.Size(179, 23);
            this.tbAdi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Not Ortalaması";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mezun";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cinsiyet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbGetir);
            this.groupBox3.Controls.Add(this.lbSil);
            this.groupBox3.Controls.Add(this.nudId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(317, 221);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(166, 261);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Öğrenci Silme";
            // 
            // lbSil
            // 
            this.lbSil.LinkColor = System.Drawing.Color.Red;
            this.lbSil.Location = new System.Drawing.Point(138, 50);
            this.lbSil.Name = "lbSil";
            this.lbSil.Size = new System.Drawing.Size(22, 23);
            this.lbSil.TabIndex = 5;
            this.lbSil.TabStop = true;
            this.lbSil.Text = "Sil";
            this.lbSil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSil_LinkClicked);
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(53, 19);
            this.nudId.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(107, 23);
            this.nudId.TabIndex = 4;
            this.nudId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Id";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.nudIdGuncelle);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.bGuncelle);
            this.groupBox4.Controls.Add(this.tbNotOrtalamasiGuncelle);
            this.groupBox4.Controls.Add(this.cbMezunGuncelle);
            this.groupBox4.Controls.Add(this.rbErkekGuncelle);
            this.groupBox4.Controls.Add(this.rbKadinGuncelle);
            this.groupBox4.Controls.Add(this.dtpDogumTarihiGuncelle);
            this.groupBox4.Controls.Add(this.tbSoyadiGuncelle);
            this.groupBox4.Controls.Add(this.tbAdiGuncelle);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Location = new System.Drawing.Point(489, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(293, 270);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Öğrenci Güncelle";
            // 
            // nudIdGuncelle
            // 
            this.nudIdGuncelle.Location = new System.Drawing.Point(108, 231);
            this.nudIdGuncelle.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudIdGuncelle.Name = "nudIdGuncelle";
            this.nudIdGuncelle.Size = new System.Drawing.Size(98, 23);
            this.nudIdGuncelle.TabIndex = 6;
            this.nudIdGuncelle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 233);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 15);
            this.label14.TabIndex = 5;
            this.label14.Text = "Id";
            // 
            // bGuncelle
            // 
            this.bGuncelle.Location = new System.Drawing.Point(212, 231);
            this.bGuncelle.Name = "bGuncelle";
            this.bGuncelle.Size = new System.Drawing.Size(75, 23);
            this.bGuncelle.TabIndex = 2;
            this.bGuncelle.Text = "Güncelle";
            this.bGuncelle.UseVisualStyleBackColor = true;
            this.bGuncelle.Click += new System.EventHandler(this.bGuncelle_Click);
            // 
            // tbNotOrtalamasiGuncelle
            // 
            this.tbNotOrtalamasiGuncelle.Location = new System.Drawing.Point(108, 187);
            this.tbNotOrtalamasiGuncelle.Name = "tbNotOrtalamasiGuncelle";
            this.tbNotOrtalamasiGuncelle.Size = new System.Drawing.Size(179, 23);
            this.tbNotOrtalamasiGuncelle.TabIndex = 3;
            // 
            // cbMezunGuncelle
            // 
            this.cbMezunGuncelle.AutoSize = true;
            this.cbMezunGuncelle.Checked = true;
            this.cbMezunGuncelle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMezunGuncelle.Location = new System.Drawing.Point(108, 160);
            this.cbMezunGuncelle.Name = "cbMezunGuncelle";
            this.cbMezunGuncelle.Size = new System.Drawing.Size(15, 14);
            this.cbMezunGuncelle.TabIndex = 2;
            this.cbMezunGuncelle.UseVisualStyleBackColor = true;
            // 
            // rbErkekGuncelle
            // 
            this.rbErkekGuncelle.AutoSize = true;
            this.rbErkekGuncelle.Location = new System.Drawing.Point(169, 123);
            this.rbErkekGuncelle.Name = "rbErkekGuncelle";
            this.rbErkekGuncelle.Size = new System.Drawing.Size(53, 19);
            this.rbErkekGuncelle.TabIndex = 2;
            this.rbErkekGuncelle.Text = "Erkek";
            this.rbErkekGuncelle.UseVisualStyleBackColor = true;
            // 
            // rbKadinGuncelle
            // 
            this.rbKadinGuncelle.AutoSize = true;
            this.rbKadinGuncelle.Checked = true;
            this.rbKadinGuncelle.Location = new System.Drawing.Point(108, 123);
            this.rbKadinGuncelle.Name = "rbKadinGuncelle";
            this.rbKadinGuncelle.Size = new System.Drawing.Size(55, 19);
            this.rbKadinGuncelle.TabIndex = 2;
            this.rbKadinGuncelle.TabStop = true;
            this.rbKadinGuncelle.Text = "Kadın";
            this.rbKadinGuncelle.UseVisualStyleBackColor = true;
            // 
            // dtpDogumTarihiGuncelle
            // 
            this.dtpDogumTarihiGuncelle.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihiGuncelle.Location = new System.Drawing.Point(108, 86);
            this.dtpDogumTarihiGuncelle.Name = "dtpDogumTarihiGuncelle";
            this.dtpDogumTarihiGuncelle.Size = new System.Drawing.Size(179, 23);
            this.dtpDogumTarihiGuncelle.TabIndex = 2;
            // 
            // tbSoyadiGuncelle
            // 
            this.tbSoyadiGuncelle.Location = new System.Drawing.Point(108, 56);
            this.tbSoyadiGuncelle.Name = "tbSoyadiGuncelle";
            this.tbSoyadiGuncelle.Size = new System.Drawing.Size(179, 23);
            this.tbSoyadiGuncelle.TabIndex = 2;
            // 
            // tbAdiGuncelle
            // 
            this.tbAdiGuncelle.Location = new System.Drawing.Point(108, 22);
            this.tbAdiGuncelle.Name = "tbAdiGuncelle";
            this.tbAdiGuncelle.Size = new System.Drawing.Size(179, 23);
            this.tbAdiGuncelle.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Not Ortalaması";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mezun";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Cinsiyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Doğum Tarihi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 2;
            this.label12.Text = "Soyadı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Adı";
            // 
            // lbGetir
            // 
            this.lbGetir.LinkColor = System.Drawing.Color.Red;
            this.lbGetir.Location = new System.Drawing.Point(6, 50);
            this.lbGetir.Name = "lbGetir";
            this.lbGetir.Size = new System.Drawing.Size(44, 23);
            this.lbGetir.TabIndex = 6;
            this.lbGetir.TabStop = true;
            this.lbGetir.Text = "Getir";
            this.lbGetir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbGetir_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Öğrenci App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdGuncelle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvOgrenciler;
        private GroupBox groupBox2;
        private CheckBox cbMezun;
        private RadioButton rbErkek;
        private RadioButton rbKadin;
        private DateTimePicker dtpDogumTarihi;
        private TextBox tbSoyadi;
        private TextBox tbAdi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button bKaydet;
        private TextBox tbNotOrtalamasi;
        private GroupBox groupBox3;
        private LinkLabel lbSil;
        private NumericUpDown nudId;
        private Label label7;
        private GroupBox groupBox4;
        private Button bGuncelle;
        private TextBox tbNotOrtalamasiGuncelle;
        private CheckBox cbMezunGuncelle;
        private RadioButton rbErkekGuncelle;
        private RadioButton rbKadinGuncelle;
        private DateTimePicker dtpDogumTarihiGuncelle;
        private TextBox tbSoyadiGuncelle;
        private TextBox tbAdiGuncelle;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private NumericUpDown nudIdGuncelle;
        private Label label14;
        private LinkLabel lbGetir;
    }
}