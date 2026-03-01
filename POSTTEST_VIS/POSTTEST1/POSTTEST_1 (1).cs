using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double totalIP = 0;
        int jumlahSemester = 0;

        public Form1()
        {
            InitializeComponent();

            // langsung set di constructor
            txtIPKumulatif.ReadOnly = true;
            lblPredikat.Text = "";
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                double ip = Convert.ToDouble(txtIPSemester.Text);

                if (ip < 0 || ip > 4)
                {
                    MessageBox.Show("IP harus antara 0 - 4");
                    return;
                }

                totalIP += ip;
                jumlahSemester++;

                double ipk = totalIP / jumlahSemester;

                txtIPKumulatif.Text = ipk.ToString("0.00");

                if (ipk >= 2.00 && ipk <= 2.75)
                    lblPredikat.Text = "Cukup";
                else if (ipk >= 2.76 && ipk <= 3.00)
                    lblPredikat.Text = "Memuaskan";
                else if (ipk >= 3.01)
                    lblPredikat.Text = "Sangat Memuaskan";
                else
                    lblPredikat.Text = "";

                txtIPSemester.Clear();
                txtIPSemester.Focus();
            }
            catch
            {
                MessageBox.Show("Masukkan angka yang valid!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            totalIP = 0;
            jumlahSemester = 0;

            txtIPSemester.Clear();
            txtIPKumulatif.Clear();
            lblPredikat.Text = "";
        }
    }
}