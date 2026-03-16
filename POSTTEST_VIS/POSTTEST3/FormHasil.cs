using System;
using System.Drawing;
using System.Windows.Forms;

namespace KartuKomunitas
{
    public partial class FormHasil : Form
    {
        public string nama;
        public string umur;
        public string telepon;
        public string alamat;
        public string tanggal;
        public string jk;
        public string hobby;
        public Image foto;

        public FormHasil()
        {
            InitializeComponent();
        }

        private void FormHasil_Load(object sender, EventArgs e)
        {
            lblNama.Text = nama;
            lblUmur.Text = umur;
            lblTelepon.Text = telepon;
            lblAlamat.Text = alamat;
            lblTanggal.Text = tanggal;
            lblJK.Text = jk;
            lblHobby.Text = hobby;

            pictureBoxHasil.Image = foto;
        }
    }
}