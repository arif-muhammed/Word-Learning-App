using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class Form1 : Form
    {
        private List<SozlukKelime> _sozluk;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboSozluk.Items.Clear();
            comboSozluk.Items.Add("Lütfen bir sözlük seçin..."); 
            comboSozluk.SelectedIndex = 0;

            var files = Directory.GetFiles(Application.StartupPath, "*.txt");
            var names = files.Select(f => Path.GetFileNameWithoutExtension(f)).ToArray();

            if (names.Length > 0)
            {
                comboSozluk.Items.AddRange(names);
                btnYukle.Enabled = true;
            }
            else
            {
                btnYukle.Enabled = false;
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            if (comboSozluk.SelectedIndex <= 0) 
            {
                MessageBox.Show("Lütfen geçerli bir sözlük seçin.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ad = comboSozluk.SelectedItem + ".txt";
            var lines = File.ReadAllLines(Path.Combine(Application.StartupPath, ad));

            _sozluk = lines
                .Select(l => l.Split('\t'))
                .Where(p => p.Length >= 2)
                .Select(p => new SozlukKelime(p[0].Trim(), p[1].Trim()))
                .ToList();

            btnBaslat.Enabled = true;
            MessageBox.Show($"{_sozluk.Count} kelime başarıyla yüklendi.",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            var sinav = new SinavForm(_sozluk);
            sinav.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}




