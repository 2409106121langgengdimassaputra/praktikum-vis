namespace KartuKomunitas
{
    partial class FormCetak
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
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.Label();
            this.txtTelepon = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textUmur = new System.Windows.Forms.TextBox();
            this.textTelepon = new System.Windows.Forms.TextBox();
            this.textAlamat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbLaki = new System.Windows.Forms.RadioButton();
            this.rbPerempuan = new System.Windows.Forms.RadioButton();
            this.groupBoxHobby = new System.Windows.Forms.GroupBox();
            this.cbGaming = new System.Windows.Forms.CheckBox();
            this.cbMusik = new System.Windows.Forms.CheckBox();
            this.cbMembaca = new System.Windows.Forms.CheckBox();
            this.cbTraveling = new System.Windows.Forms.CheckBox();
            this.cbOlahraga = new System.Windows.Forms.CheckBox();
            this.cbMemasak = new System.Windows.Forms.CheckBox();
            this.cbFotografi = new System.Windows.Forms.CheckBox();
            this.cbMenulis = new System.Windows.Forms.CheckBox();
            this.cbCoding = new System.Windows.Forms.CheckBox();
            this.cbNonton = new System.Windows.Forms.CheckBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.btnCetak = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxHobby.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(46, 12);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(227, 127);
            this.pictureBoxFoto.TabIndex = 0;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(46, 154);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse Foto";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtNama
            // 
            this.txtNama.AutoSize = true;
            this.txtNama.Location = new System.Drawing.Point(46, 217);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(44, 16);
            this.txtNama.TabIndex = 2;
            this.txtNama.Text = "Nama";
            // 
            // txtUmur
            // 
            this.txtUmur.AutoSize = true;
            this.txtUmur.Location = new System.Drawing.Point(46, 254);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(39, 16);
            this.txtUmur.TabIndex = 3;
            this.txtUmur.Text = "Umur";
            // 
            // txtTelepon
            // 
            this.txtTelepon.AutoSize = true;
            this.txtTelepon.Location = new System.Drawing.Point(46, 290);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(102, 16);
            this.txtTelepon.TabIndex = 4;
            this.txtTelepon.Text = "Nomor Telepon";
            // 
            // txtAlamat
            // 
            this.txtAlamat.AutoSize = true;
            this.txtAlamat.Location = new System.Drawing.Point(46, 324);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(49, 16);
            this.txtAlamat.TabIndex = 5;
            this.txtAlamat.Text = "Alamat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tanggal Lahir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Jenis Kelamin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(46, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hobby";
            // 
            // textNama
            // 
            this.textNama.Location = new System.Drawing.Point(200, 210);
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(100, 22);
            this.textNama.TabIndex = 9;
            this.textNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            // 
            // textUmur
            // 
            this.textUmur.Location = new System.Drawing.Point(200, 247);
            this.textUmur.Name = "textUmur";
            this.textUmur.Size = new System.Drawing.Size(100, 22);
            this.textUmur.TabIndex = 10;
            this.textUmur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUmur_KeyPress);
            // 
            // textTelepon
            // 
            this.textTelepon.Location = new System.Drawing.Point(200, 283);
            this.textTelepon.Name = "textTelepon";
            this.textTelepon.Size = new System.Drawing.Size(100, 22);
            this.textTelepon.TabIndex = 11;
            this.textTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelepon_KeyPress);
            // 
            // textAlamat
            // 
            this.textAlamat.Location = new System.Drawing.Point(200, 324);
            this.textAlamat.Name = "textAlamat";
            this.textAlamat.Size = new System.Drawing.Size(100, 22);
            this.textAlamat.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPerempuan);
            this.groupBox1.Controls.Add(this.rbLaki);
            this.groupBox1.Location = new System.Drawing.Point(362, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 126);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jenis Kelamin";
            // 
            // rbLaki
            // 
            this.rbLaki.AutoSize = true;
            this.rbLaki.Location = new System.Drawing.Point(7, 36);
            this.rbLaki.Name = "rbLaki";
            this.rbLaki.Size = new System.Drawing.Size(82, 20);
            this.rbLaki.TabIndex = 0;
            this.rbLaki.TabStop = true;
            this.rbLaki.Text = "Laki-Laki";
            this.rbLaki.UseVisualStyleBackColor = true;
            // 
            // rbPerempuan
            // 
            this.rbPerempuan.AutoSize = true;
            this.rbPerempuan.Location = new System.Drawing.Point(7, 62);
            this.rbPerempuan.Name = "rbPerempuan";
            this.rbPerempuan.Size = new System.Drawing.Size(98, 20);
            this.rbPerempuan.TabIndex = 1;
            this.rbPerempuan.TabStop = true;
            this.rbPerempuan.Text = "Perempuan";
            this.rbPerempuan.UseVisualStyleBackColor = true;
            // 
            // groupBoxHobby
            // 
            this.groupBoxHobby.Controls.Add(this.cbNonton);
            this.groupBoxHobby.Controls.Add(this.cbCoding);
            this.groupBoxHobby.Controls.Add(this.cbMenulis);
            this.groupBoxHobby.Controls.Add(this.cbFotografi);
            this.groupBoxHobby.Controls.Add(this.cbMemasak);
            this.groupBoxHobby.Controls.Add(this.cbOlahraga);
            this.groupBoxHobby.Controls.Add(this.cbTraveling);
            this.groupBoxHobby.Controls.Add(this.cbMembaca);
            this.groupBoxHobby.Controls.Add(this.cbMusik);
            this.groupBoxHobby.Controls.Add(this.cbGaming);
            this.groupBoxHobby.Location = new System.Drawing.Point(362, 163);
            this.groupBoxHobby.Name = "groupBoxHobby";
            this.groupBoxHobby.Size = new System.Drawing.Size(228, 275);
            this.groupBoxHobby.TabIndex = 14;
            this.groupBoxHobby.TabStop = false;
            this.groupBoxHobby.Text = "Hobby";
            // 
            // cbGaming
            // 
            this.cbGaming.AutoSize = true;
            this.cbGaming.Location = new System.Drawing.Point(10, 30);
            this.cbGaming.Name = "cbGaming";
            this.cbGaming.Size = new System.Drawing.Size(76, 20);
            this.cbGaming.TabIndex = 0;
            this.cbGaming.Text = "Gaming";
            this.cbGaming.UseVisualStyleBackColor = true;
            // 
            // cbMusik
            // 
            this.cbMusik.AutoSize = true;
            this.cbMusik.Location = new System.Drawing.Point(10, 56);
            this.cbMusik.Name = "cbMusik";
            this.cbMusik.Size = new System.Drawing.Size(64, 20);
            this.cbMusik.TabIndex = 2;
            this.cbMusik.Text = "Musik";
            this.cbMusik.UseVisualStyleBackColor = true;
            // 
            // cbMembaca
            // 
            this.cbMembaca.AutoSize = true;
            this.cbMembaca.Location = new System.Drawing.Point(10, 85);
            this.cbMembaca.Name = "cbMembaca";
            this.cbMembaca.Size = new System.Drawing.Size(90, 20);
            this.cbMembaca.TabIndex = 4;
            this.cbMembaca.Text = "Membaca";
            this.cbMembaca.UseVisualStyleBackColor = true;
            // 
            // cbTraveling
            // 
            this.cbTraveling.AutoSize = true;
            this.cbTraveling.Location = new System.Drawing.Point(10, 137);
            this.cbTraveling.Name = "cbTraveling";
            this.cbTraveling.Size = new System.Drawing.Size(86, 20);
            this.cbTraveling.TabIndex = 6;
            this.cbTraveling.Text = "Traveling";
            this.cbTraveling.UseVisualStyleBackColor = true;
            // 
            // cbOlahraga
            // 
            this.cbOlahraga.AutoSize = true;
            this.cbOlahraga.Location = new System.Drawing.Point(10, 111);
            this.cbOlahraga.Name = "cbOlahraga";
            this.cbOlahraga.Size = new System.Drawing.Size(85, 20);
            this.cbOlahraga.TabIndex = 8;
            this.cbOlahraga.Text = "Olahraga";
            this.cbOlahraga.UseVisualStyleBackColor = true;
            // 
            // cbMemasak
            // 
            this.cbMemasak.AutoSize = true;
            this.cbMemasak.Location = new System.Drawing.Point(10, 163);
            this.cbMemasak.Name = "cbMemasak";
            this.cbMemasak.Size = new System.Drawing.Size(89, 20);
            this.cbMemasak.TabIndex = 10;
            this.cbMemasak.Text = "Memasak";
            this.cbMemasak.UseVisualStyleBackColor = true;
            // 
            // cbFotografi
            // 
            this.cbFotografi.AutoSize = true;
            this.cbFotografi.Location = new System.Drawing.Point(10, 186);
            this.cbFotografi.Name = "cbFotografi";
            this.cbFotografi.Size = new System.Drawing.Size(82, 20);
            this.cbFotografi.TabIndex = 12;
            this.cbFotografi.Text = "Fotografi";
            this.cbFotografi.UseVisualStyleBackColor = true;
            // 
            // cbMenulis
            // 
            this.cbMenulis.AutoSize = true;
            this.cbMenulis.Location = new System.Drawing.Point(10, 212);
            this.cbMenulis.Name = "cbMenulis";
            this.cbMenulis.Size = new System.Drawing.Size(75, 20);
            this.cbMenulis.TabIndex = 14;
            this.cbMenulis.Text = "Menulis";
            this.cbMenulis.UseVisualStyleBackColor = true;
            // 
            // cbCoding
            // 
            this.cbCoding.AutoSize = true;
            this.cbCoding.Location = new System.Drawing.Point(10, 233);
            this.cbCoding.Name = "cbCoding";
            this.cbCoding.Size = new System.Drawing.Size(72, 20);
            this.cbCoding.TabIndex = 16;
            this.cbCoding.Text = "Coding";
            this.cbCoding.UseVisualStyleBackColor = true;
            // 
            // cbNonton
            // 
            this.cbNonton.AutoSize = true;
            this.cbNonton.Location = new System.Drawing.Point(10, 255);
            this.cbNonton.Name = "cbNonton";
            this.cbNonton.Size = new System.Drawing.Size(72, 20);
            this.cbNonton.TabIndex = 18;
            this.cbNonton.Text = "Nonton";
            this.cbNonton.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.Location = new System.Drawing.Point(200, 359);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(138, 22);
            this.dtpTanggalLahir.TabIndex = 15;
            // 
            // btnCetak
            // 
            this.btnCetak.Location = new System.Drawing.Point(611, 145);
            this.btnCetak.Name = "btnCetak";
            this.btnCetak.Size = new System.Drawing.Size(155, 23);
            this.btnCetak.TabIndex = 16;
            this.btnCetak.Text = "Cetak Kartu";
            this.btnCetak.UseVisualStyleBackColor = true;
            this.btnCetak.Click += new System.EventHandler(this.btnCetak_Click);
            // 
            // FormCetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCetak);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.groupBoxHobby);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textAlamat);
            this.Controls.Add(this.textTelepon);
            this.Controls.Add(this.textUmur);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.pictureBoxFoto);
            this.Name = "FormCetak";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxHobby.ResumeLayout(false);
            this.groupBoxHobby.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label txtNama;
        private System.Windows.Forms.Label txtUmur;
        private System.Windows.Forms.Label txtTelepon;
        private System.Windows.Forms.Label txtAlamat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textUmur;
        private System.Windows.Forms.TextBox textTelepon;
        private System.Windows.Forms.TextBox textAlamat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPerempuan;
        private System.Windows.Forms.RadioButton rbLaki;
        private System.Windows.Forms.GroupBox groupBoxHobby;
        private System.Windows.Forms.CheckBox cbNonton;
        private System.Windows.Forms.CheckBox cbCoding;
        private System.Windows.Forms.CheckBox cbMenulis;
        private System.Windows.Forms.CheckBox cbFotografi;
        private System.Windows.Forms.CheckBox cbMemasak;
        private System.Windows.Forms.CheckBox cbOlahraga;
        private System.Windows.Forms.CheckBox cbTraveling;
        private System.Windows.Forms.CheckBox cbMembaca;
        private System.Windows.Forms.CheckBox cbMusik;
        private System.Windows.Forms.CheckBox cbGaming;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.Button btnCetak;
    }
}

