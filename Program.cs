using System;

namespace soru3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Dilediğiniz kümeyi aşagıdaki diziye girebilirsiniz.
            int[] kume = {-2,-4,3,4,5,2};

            int altkumeSayisi = (int)Math.Pow(2, kume.Length);
            string[] altKumeler = new string[altkumeSayisi];
            string[] toplamSifirAltKumeler = new string[altkumeSayisi];
            string altKume = "";
            int sayi = 0;
            int sayac = 0;
            for (int i = 0; i < altkumeSayisi; i++)
            {
                sayi = i;
                
                sayac = 0;
                for (int j = 0; j < kume.Length; j++)
                {
                    if(sayi%2==1)
                    {
                        if (sayac==0)
                        {
                            altKume += kume[j];
                        }
                        else
                        {
                            altKume += "," + kume[j];
                        }
                        sayac++;
                    }
                    if (sayi == 1)
                    {
                        break;
                    }
                    if (sayi>=2)
                    {
                        sayi = sayi / 2;
                    }
                }
                string[] kumeElemanlari = altKume.Split(",");
                int toplam =0;
                if (kumeElemanlari[0]!="")
                {
                    for (int c = 0; c < kumeElemanlari.Length; c++)
                    {
                        toplam += Convert.ToInt32(kumeElemanlari[c]);
                    }
                }
                

                altKume = "{" + altKume + "} Toplamları : "+toplam;
                if (toplam==0)
                {
                    toplamSifirAltKumeler[i] = altKume;
                }
                altKumeler[i] = altKume;
                altKume = "";
            }
            string temp = "";
            for (int i = 0; i < altkumeSayisi; i++)
            {
                for (int j = 0; j < altkumeSayisi-1; j++)
                {
                    if (altKumeler[j].Length>altKumeler[j+1].Length)
                    {
                        temp = altKumeler[j];
                        altKumeler[j] = altKumeler[j + 1];
                        altKumeler[j + 1] = temp;

                    }
                }
            }
            int sifirSay = 0;
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Tüm Alt Kümeler Ve Toplamları :\n");
            for (int i = 0; i < altkumeSayisi; i++)
            {
                Console.WriteLine((i+1)+". "+altKumeler[i]);
            }
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine("Toplamları 0 olan Kümeler Ve Toplamları :\n");
            for (int i = 0; i < altkumeSayisi; i++)
            {
                if (toplamSifirAltKumeler[i]!=null)
                {
                    Console.WriteLine(toplamSifirAltKumeler[i]);
                    sifirSay++;
                }
                

            }
            Console.WriteLine("\n"+sifirSay+" adet toplamları 0 olan alt küme var.");
            Console.ReadKey();
        }

    }
}
