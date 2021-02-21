using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bir_islem_uygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s1, s2, s3, s4, s5, s6, hedef, sonuc, carpim;

        
        // Sayıların rastgele oluşturulacağı button
        private void Random_Click(object sender, EventArgs e)
        {
            islemlerLbl.Text = "";
            sonuctxb.Text = "";

            Random rnd = new Random();

            sayi1txb.Text = Convert.ToString(rnd.Next(1, 9));
            sayi2txb.Text = Convert.ToString(rnd.Next(1, 9));
            sayi3txb.Text = Convert.ToString(rnd.Next(1, 9));
            sayi4txb.Text = Convert.ToString(rnd.Next(1, 9));
            sayi5txb.Text = Convert.ToString(rnd.Next(1, 9));
            sayi6txb.Text = Convert.ToString(rnd.Next(1, 9) * 10);
            eldesayi.Text = Convert.ToString(rnd.Next(100, 999));
            s1 = Convert.ToInt32(sayi1txb.Text);
            s2 = Convert.ToInt32(sayi2txb.Text);
            s3 = Convert.ToInt32(sayi3txb.Text);
            s4 = Convert.ToInt32(sayi4txb.Text);
            s5 = Convert.ToInt32(sayi5txb.Text);
            s6 = Convert.ToInt32(sayi6txb.Text);
            hedef = Convert.ToInt32(eldesayi.Text);
        }

        //Sayıların el ile girilmesi butonu
        private void Elile_Click(object sender, EventArgs e)
        {
            islemlerLbl.Text = "";
           
            sonuctxb.Text = "";

            sayi1txb.Text = "";
            sayi2txb.Text = "";
            sayi3txb.Text = "";
            sayi4txb.Text = "";
            sayi5txb.Text = "";
            sayi6txb.Text = "";
            eldesayi.Text = "";
            sonuctxb.Text = "";



            if (
                sayi1txb.Text != "" && sayi2txb.Text != "" && sayi3txb.Text != "" &&
                sayi4txb.Text != "" && sayi5txb.Text != "" && sayi6txb.Text != "" && eldesayi.Text != "" &&
                Convert.ToInt32(sayi6txb.Text) > 9 && Convert.ToInt32(sayi6txb.Text) < 100 && Convert.ToInt32(sayi6txb.Text) % 10 == 0 &&
                Convert.ToInt32(eldesayi.Text) > 99 && Convert.ToInt32(eldesayi.Text) < 1000
                )
            {
                s1 = Convert.ToInt32(sayi1txb.Text);
                s2 = Convert.ToInt32(sayi2txb.Text);
                s3 = Convert.ToInt32(sayi3txb.Text);
                s4 = Convert.ToInt32(sayi4txb.Text);
                s5 = Convert.ToInt32(sayi5txb.Text);
                s6 = Convert.ToInt32(sayi6txb.Text);
                hedef = Convert.ToInt32(eldesayi.Text);
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // hesaplanması istenen sayının, verilen sayılardan en büyüğüne bölümü sonucu kalan sayıyı 
        //bize verilen sayılar içerisinde arayacak ya da oluşturmaya çalışacak fonksiyon

        public int Kalan_bul(int[] dizi, int kalan)
        {
            int bulunan_kalan = 0;



            // kalan değeri bizi istenen sayıya ulaştırabilecek bir değer olduğu için
            //sayılarımız arasında bu deger var mı diye bakıyoruz
            //bunun için sayılarımızı attığımız dizinin elemanlarını, döngü ile, kalan değeri ile karşılaştırıyoruz
            for (int i = 0; i < 6; i++)
            {
                if (dizi[i] == kalan)
                {
                    kalan = dizi[i];
                    bulunan_kalan = 1;

                }
                if (bulunan_kalan == 1) break;
            }

            //kalan değeri sayılar arasında direkt olmayabileceği için
            // 2 sayının çarpımı kalan değerine eşit mi diye bakıyoruz
            if (bulunan_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] * dizi[j]) == kalan)
                        {
                            kalan = (dizi[i] * dizi[j]);
                            bulunan_kalan = 1;
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(kalan) + "\n";



                        }
                        if (bulunan_kalan == 1) break;
                    }
                    if (bulunan_kalan == 1) break;
                }
            }

            // 2 sayının bölümü kalan değerine eşit mi diye bakıyoruz
            if (bulunan_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] / dizi[j]) == kalan)
                        {
                            kalan = (dizi[i] / dizi[j]);
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " / " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(kalan) + "\n";
                            bulunan_kalan = 1;

                        }
                        if (bulunan_kalan == 1) break;
                    }
                    if (bulunan_kalan == 1) break;

                }
            }


            // 2 sayının toplamı kalan değerine eşit mi diye bakıyoruz
            if (bulunan_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] + dizi[j]) == kalan)
                        {
                            kalan = (dizi[i] + dizi[j]);
                            bulunan_kalan = 1;
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(kalan) + "\n";

                        }
                        if (bulunan_kalan == 1) break;
                    }
                    if (bulunan_kalan == 1) break;
                }
            }

            // 2 sayının farkı kalan değerine eşit mi diye bakıyoruz
            if (bulunan_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] - dizi[j]) == kalan)
                        {
                            kalan = (dizi[i] - dizi[j]);
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " - " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(kalan) + "\n";

                            bulunan_kalan = 1;

                        }
                        if (bulunan_kalan == 1) break;
                    }
                    if (bulunan_kalan == 1) break;
                }
            }

            


            // 3 sayının kendi içindeki işlemleri kalan değerine eşit mi diye bakıyoruz
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int z = 0; z < 6; z++)
                    {

                        if (dizi[i] + dizi[j] + dizi[z] == kalan)
                        {
                            kalan = dizi[i] + dizi[j] + dizi[z];
                            bulunan_kalan = 1;
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + " + " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bulunan_kalan == 1) break;

                        if (dizi[i] + dizi[j] - dizi[z] == kalan && bulunan_kalan != 1)
                        {
                            kalan = dizi[i] + dizi[j] - dizi[z];
                            bulunan_kalan = 1;
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + " - " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bulunan_kalan == 1) break;
                        if (dizi[i] * dizi[j] * dizi[z] == kalan && bulunan_kalan != 1)
                        {
                            kalan = dizi[i] * dizi[j] * dizi[z];
                            bulunan_kalan = 1;
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + " * " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bulunan_kalan == 1) break;
                        if ((dizi[i] * dizi[j]) + dizi[z] == kalan && bulunan_kalan != 1)
                        {
                            kalan = (dizi[i] * dizi[j]) + dizi[z];
                            bulunan_kalan = 1;
                            islemlerLbl.Text += "(" + Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + ")" + " + " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(kalan) + "\n";


                        }

                        if (bulunan_kalan == 1) break;
                        if (dizi[i] * (dizi[j] + dizi[z]) == kalan && bulunan_kalan != 1)
                        {
                            kalan = dizi[i] * (dizi[j] + dizi[z]);
                            bulunan_kalan = 1;
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + "(" + Convert.ToString(dizi[j]) + " + " + Convert.ToString(dizi[z]) + ")" + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bulunan_kalan == 1) break;
                        if (dizi[i] * dizi[j] - dizi[z] == kalan && bulunan_kalan != 1)
                        {
                            kalan = dizi[i] * dizi[j] - dizi[z];
                            bulunan_kalan = 1;
                            islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + " - " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(kalan) + "\n";


                        }

                        if (bulunan_kalan == 1) break;

                    }

                    if (bulunan_kalan == 1) break;
                }

                if (bulunan_kalan == 1) break;
            }


            if (bulunan_kalan == 1)
            {
                return kalan;
            }
            else
            {
                return kalan = 0;
            }

        }

        // İSTENEN SAYIYI HESAPLAMA BUTONU

        private void hesapla_Click(object sender, EventArgs e)
        {
            int bulundu = 0;
            sonuc = 0;

            if (
                 sayi1txb.Text != "" && sayi2txb.Text != "" && sayi3txb.Text != "" &&
                 sayi4txb.Text != "" && sayi5txb.Text != "" && sayi6txb.Text != "" && eldesayi.Text != "" &&
                 Convert.ToInt32(sayi6txb.Text) > 9 && Convert.ToInt32(sayi6txb.Text) < 100 && Convert.ToInt32(sayi6txb.Text) % 10 == 0 &&
                 Convert.ToInt32(eldesayi.Text) > 99 && Convert.ToInt32(eldesayi.Text) < 1000
                 )
            {
                s1 = Convert.ToInt32(sayi1txb.Text);
                s2 = Convert.ToInt32(sayi2txb.Text);
                s3 = Convert.ToInt32(sayi3txb.Text);
                s4 = Convert.ToInt32(sayi4txb.Text);
                s5 = Convert.ToInt32(sayi5txb.Text);
                s6 = Convert.ToInt32(sayi6txb.Text);
                hedef = Convert.ToInt32(eldesayi.Text);
                carpim = s1 * s2 * s3 * s4 * s5 * s6;
                if (carpim < hedef)
                {
                    MessageBox.Show("Verilen sayılarla elde edilmesi istenen sayı bulunamaz");

                }

                //verilen sayıları ve hedef sayımızı bir diziye atıyoruz
                int[] dizi = { s1, s2, s3, s4, s5, s6, hedef };

                int temp;
                
                for (int i = 1; i < 7; i++)
                {
                    for (int j = 0; j < 7 - i; j++)
                    {
                        if (dizi[j] > dizi[j + 1])
                        {
                            temp = dizi[j];
                            dizi[j] = dizi[j + 1];
                            dizi[j + 1] = temp;
                        }

                    }
                }
                
                
                // sonuca ulaşabilmek için en büyük sayıyı öncelikli kullanıyoruz
                // hedef sayı, 2 basamaklı sayımızın belli bir katına yakın ise ve bu kat rastgele sayılarımızdan biri ise,
                // öncelikli olarak bu iki sayının çarpımına bakıyoruz

                int bolum, kalan;
                // hedef sayımızın en büyük sayı ile bölümünü buluyoruz
                bolum = hedef / s6;
               // hedef sayımızın en büyük sayı ile bölümünden kalanı buluyoruz
                kalan = hedef % s6;
                
                bulundu = 0;
                
                // bolum değeri bizi istenen sayıya ulaştırabilecek bir değer olduğu için
                //sayılarımız arasında bu deger var mı diye bakıyoruz
                //bunun için sayılarımızı attığımız dizinin elemanlarını, döngü ile, bolum değeri ile karşılaştırıyoruz

                for (int i = 0; i < 6; i++)
                {
                    if (dizi[i] == bolum)
                    {
                        sonuc = dizi[i] * s6;
                        islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(s6) + " = " + Convert.ToString(sonuc) + "\n";
                        bulundu = 1;
                        break;
                    }

                }

                //bolum değeri sayılar arasında direkt olmayabileceği için
                // 2 sayının çarpımı bölüm değerine eşit mi diye bakıyoruz
                if (bulundu != 1)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if ((dizi[i] * dizi[j]) == bolum)
                            {
                                sonuc = s6 * (dizi[i] * dizi[j]);
                                bulundu = 1;
                                islemlerLbl.Text += Convert.ToString(s6) + " * " + Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";

                            }
                            if (bulundu == 1) break;
                        }
                        if (bulundu == 1) break;

                    }
                }

                //bolum değeri sayılar arasında direkt olmayabileceği için
                // 2 sayının toplamı bölüm değerine eşit mi diye bakıyoruz
                if (bulundu != 1)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if ((dizi[i] + dizi[j]) == bolum)
                            {
                                sonuc = s6 * (dizi[i] + dizi[j]);
                                bulundu = 1;
                                islemlerLbl.Text += Convert.ToString(s6) + " * " + Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";

                            }
                            if (bulundu == 1) break;
                        }
                        if (bulundu == 1) break;
                    }
                }

                //bolum değeri sayılar arasında direkt olmayabileceği için
                // 2 sayının farkı bölüm değerine eşit mi diye bakıyoruz
                if (bulundu != 1)
                {
                    for (int i = 0; i < 6; i++)
                    {


                        for (int j = 0; j < 6; j++)
                        {
                            if ((dizi[i] - dizi[j]) == bolum)
                            {
                                sonuc = s6 * (dizi[i] - dizi[j]);
                                islemlerLbl.Text += Convert.ToString(s6) + " * " + Convert.ToString(dizi[i]) + " - " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";


                                bulundu = 1;

                            }
                            if (bulundu == 1) break;

                        }
                        if (bulundu == 1) break;

                    }
                }
                //bolum değeri sayılar arasında direkt olmayabileceği için
                // 2 sayının bölümü bölüm değerine eşit mi diye bakıyoruz
                if (bulundu != 1)
                {
                    for (int i = 0; i < 6; i++)
                    {


                        for (int j = 0; j < 6; j++)
                        {
                            if ((dizi[i] / dizi[j]) == bolum)
                            {
                                sonuc = s6 * (dizi[i] / dizi[j]);
                                islemlerLbl.Text += Convert.ToString(s6) + " * " + Convert.ToString(dizi[i]) + " / " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";


                                bulundu = 1;

                            }
                            if (bulundu == 1) break;
                        }
                        if (bulundu == 1) break;
                    }
                }

                //bolum değeri sayılar arasında direkt olmayabileceği için
                // 3 sayının kendi aralarındaki işlemi bölüm değerine eşit mi diye bakıyoruz
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int z = 0; z < 6; z++)
                        {
                            if (dizi[i] + dizi[j] + dizi[z] == bolum)
                            {
                                sonuc = s6 * (dizi[i] + dizi[j] + dizi[z]);
                                bulundu = 1;
                                islemlerLbl.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + " + " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";


                            }
                            if (bulundu == 1) break;

                            if (dizi[i] + dizi[j] - dizi[z] == bolum && bulundu != 1)
                            {
                                sonuc = s6 * (dizi[i] + dizi[j] - dizi[z]);
                                bulundu = 1;
                                islemlerLbl.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + " - " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";

                            }
                            if (bulundu == 1) break;

                            if (dizi[i] * dizi[j] + dizi[z] == bolum && bulundu != 1)
                            {
                                sonuc = s6 * (dizi[i] * dizi[j] + dizi[z]);
                                bulundu = 1;
                                islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + " + " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";


                            }
                            if (bulundu == 1) break;
                            if (dizi[i] * dizi[j] - dizi[z] == bolum && bulundu != 1)
                            {
                                sonuc = s6 * (dizi[i] * dizi[j] - dizi[z]);
                                bulundu = 1;
                                islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + " - " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";


                            }
                            if (bulundu == 1) break;
                            if (dizi[i] * dizi[j] * dizi[z] == bolum && bulundu != 1)
                            {
                                sonuc = s6 * (dizi[i] * dizi[j] * dizi[z]);
                                bulundu = 1;
                                islemlerLbl.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + " * " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";


                            }

                            if (bulundu == 1) break;

                        }

                        if (bulundu == 1) break;
                    }

                    if (bulundu == 1) break;
                }

                // Kalan bulma fonksiyonumuzu çağırıyoruz
                // en büyük sayı ve bulunabilen yakın katı çarpıp sonuc ile kalanı toplayıp
                // elde edilmesi istenen sayıya en yakın sayıyı buluyoruz
                if (kalan != 0)
                {
                    int ilk_sonuc = sonuc;
                    sonuc = sonuc + Kalan_bul(dizi, kalan);
                    islemlerLbl.Text += Convert.ToString(ilk_sonuc) + " + " + Convert.ToString(Kalan_bul(dizi, kalan)) + " = " + Convert.ToString(sonuc) + "\n";

                }


                sonuctxb.Text = Convert.ToString(sonuc);
                int puan;
                    puan = (sonuc - hedef) + 10 ;
                puantxb.Text = Convert.ToString(puan);
                
            }
            else
                MessageBox.Show("lütfen değerleri tam giriniz.");






        }


     
    }
}
