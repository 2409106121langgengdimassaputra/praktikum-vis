using System;
using System.Linq;
using System.Windows.Forms;

namespace KartuKomunitas
{
    public partial class FormCetak : Form
    {
        public FormCetak()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBoxFoto.ImageLocation = open.FileName;
            }
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (txtNama.Text == "" ||
                txtUmur.Text == "" ||
                txtTelepon.Text == "" ||
                txtAlamat.Text == "" ||
                pictureBoxFoto.Image == null)
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            if (!rbLaki.Checked && !rbPerempuan.Checked)
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            string hobby = "";

            foreach (CheckBox cb in groupBoxHobby.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    hobby += cb.Text + ", ";
                }
            }

            if (hobby == "")
            {
                MessageBox.Show("Inputan tidak boleh kosong");
                return;
            }

            FormHasil hasil = new FormHasil();

            hasil.nama = txtNama.Text;
            hasil.umur = txtUmur.Text;
            hasil.telepon = txtTelepon.Text;
            hasil.alamat = txtAlamat.Text;
            hasil.tanggal = dtpTanggalLahir.Value.ToShortDateString();
            hasil.hobby = hobby;

            if (rbLaki.Checked)
                hasil.jk = "Laki-Laki";
            else
                hasil.jk = "Perempuan";

            hasil.foto = pictureBoxFoto.Image;

            hasil.Show();
        }

        private void txtUmur_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}