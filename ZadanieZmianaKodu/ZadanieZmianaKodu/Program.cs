using System.Globalization;

namespace ZadanieZmianaKodu
{
    internal class Program 
    {
        static void ZmianaKodu_10_na_8()
        {
            int[] wynik = new int[80];
            int i = 0;

            Console.WriteLine("Podaj liczbę w postaci dziesiętnej: ");
            int liczba_dziesietna = Convert.ToInt32(Console.ReadLine());

            while (liczba_dziesietna != 0)
            {

                if (liczba_dziesietna >= 0)
                {
                    wynik[i] = liczba_dziesietna % 8;
                    liczba_dziesietna /= 8;
                    i++;
                }
                else
                {
                    Console.WriteLine("Podałeś złą liczbę!");
                    liczba_dziesietna = 0;
                }

            }

            Console.Write("Liczba w postaci osemkowej: ");

            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(wynik[j]);
            }

        }  
        static void Main(string[] args)
        {
            ZmianaKodu_10_na_8();
        }

    }

}