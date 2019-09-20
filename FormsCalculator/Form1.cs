using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var a = int.Parse(tb_a.Text);
            var b = int.Parse(tb_b.Text);

            lb_hasil.Items.Clear();
            lb_hasil.Items.Add(string.Format("Hasil Penambahan: {0} + {1} = {2}", a, b, tambah(a, b)));
            lb_hasil.Items.Add(string.Format("Hasil Pengurangan: {0} - {1} = {2}", a, b, kurang(a, b)));
            lb_hasil.Items.Add(string.Format("Hasil Perkalian: {0} X {1} = {2}", a, b, kali(a, b)));
            lb_hasil.Items.Add(string.Format("Hasil Pembagian: {0} : {1} = {2}", a, b, bagi(a, b)));
        }

        static int tambah(int a, int b)
        {
            return a + b;
        }

        static int kurang(int a, int b)
        {
            return a - b;
        }

        static int kali(int a, int b)
        {
            return a * b;
        }

        static int bagi(int a, int b)
        {
            return a / b;
        }
    }
}
