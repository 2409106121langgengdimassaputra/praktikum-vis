namespace WindowsFormsApp1
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
            this.lblIPSemester = new System.Windows.Forms.Label();
            this.lblIPKumulatif = new System.Windows.Forms.Label();
            this.lblPredikat = new System.Windows.Forms.Label();
            this.txtIPSemester = new System.Windows.Forms.TextBox();
            this.txtIPKumulatif = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIPSemester
            // 
            this.lblIPSemester.AutoSize = true;
            this.lblIPSemester.Location = new System.Drawing.Point(264, 122);
            this.lblIPSemester.Name = "lblIPSemester";
            this.lblIPSemester.Size = new System.Drawing.Size(80, 16);
            this.lblIPSemester.TabIndex = 0;
            this.lblIPSemester.Text = "IP Semester";
            // 
            // lblIPKumulatif
            // 
            this.lblIPKumulatif.AutoSize = true;
            this.lblIPKumulatif.Location = new System.Drawing.Point(264, 177);
            this.lblIPKumulatif.Name = "lblIPKumulatif";
            this.lblIPKumulatif.Size = new System.Drawing.Size(75, 16);
            this.lblIPKumulatif.TabIndex = 1;
            this.lblIPKumulatif.Text = "IP Kumulatif";
            // 
            // lblPredikat
            // 
            this.lblPredikat.AutoSize = true;
            this.lblPredikat.Location = new System.Drawing.Point(329, 208);
            this.lblPredikat.Name = "lblPredikat";
            this.lblPredikat.Size = new System.Drawing.Size(0, 16);
            this.lblPredikat.TabIndex = 2;
            // 
            // txtIPSemester
            // 
            this.txtIPSemester.Location = new System.Drawing.Point(350, 119);
            this.txtIPSemester.Name = "txtIPSemester";
            this.txtIPSemester.Size = new System.Drawing.Size(156, 22);
            this.txtIPSemester.TabIndex = 3;
            // 
            // txtIPKumulatif
            // 
            this.txtIPKumulatif.Location = new System.Drawing.Point(350, 176);
            this.txtIPKumulatif.Name = "txtIPKumulatif";
            this.txtIPKumulatif.Size = new System.Drawing.Size(156, 22);
            this.txtIPKumulatif.TabIndex = 4;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(350, 147);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(431, 147);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 469);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.txtIPKumulatif);
            this.Controls.Add(this.txtIPSemester);
            this.Controls.Add(this.lblPredikat);
            this.Controls.Add(this.lblIPKumulatif);
            this.Controls.Add(this.lblIPSemester);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIPSemester;
        private System.Windows.Forms.Label lblIPKumulatif;
        private System.Windows.Forms.Label lblPredikat;
        private System.Windows.Forms.TextBox txtIPSemester;
        private System.Windows.Forms.TextBox txtIPKumulatif;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnReset;
    }
}

