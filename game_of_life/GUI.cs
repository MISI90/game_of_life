using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace game_of_life {
    class GUI : game_of_life.IGUI {
        PictureBox plansza;
        Graphics rysunek;
        SolidBrush brush = new SolidBrush(Color.Black);
        int wielkoscKomorki;
        bool rysujKrawedzie;
        /// <summary>
        /// </summary>
        /// <param name="p">Plansza na której będziemy rysować</param>
        /// <param name="w">Wielkość pojedynczej komórki</param>
        /// <param name="r">Rysowanie krawędzi oddzielających komórki</param>
        public GUI(PictureBox p, int w, bool r) {
            this.plansza = p;
            this.wielkoscKomorki = w;
            this.rysujKrawedzie = r;
        }

        public void rysujKomorki(bool[][] komorki) {
            for (int i = 0; i < komorki.Length; i++) {
                for (int j = 0; j < komorki[i].Length; j++) {
                    if (komorki[i][j]) {
                        this.brush.Color = Color.Black;
                    } else {
                        this.brush.Color = Color.White;
                    }
                    rysunek.FillRectangle(brush, i * this.wielkoscKomorki + 1, j * this.wielkoscKomorki + 1, this.wielkoscKomorki - 1, this.wielkoscKomorki - 1);
                }
            }
            plansza.Refresh();
        }

        public bool[][] pobierzKomorki() {
            bool[][] a = new bool[0][];
            
            
            
            return a;
        
        }
    }
}
