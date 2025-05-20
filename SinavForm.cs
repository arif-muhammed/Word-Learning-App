using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace odev2
{
    public partial class SinavForm : Form
    {
        private readonly List<Soru> _sorular;
        private int _currentIndex;
        private int _puan;
        private bool _ilkDeneme;

        public SinavForm(List<SozlukKelime> sozluk)
        {
            InitializeComponent();

            var rnd = new Random();
            _sorular = sozluk
                .OrderBy(_ => rnd.Next())
                .Select(k => new Soru(k, sozluk))
                .ToList();
        }

        private void SinavForm_Load(object sender, EventArgs e)
        {
            _currentIndex = 0;
            _puan = 0;
            _ilkDeneme = true;
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            btnA.BackColor = default;
            btnB.BackColor = default;
            btnC.BackColor = default;
            btnD.BackColor = default;

            var q = _sorular[_currentIndex];
            lblKelime.Text = q.Dogru.Kelime;
            var opts = q.Secenekler.ToArray();
            btnA.Text = opts[0].Anlam;
            btnB.Text = opts[1].Anlam;
            btnC.Text = opts[2].Anlam;
            btnD.Text = opts[3].Anlam;
            this.ActiveControl = null;

            lblScore.Text = $"Puan: {_puan}";
            lblProgress.Text = $"Soru {_currentIndex + 1} / {_sorular.Count}";
        }

        private void Option_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            var seç = btn.Text;
            var doğru = _sorular[_currentIndex].Dogru.Anlam;

            if (seç == doğru)
            {
                btn.BackColor = System.Drawing.Color.LightGreen;
                if (_ilkDeneme)
                    _puan += 10;

                var t = new Timer { Interval = 500 };
                t.Tick += (s, ev) =>
                {
                    t.Stop();
                    btn.BackColor = default;
                    _currentIndex++;
                    if (_currentIndex < _sorular.Count)
                    {
                        _ilkDeneme = true;
                        ShowQuestion();
                    }
                    else
                    {
                        int dogruSayisi = _puan / 10; 
                        int yanlisSayisi = _sorular.Count - dogruSayisi;

                        MessageBox.Show(
                            $"Sınav Tamamlandı!\n\n" +
                            $"Doğru Cevaplar: {dogruSayisi}\n" +
                            $"Yanlış Cevaplar: {yanlisSayisi}\n" +
                            $"Toplam Puan: {_puan}",
                            "Sonuç",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.Close();
                    }

                };
                t.Start();
            }
            else
            {
                btn.BackColor = System.Drawing.Color.LightCoral;
                _ilkDeneme = false;
            }
        }
    }
}
