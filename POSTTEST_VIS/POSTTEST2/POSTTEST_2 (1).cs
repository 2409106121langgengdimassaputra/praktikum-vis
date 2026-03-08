using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Posttest2
{
    public partial class Form1 : Form
    {
        // Array untuk menyimpan buku
        string[] daftarBuku = new string[100];
        int jumlahBuku = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // PROCEDURE untuk menambah buku
        void TambahData(string judul, string genre)
        {
            daftarBuku[jumlahBuku] = judul + " (" + genre + ")";
            jumlahBuku++;

        }

        // FUNCTION untuk mencari buku
        int CariBuku(string judul)
        {
            for (int i = 0; i < jumlahBuku; i++)
            {
                if (daftarBuku[i].ToLower().StartsWith(judul.ToLower()))
                {
                    return i;
                }
            }

            return -1;
        }

        // PROCEDURE untuk menampilkan buku di ListBox
        void TampilkanBuku()
        {
            listBuku.Items.Clear();

            for (int i = 0; i < jumlahBuku; i++)
            {
                listBuku.Items.Add(daftarBuku[i]);
            }
        }

        // Saat form pertama dibuka
        private void Form1_Load(object sender, EventArgs e)
        {
            TambahData("Harry Potter", "Fantasi");
            TambahData("Sherlock Holmes", "Misteri");

            TampilkanBuku();
        }

        // Tombol Tambah
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtJudul.Text == "" ||txtGenre.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong");
                return;

            }

            TambahData(txtJudul.Text, txtGenre.Text);

            TampilkanBuku();

            txtJudul.Clear();
            txtGenre.Clear();
        }

        // Tombol Hapus
        private void btnHapus_Click(object sender, EventArgs e)
        {
            int index = CariBuku(txtHapus.Text);

            if (index == -1)
            {
                MessageBox.Show("Buku tidak ditemukan");
            }
            else
            {
                for (int i = index; i < jumlahBuku - 1; i++)
                {
                    daftarBuku[i] = daftarBuku[i + 1];
                }

                jumlahBuku--;

                TampilkanBuku();

                MessageBox.Show("Buku berhasil dihapus");
            }
        }
    }
}