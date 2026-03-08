namespace Posttest2
{
    partial class Form1
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
            this.gbTambah = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.gbHapus = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHapus = new System.Windows.Forms.TextBox();
            this.btnHapus = new System.Windows.Forms.Button();
            this.listBuku = new System.Windows.Forms.ListBox();
            this.gbTambah.SuspendLayout();
            this.gbHapus.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTambah
            // 
            this.gbTambah.Controls.Add(this.btnTambah);
            this.gbTambah.Controls.Add(this.txtGenre);
            this.gbTambah.Controls.Add(this.label2);
            this.gbTambah.Controls.Add(this.txtJudul);
            this.gbTambah.Controls.Add(this.label1);
            this.gbTambah.Location = new System.Drawing.Point(93, 45);
            this.gbTambah.Name = "gbTambah";
            this.gbTambah.Size = new System.Drawing.Size(258, 146);
            this.gbTambah.TabIndex = 0;
            this.gbTambah.TabStop = false;
            this.gbTambah.Text = "Tambah Buku";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Judul Buku";
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(157, 28);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(100, 22);
            this.txtJudul.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Genre";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(157, 74);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGenre.TabIndex = 3;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(3, 110);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 4;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // gbHapus
            // 
            this.gbHapus.Controls.Add(this.btnHapus);
            this.gbHapus.Controls.Add(this.txtHapus);
            this.gbHapus.Controls.Add(this.label3);
            this.gbHapus.Location = new System.Drawing.Point(403, 58);
            this.gbHapus.Name = "gbHapus";
            this.gbHapus.Size = new System.Drawing.Size(205, 133);
            this.gbHapus.TabIndex = 1;
            this.gbHapus.TabStop = false;
            this.gbHapus.Text = "Hapus Buku";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Judul Buku";
            // 
            // txtHapus
            // 
            this.txtHapus.Location = new System.Drawing.Point(115, 22);
            this.txtHapus.Name = "txtHapus";
            this.txtHapus.Size = new System.Drawing.Size(100, 22);
            this.txtHapus.TabIndex = 1;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(10, 72);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 2;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // listBuku
            // 
            this.listBuku.FormattingEnabled = true;
            this.listBuku.ItemHeight = 16;
            this.listBuku.Location = new System.Drawing.Point(96, 225);
            this.listBuku.Name = "listBuku";
            this.listBuku.Size = new System.Drawing.Size(120, 84);
            this.listBuku.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBuku);
            this.Controls.Add(this.gbHapus);
            this.Controls.Add(this.gbTambah);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbTambah.ResumeLayout(false);
            this.gbTambah.PerformLayout();
            this.gbHapus.ResumeLayout(false);
            this.gbHapus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTambah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.GroupBox gbHapus;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.TextBox txtHapus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBuku;
    }
}

