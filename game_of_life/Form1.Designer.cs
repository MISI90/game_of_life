namespace game_of_life {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar_wielkosc_komorki = new System.Windows.Forms.TrackBar();
            this.button_start = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox_reguly = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkedListBox_regula_narodzin = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_regula_przezycia = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_nieskonczona_plansza = new System.Windows.Forms.CheckBox();
            this.textBox_szybkosc_animacji = new System.Windows.Forms.TextBox();
            this.trackBar_szybkosc_animacji = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_wielkosc_komorki = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer_gra = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_stat_martwe_komorki = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_stat_zywe_komorki = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_krok = new System.Windows.Forms.Button();
            this.button_losuj_komorki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_wielkosc_komorki)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_szybkosc_animacji)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 650);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // trackBar_wielkosc_komorki
            // 
            this.trackBar_wielkosc_komorki.Location = new System.Drawing.Point(6, 32);
            this.trackBar_wielkosc_komorki.Maximum = 20;
            this.trackBar_wielkosc_komorki.Minimum = 1;
            this.trackBar_wielkosc_komorki.Name = "trackBar_wielkosc_komorki";
            this.trackBar_wielkosc_komorki.Size = new System.Drawing.Size(197, 45);
            this.trackBar_wielkosc_komorki.TabIndex = 3;
            this.trackBar_wielkosc_komorki.Value = 3;
            this.trackBar_wielkosc_komorki.ValueChanged += new System.EventHandler(this.trackBar_wielkosc_komorki_ValueChanged);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_start.Location = new System.Drawing.Point(668, 523);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(44, 23);
            this.button_start.TabIndex = 4;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_reguly);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkedListBox_regula_narodzin);
            this.groupBox1.Controls.Add(this.checkedListBox_regula_przezycia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(668, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 255);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reguły gry";
            // 
            // listBox_reguly
            // 
            this.listBox_reguly.FormattingEnabled = true;
            this.listBox_reguly.Items.AddRange(new object[] {
            "Reguła Conwaya (23/3)",
            "Nasiona (/2)",
            "Labirynt (12345/3)",
            "Replikator Fredkina (1357/1357)",
            "Miasta otoczone murem (2345/45678)"});
            this.listBox_reguly.Location = new System.Drawing.Point(6, 193);
            this.listBox_reguly.Name = "listBox_reguly";
            this.listBox_reguly.Size = new System.Drawing.Size(234, 56);
            this.listBox_reguly.TabIndex = 9;
            this.listBox_reguly.SelectedValueChanged += new System.EventHandler(this.listBox_reguly_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Wybierz zdefiniowane reguły";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkedListBox_regula_narodzin
            // 
            this.checkedListBox_regula_narodzin.CheckOnClick = true;
            this.checkedListBox_regula_narodzin.FormattingEnabled = true;
            this.checkedListBox_regula_narodzin.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.checkedListBox_regula_narodzin.Location = new System.Drawing.Point(133, 32);
            this.checkedListBox_regula_narodzin.Name = "checkedListBox_regula_narodzin";
            this.checkedListBox_regula_narodzin.Size = new System.Drawing.Size(107, 139);
            this.checkedListBox_regula_narodzin.TabIndex = 6;
            // 
            // checkedListBox_regula_przezycia
            // 
            this.checkedListBox_regula_przezycia.CheckOnClick = true;
            this.checkedListBox_regula_przezycia.FormattingEnabled = true;
            this.checkedListBox_regula_przezycia.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.checkedListBox_regula_przezycia.Location = new System.Drawing.Point(6, 32);
            this.checkedListBox_regula_przezycia.Name = "checkedListBox_regula_przezycia";
            this.checkedListBox_regula_przezycia.Size = new System.Drawing.Size(107, 139);
            this.checkedListBox_regula_przezycia.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reguła narodzin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reguła przeżycia";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_nieskonczona_plansza);
            this.groupBox2.Controls.Add(this.textBox_szybkosc_animacji);
            this.groupBox2.Controls.Add(this.trackBar_szybkosc_animacji);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_wielkosc_komorki);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.trackBar_wielkosc_komorki);
            this.groupBox2.Location = new System.Drawing.Point(668, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 169);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia gry";
            // 
            // checkBox_nieskonczona_plansza
            // 
            this.checkBox_nieskonczona_plansza.AutoSize = true;
            this.checkBox_nieskonczona_plansza.Checked = true;
            this.checkBox_nieskonczona_plansza.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_nieskonczona_plansza.Location = new System.Drawing.Point(6, 134);
            this.checkBox_nieskonczona_plansza.Name = "checkBox_nieskonczona_plansza";
            this.checkBox_nieskonczona_plansza.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBox_nieskonczona_plansza.Size = new System.Drawing.Size(133, 17);
            this.checkBox_nieskonczona_plansza.TabIndex = 8;
            this.checkBox_nieskonczona_plansza.Text = "Nieskończona plansza";
            this.checkBox_nieskonczona_plansza.UseVisualStyleBackColor = true;
            // 
            // textBox_szybkosc_animacji
            // 
            this.textBox_szybkosc_animacji.Location = new System.Drawing.Point(209, 83);
            this.textBox_szybkosc_animacji.Name = "textBox_szybkosc_animacji";
            this.textBox_szybkosc_animacji.ReadOnly = true;
            this.textBox_szybkosc_animacji.Size = new System.Drawing.Size(31, 20);
            this.textBox_szybkosc_animacji.TabIndex = 7;
            this.textBox_szybkosc_animacji.Text = "100";
            this.textBox_szybkosc_animacji.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trackBar_szybkosc_animacji
            // 
            this.trackBar_szybkosc_animacji.Location = new System.Drawing.Point(9, 83);
            this.trackBar_szybkosc_animacji.Maximum = 20;
            this.trackBar_szybkosc_animacji.Minimum = 1;
            this.trackBar_szybkosc_animacji.Name = "trackBar_szybkosc_animacji";
            this.trackBar_szybkosc_animacji.Size = new System.Drawing.Size(194, 45);
            this.trackBar_szybkosc_animacji.SmallChange = 50;
            this.trackBar_szybkosc_animacji.TabIndex = 6;
            this.trackBar_szybkosc_animacji.Value = 2;
            this.trackBar_szybkosc_animacji.Scroll += new System.EventHandler(this.trackBar_szybkosc_animacji_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Szybkość animacji [ms]";
            // 
            // textBox_wielkosc_komorki
            // 
            this.textBox_wielkosc_komorki.Location = new System.Drawing.Point(209, 32);
            this.textBox_wielkosc_komorki.Name = "textBox_wielkosc_komorki";
            this.textBox_wielkosc_komorki.ReadOnly = true;
            this.textBox_wielkosc_komorki.Size = new System.Drawing.Size(31, 20);
            this.textBox_wielkosc_komorki.TabIndex = 4;
            this.textBox_wielkosc_komorki.Text = "3";
            this.textBox_wielkosc_komorki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Wielkość komórki [px]";
            // 
            // timer_gra
            // 
            this.timer_gra.Tick += new System.EventHandler(this.timer_gra_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_stat_martwe_komorki);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_stat_zywe_komorki);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(668, 448);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 69);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statystyki";
            // 
            // textBox_stat_martwe_komorki
            // 
            this.textBox_stat_martwe_komorki.Location = new System.Drawing.Point(175, 39);
            this.textBox_stat_martwe_komorki.Name = "textBox_stat_martwe_komorki";
            this.textBox_stat_martwe_komorki.ReadOnly = true;
            this.textBox_stat_martwe_komorki.Size = new System.Drawing.Size(65, 20);
            this.textBox_stat_martwe_komorki.TabIndex = 4;
            this.textBox_stat_martwe_komorki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Martwe komórki";
            // 
            // textBox_stat_zywe_komorki
            // 
            this.textBox_stat_zywe_komorki.Location = new System.Drawing.Point(175, 13);
            this.textBox_stat_zywe_komorki.Name = "textBox_stat_zywe_komorki";
            this.textBox_stat_zywe_komorki.ReadOnly = true;
            this.textBox_stat_zywe_komorki.Size = new System.Drawing.Size(65, 20);
            this.textBox_stat_zywe_komorki.TabIndex = 1;
            this.textBox_stat_zywe_komorki.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Żywe komórki";
            // 
            // button_krok
            // 
            this.button_krok.Location = new System.Drawing.Point(718, 523);
            this.button_krok.Name = "button_krok";
            this.button_krok.Size = new System.Drawing.Size(44, 23);
            this.button_krok.TabIndex = 8;
            this.button_krok.Text = "Krok";
            this.button_krok.UseVisualStyleBackColor = true;
            this.button_krok.Click += new System.EventHandler(this.button_krok_Click);
            // 
            // button_losuj_komorki
            // 
            this.button_losuj_komorki.Location = new System.Drawing.Point(768, 523);
            this.button_losuj_komorki.Name = "button_losuj_komorki";
            this.button_losuj_komorki.Size = new System.Drawing.Size(81, 23);
            this.button_losuj_komorki.TabIndex = 9;
            this.button_losuj_komorki.Text = "Losuj komórki";
            this.button_losuj_komorki.UseVisualStyleBackColor = true;
            this.button_losuj_komorki.Click += new System.EventHandler(this.button_losuj_komorki_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 674);
            this.Controls.Add(this.button_losuj_komorki);
            this.Controls.Add(this.button_krok);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conway\'s Game of Life";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_wielkosc_komorki)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_szybkosc_animacji)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar_wielkosc_komorki;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox_regula_narodzin;
        private System.Windows.Forms.CheckedListBox checkedListBox_regula_przezycia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_wielkosc_komorki;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar_szybkosc_animacji;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_szybkosc_animacji;
        private System.Windows.Forms.Timer timer_gra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_stat_martwe_komorki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_stat_zywe_komorki;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_nieskonczona_plansza;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox_reguly;
        private System.Windows.Forms.Button button_krok;
        private System.Windows.Forms.Button button_losuj_komorki;
    }
}

