namespace KartuKomunitas
{
    partial class FormHasil
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
            this.pictureBoxHasil = new System.Windows.Forms.PictureBox();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblUmur = new System.Windows.Forms.Label();
            this.lblTelepon = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblJK = new System.Windows.Forms.Label();
            this.lblTanggal = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHasil)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHasil
            // 
            this.pictureBoxHasil.Location = new System.Drawing.Point(43, 32);
            this.pictureBoxHasil.Name = "pictureBoxHasil";
            this.pictureBoxHasil.Size = new System.Drawing.Size(220, 128);
            this.pictureBoxHasil.TabIndex = 0;
            this.pictureBoxHasil.TabStop = false;
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(40, 194);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(44, 16);
            this.lblNama.TabIndex = 1;
            this.lblNama.Text = "label1";
            // 
            // lblUmur
            // 
            this.lblUmur.AutoSize = true;
            this.lblUmur.Location = new System.Drawing.Point(40, 225);
            this.lblUmur.Name = "lblUmur";
            this.lblUmur.Size = new System.Drawing.Size(44, 16);
            this.lblUmur.TabIndex = 2;
            this.lblUmur.Text = "label2";
            // 
            // lblTelepon
            // 
            this.lblTelepon.AutoSize = true;
            this.lblTelepon.Location = new System.Drawing.Point(40, 257);
            this.lblTelepon.Name = "lblTelepon";
            this.lblTelepon.Size = new System.Drawing.Size(44, 16);
            this.lblTelepon.TabIndex = 3;
            this.lblTelepon.Text = "label3";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(40, 289);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(44, 16);
            this.lblAlamat.TabIndex = 4;
            this.lblAlamat.Text = "label4";
            // 
            // lblJK
            // 
            this.lblJK.AutoSize = true;
            this.lblJK.Location = new System.Drawing.Point(40, 320);
            this.lblJK.Name = "lblJK";
            this.lblJK.Size = new System.Drawing.Size(44, 16);
            this.lblJK.TabIndex = 5;
            this.lblJK.Text = "label5";
            // 
            // lblTanggal
            // 
            this.lblTanggal.AutoSize = true;
            this.lblTanggal.Location = new System.Drawing.Point(40, 353);
            this.lblTanggal.Name = "lblTanggal";
            this.lblTanggal.Size = new System.Drawing.Size(44, 16);
            this.lblTanggal.TabIndex = 6;
            this.lblTanggal.Text = "label6";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Location = new System.Drawing.Point(40, 386);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(44, 16);
            this.lblHobby.TabIndex = 7;
            this.lblHobby.Text = "label7";
            // 
            // FormHasil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.lblJK);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblTelepon);
            this.Controls.Add(this.lblUmur);
            this.Controls.Add(this.lblNama);
            this.Controls.Add(this.pictureBoxHasil);
            this.Name = "FormHasil";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormHasil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHasil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHasil;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblUmur;
        private System.Windows.Forms.Label lblTelepon;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblJK;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.Label lblHobby;
    }
}