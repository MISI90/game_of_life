using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace game_of_life {
    public partial class Form1 : Form {
        Graphics rysunek;
        Pen pen = new Pen(Color.Black, 1);
        SolidBrush brush = new SolidBrush(Color.White);
        Point ostatni = new Point();
        int WIELKOSC_POLA = 1;

        public Form1() {
            InitializeComponent();
            inicjalizujRysunek();
        }

        private void inicjalizujRysunek() {
            WIELKOSC_POLA = trackBar_wielkosc_komorki.Value;
            textBox_wielkosc_komorki.Text = WIELKOSC_POLA.ToString();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            rysunek = Graphics.FromImage(pictureBox1.Image);
            brush.Color = Color.White;
            rysunek.FillRectangle(brush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            if (WIELKOSC_POLA > 5) {
                for (int i = 0; i < pictureBox1.Width / WIELKOSC_POLA; i++) {
                    rysunek.DrawLine(new Pen(Color.Gray, 1), 0, i * WIELKOSC_POLA, pictureBox1.Height, i * WIELKOSC_POLA);
                    rysunek.DrawLine(new Pen(Color.Gray, 1), i * WIELKOSC_POLA, 0, i * WIELKOSC_POLA, pictureBox1.Width);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            MouseEventArgs mysz = (MouseEventArgs)e;
            rysujPunkt(mysz.X, mysz.Y, false);
        }

        private void trackBar_wielkosc_komorki_ValueChanged(object sender, EventArgs e) {
            inicjalizujRysunek();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                rysujPunkt(e.X, e.Y, true);
            }
        }

        private void rysujPunkt(int x, int y, bool move) {
            if (ostatni.X != x - x % WIELKOSC_POLA || ostatni.Y != y - y % WIELKOSC_POLA) {
                Bitmap bmp = (Bitmap)pictureBox1.Image;
                Color kolor_piksela = bmp.GetPixel((x + 1 - x % WIELKOSC_POLA), (y + 1 - y % WIELKOSC_POLA));
                if (kolor_piksela.R == 0 && kolor_piksela.G == 0 && kolor_piksela.B == 0) {
                    brush.Color = Color.White;
                    rysunek.FillRectangle(brush, (x + 1 - x % WIELKOSC_POLA), (y + 1 - y % WIELKOSC_POLA), WIELKOSC_POLA - 1, WIELKOSC_POLA - 1);
                } else {
                    brush.Color = Color.Black;
                    rysunek.FillRectangle(brush, (x + 1 - x % WIELKOSC_POLA), (y + 1 - y % WIELKOSC_POLA), WIELKOSC_POLA - 1, WIELKOSC_POLA - 1);
                }
                if (move) {
                    ostatni.X = x - x % WIELKOSC_POLA;
                    ostatni.Y = y - y % WIELKOSC_POLA;
                }
                pictureBox1.Refresh();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            timer_gra.Enabled = !timer_gra.Enabled;
            if (button_start.Text == "Start") {
                button_start.Text = "Stop";
                button_start.ForeColor = Color.FromArgb(192, 0, 0);
            } else {
                button_start.Text = "Start";
                button_start.ForeColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void trackBar_szybkosc_animacji_Scroll(object sender, EventArgs e) {
            textBox_szybkosc_animacji.Text = (trackBar_szybkosc_animacji.Value * 50).ToString();
            timer_gra.Interval = trackBar_szybkosc_animacji.Value * 50;
        }

        private void graj() {
            int w = pictureBox1.Width / WIELKOSC_POLA;
            int h = pictureBox1.Height / WIELKOSC_POLA;
            bool[][] komorki = new bool[h][];

            Bitmap bmp = (Bitmap)pictureBox1.Image;
            for (int i = 0; i < h; i++) {
                komorki[i] = new bool[w];
                for (int j = 0; j < w; j++) {
                    Color kolor_piksela = bmp.GetPixel(i * WIELKOSC_POLA + 1, j * WIELKOSC_POLA + 1);
                    if (kolor_piksela.R == 0 && kolor_piksela.G == 0 && kolor_piksela.B == 0) {
                        komorki[i][j] = true;
                    } else {
                        komorki[i][j] = false;
                    }
                }
            }
            string regula_przezycia = "";
            foreach (int item in checkedListBox_regula_przezycia.CheckedIndices) {
                regula_przezycia = regula_przezycia + checkedListBox_regula_przezycia.Items[item];
            }
            string regula_narodzin = "";
            foreach (int item in checkedListBox_regula_narodzin.CheckedIndices) {
                regula_narodzin = regula_narodzin + checkedListBox_regula_narodzin.Items[item];
            }


            Game game = new Game(komorki, regula_przezycia, regula_narodzin, checkBox_nieskonczona_plansza.Checked);
            
            bool[][] komorkiNowe = game.getKomorkiNowe();
            for (int i = 0; i < komorkiNowe.Length; i++) {
                for (int j = 0; j < komorkiNowe[i].Length; j++) {
                    if (komorkiNowe[i][j]) {
                        brush.Color = Color.Black;
                    } else {
                        brush.Color = Color.White;
                    }
                    rysunek.FillRectangle(brush, i * WIELKOSC_POLA + 1, j * WIELKOSC_POLA + 1, WIELKOSC_POLA - 1, WIELKOSC_POLA - 1);
                }
            }
            pictureBox1.Refresh();
            textBox_stat_zywe_komorki.Text = game.getZyweKomorki().ToString();
            textBox_stat_martwe_komorki.Text = game.getMartweKomorki().ToString();
        }

        private void timer_gra_Tick(object sender, EventArgs e) {
            graj();
        }

        private void listBox_reguly_SelectedValueChanged(object sender, EventArgs e) {
            string wybrane = listBox_reguly.SelectedItem.ToString();
            char[] separator = new char[3] {'(', '/', ')'};
            string regula_przezycia = wybrane.Split(separator)[1];
            string regula_narodzin = wybrane.Split(separator)[2];
            for (int i = 0; i < 8; i++) {
                if (regula_przezycia.Contains(i.ToString())) {
                    checkedListBox_regula_przezycia.SetItemChecked(i, true);
                } else {
                    checkedListBox_regula_przezycia.SetItemChecked(i, false);
                }
                if (regula_narodzin.Contains(i.ToString())) {
                    checkedListBox_regula_narodzin.SetItemChecked(i, true);
                } else {
                    checkedListBox_regula_narodzin.SetItemChecked(i, false);
                }
            }

        }

        private void button_krok_Click(object sender, EventArgs e) {
            graj();
        }

        private void button_losuj_komorki_Click(object sender, EventArgs e) {

        }
    }
}
