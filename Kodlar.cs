using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayinTarlasi
{

    public partial class MayinTarlasi : Form
    {
        Random rastgele = new Random();
        int mayinliSayi;
        int mayinliSayi2;
        int[] mayinliSayilar;
        Button[] buttonlar;
        int mayinsizSayi = 0;

        public MayinTarlasi()
        {
            InitializeComponent();
            buttonlar = new Button[]
            {
                button1, button2, button3, button4, button5, button6, button7, button8, button9
            };
            YeniOyunBaslat();
        }
        public void YeniOyunBaslat()
        {
            mayinsizSayi = 0;
            foreach (Button btn in buttonlar)
            {
                btn.Text = "";
                btn.BackColor = SystemColors.Highlight;
                btn.Enabled = true;
            }
            do
            {
                mayinliSayi = rastgele.Next(1, 10);
                mayinliSayi2 = rastgele.Next(1, 10);
            } while (mayinliSayi == mayinliSayi2);

            mayinliSayilar = new int[]
        {
                mayinliSayi, mayinliSayi2
        };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 1;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 2, 4, 5 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 2;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 1, 3, 4, 5, 6 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 3;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 2, 5, 6 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 4;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 1, 2, 5, 7, 8 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 5;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 1, 2, 3, 4, 6, 7, 8, 9 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 6;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 2, 3, 5, 8, 9 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 7;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 4, 5, 8 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 8;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 4, 5, 6, 7, 9 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            mayinsizSayi += 1;
            int buttonNo = 9;
            int indekshatasi = buttonNo - 1;
            foreach (int mayinliSayiNo in mayinliSayilar)
            {
                if (mayinliSayiNo == buttonNo)
                {
                    buttonlar[indekshatasi].Text = "💣";
                    buttonlar[indekshatasi].BackColor = SystemColors.Window;
                    MessageBox.Show("Mayına bastığın için oyun yeniden başlatılıyor!");
                    YeniOyunBaslat();
                    return;
                }
            }
            int i = 0; //cevresine göre i değeri artacak
            buttonlar[indekshatasi].BackColor = SystemColors.Window;
            int[] komsular = { 5, 6, 8 };
            foreach (int komsuNo in komsular)
            {
                foreach (int mayinliNo in mayinliSayilar)
                {
                    if (mayinliNo == komsuNo)
                    {
                        i++;
                    }
                }

            }
            buttonlar[indekshatasi].Text = i.ToString();
            if (mayinsizSayi == 7)
            {
                MessageBox.Show("Bütün mayınlardan kaçmayı başardın Affferinlan sana");
                MessageBox.Show("Oyun yeniden baslatılıyor");
                YeniOyunBaslat();
                return;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            YeniOyunBaslat();
        }

        private void buttoncik_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
