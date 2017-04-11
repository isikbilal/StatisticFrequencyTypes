using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        int sayac = 0;
        double geometrik, kuvvet, atama, aritmetik;
        double toplam = 0, carpım = 1.0, deger = 1.0,harmonik = 0.0;
        Double[] dizi = new double[0];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int txt2 = Convert.ToInt32(textBox1.Text);
            Array.Resize(ref dizi, dizi.Length + 1);
            dizi[sayac] = txt2;
            sayac++;
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dizi.Length != 0)
                {
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        toplam = toplam + dizi[i];
                        carpım = carpım * dizi[i];
                    }
                    aritmetik = toplam / sayac;
                    label1.Text = Convert.ToString("Aritmatik Ortalama : " + aritmetik + "\n\n");
                    geometrik = Math.Pow(carpım, deger / sayac);
                    for (int i = 0; i < sayac; i++)
                    {
                        for (int j = 0; j < sayac; j++)
                        {
                            if (dizi[i] < dizi[j])
                            {
                                double gecici = dizi[i];
                                dizi[i] = dizi[j];
                                dizi[j] = gecici;
                            }
                        }
                    }
                    if (sayac % 2 == 0)
                    {
                        label1.Text = label1.Text + "Medyan : " + (dizi[dizi.Length / 2] + dizi[sayac / 2 - 1]) / 2 + "\n\n";
                    }
                    else
                    {
                        label1.Text += "Medyan : " + dizi[sayac / 2] + "\n\n";
                    }
                    label1.Text = label1.Text + "Geometrik Ortalama : " + geometrik + "\n\n";
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        harmonik += deger / dizi[i];
                    }
                    harmonik = (Convert.ToDouble(dizi.Length)) / harmonik;
                    label1.Text = label1.Text + "Harmonik Ortalama : " + harmonik + "\n\n";



                    foreach (var item in dizi.GroupBy(x => x))
                        //   label1.Text = label1.Text + item.First() + " " + item.Count() + " adet mevcuttur.\n\n";
                        label1.Text = label1.Text + item.Count() + " adet " + item.First() + " mevcuttur.\n\n";

                    string tut = "";
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        tut += " " + Convert.ToString(dizi[i]);
                    }
                    label1.Text += "Gridiğiniz veriler : " + tut;
                }
                else
                {
                    MessageBox.Show("Hiçbir değer girmediniz!");
                }
                harmonik = 0;
                kuvvet = 1;
                carpım = 1;
                Array.Resize(ref dizi, 0);
                sayac = 0; toplam = 0;
            
        }
        }
    }

