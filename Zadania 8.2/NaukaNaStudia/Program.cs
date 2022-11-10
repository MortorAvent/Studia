namespace ConsoleApp9
{
    internal class Program
    {

        /* wyswietlanie tablicy */
        static void printTable(int[] table)
        {
            string txt = "[";
            for (int i = 0; i < table.Length; i++)
            {
                txt += table[i];
                if (i < table.Length - 1)
                {
                    txt += ", ";
                }
            }
            txt += "]";
            Console.WriteLine(txt);
        }


        /* zadanie 8.2.1 */
        static void zad_8_2_1()
        {
            int n = 5;
            Console.WriteLine("Podaj 5 liczb");
            int[] table = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe");
                int temp = int.Parse(Console.ReadLine());
                table[i] = temp;
            }

            int max = table[0];
            foreach (int row in table)
            {
                if (row > max)
                {
                    max = row;
                }
            }

            Console.WriteLine("Najwieksza wartosc: " + max);
        }

      /*  zadanie 8.2.2 */

        static void zad_8_2_2()
        {
            int n = 3;
            Console.WriteLine("Podaj 3 liczby");
            int[] table = new int[n];

            for(int i =0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                int temp = int.Parse(Console.ReadLine());
                table[i] = temp;
            }

            int min = table[0];
            foreach (int row in table)
            {
                if(row < min)
                {
                    min = row;
                }
            }
            Console.WriteLine("Najmniejsza wartość: " +min);
        }

       /* Zadanie 8.2.3 */

        static void zad_8_2_3()
        {
            
            int x = 0;
            int n = 4;
            Console.WriteLine("Podaj 4 liczby: ");
            int[] table = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbę: ");
                int temp = int.Parse(Console.ReadLine());
                table[i] = temp;
                
            }

            int max = table[0];
            foreach(int row in table)
            {
                if(row > max)
                {
                    max = row;
                    
                }
                if(row == max)
                {
                    x = x + 1;
                }
                

            }

            Console.WriteLine("Nawiększa wartość to: " + max + " ,wystąpiła " + x + " razy");
        }

        /* Zadanie 8.2.4 */

        static void zad_8_2_4()
        {
            
            int n = 6;
            Console.WriteLine("Podaj 6 liczb: ");
            int[] table = new int[n];
            int x = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe: ");
                int temp = int.Parse(Console.ReadLine());
                table[i] = temp;
            }

            int min = table[0];
            foreach(int row in table)
            {
                if(row < min)
                {
                    min = row;
                }
                if (row == min)
                {
                    x++ ;
                }


            }
            Console.WriteLine("Namniejsza wartość to: " + min + " ,wystąpiła " + x + " razy");
           
        }

        /* Zadanie 8.2.5 */

       
        static void zad_8_2_5()
        {
            int n = 5;
            Console.WriteLine("Podaj 5 liczb");
            int[] table = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe");
                int temp = int.Parse(Console.ReadLine());
                table[i] = temp;
            }

            
            int max = table[0];
            
            foreach (int row in table)
            {
               if (row > max)
                {
                    max = row;
                }
            }

            int vice = table.Min();
            int counter_vice = 0;
            foreach (int row in table)
            {
                if (vice < row && row != max)
                {
                    vice = row;
                    counter_vice = 0;

                }
                if(row == vice)
                {
                    counter_vice++;
                }
            }




            Console.WriteLine("Druga najwieksza wartosc: " + vice + " ,wystąpiła " + counter_vice + " razy.");

        }


        static void zad_8_2_6()
        {
            int n = 6;
            Console.WriteLine("Podaj 6 liczb");
            int[] table = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe");
                int temp = int.Parse(Console.ReadLine());
                table[i] = temp;
            }


            int min = table[0];
            
            foreach (int row in table)
            {
                if (row < min)
                {
                    min = row;
                }
            }

            int vice_min = table.Max();
            int counter_vice_min = 0;
            foreach (int row in table)
            {
                if (vice_min > row && row != min)
                {
                    vice_min = row;
                    counter_vice_min = 0;
                }
                if (row == vice_min)
                {
                    counter_vice_min++;
                }
            }

            Console.WriteLine("Druga najmniejsza wartosc: " + vice_min + " ,wystąpiła " + counter_vice_min + " razy.");
            

        }



        static void Main(string[] args)
        {
            int[] table = {1,2,3,4,5,6,7};
            printTable(table);

            zad_8_2_5();
        }
       
    }
}