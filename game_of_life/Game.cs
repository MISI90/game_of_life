using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace game_of_life {
    class Game {
        bool[][] komorki;
        bool[][] komorkiNowe;
        bool nieskonczona_plansza;
        string b, s;
        int zyweKomorki, martweKomorki;
        public Game(bool[][] punkty, string b, string s, bool nieskonczona_plansza) {
            this.komorki = punkty;
            this.komorkiNowe = new bool[punkty.Length][];
            for (int i = 0; i < punkty.Length; i++) {
                komorkiNowe[i] = new bool[punkty[i].Length];
            }
            this.b = b;
            this.s = s;
            this.zyweKomorki = 0;
            this.martweKomorki = 0;
            this.nieskonczona_plansza = nieskonczona_plansza;
            graj();
        }

        private void graj() {
            for (int i = 0; i < this.komorki.Length; i++) {
                for (int j = 0; j < this.komorki[i].Length; j++) {
                    string zywiSasiedzi = iloscZywychSasiadow(i, j);
                    if (komorki[i][j]) { //punkt zywy
                        if (this.b.Contains(zywiSasiedzi)) {                        //ilosc zywych sasiadow rowna sie liczbie dozwolonych zywych sasiadow
                            this.komorkiNowe[i][j] = this.komorki[i][j];                 //komorka ma odpowiednia ilosc sasiadow, pozostaje przy zyciu
                            this.zyweKomorki++;
                        } else {
                            this.komorkiNowe[i][j] = !this.komorki[i][j];                //komorka umiera z samotnosci lub zatloczenia
                            this.martweKomorki++;
                        }
                    } else { //punkt martwy
                        if (this.s.Contains(zywiSasiedzi)) {                        //ilosc zywych sasiadow rowna sie wymaganej liczbie do narodzin
                            this.komorkiNowe[i][j] = !this.komorki[i][j];                //komorka ozywa
                            this.zyweKomorki++;
                        } else {
                            this.komorkiNowe[i][j] = this.komorki[i][j];                 //ilosc zywych sasiadow rozni sie od wymaganej, komorka pozostaje martwa
                            this.martweKomorki++;
                        }
                    }
                }
            }
        }

        private string iloscZywychSasiadow(int i, int j) {
            int zywiSasiedzi = 0;
            try {
                if (this.nieskonczona_plansza) {
                    zywiSasiedzi += this.komorki[i == 0 ? this.komorki.Length - 1 : i - 1][j == 0 ? this.komorki[i].Length - 1 : j - 1] ? 1 : 0; //NW
                    zywiSasiedzi += this.komorki[i][j == 0 ? this.komorki[i].Length - 1 : j - 1] ? 1 : 0;     //N
                    zywiSasiedzi += this.komorki[i + 1 == this.komorki.Length ? 0 : i + 1][j == 0 ? this.komorki[i].Length - 1 : j - 1] ? 1 : 0; //NE
                    zywiSasiedzi += this.komorki[i + 1 == this.komorki.Length ? 0 : i + 1][j] ? 1 : 0;     //E
                    zywiSasiedzi += this.komorki[i + 1 == this.komorki.Length ? 0 : i + 1][j + 1 == this.komorki[i].Length ? 0 : j + 1] ? 1 : 0; //SE
                    zywiSasiedzi += this.komorki[i][j + 1 == this.komorki[i].Length ? 0 : j + 1] ? 1 : 0;     //S
                    zywiSasiedzi += this.komorki[i == 0 ? this.komorki.Length - 1 : i - 1][j + 1 == this.komorki[i].Length ? 0 : j + 1] ? 1 : 0; //SW
                    zywiSasiedzi += this.komorki[i == 0 ? this.komorki.Length - 1 : i - 1][j] ? 1 : 0;     //W
                } else {
                    zywiSasiedzi += this.komorki[i - 1][j - 1] ? 1 : 0; //NW
                    zywiSasiedzi += this.komorki[i][j - 1] ? 1 : 0;     //N
                    zywiSasiedzi += this.komorki[i + 1][j - 1] ? 1 : 0; //NE
                    zywiSasiedzi += this.komorki[i + 1][j] ? 1 : 0;     //E
                    zywiSasiedzi += this.komorki[i + 1][j + 1] ? 1 : 0; //SE
                    zywiSasiedzi += this.komorki[i][j + 1] ? 1 : 0;     //S
                    zywiSasiedzi += this.komorki[i - 1][j + 1] ? 1 : 0; //SW
                    zywiSasiedzi += this.komorki[i - 1][j] ? 1 : 0;     //W
                }
            } catch {
            }
            return zywiSasiedzi.ToString();
        }

        public bool[][] getKomorkiNowe() {
            return this.komorkiNowe;
        }

        public int getZyweKomorki() {
            return this.zyweKomorki;
        }

        public int getMartweKomorki() {
            return this.martweKomorki;
        }
    }
}
