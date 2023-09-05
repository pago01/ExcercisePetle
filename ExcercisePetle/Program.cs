using ExercisePetle1;
using System;
using System.ComponentModel.Design;

namespace ExercisePetle1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int nr_zadania = 0;
            bool parseresult;
            do
            {


                do
                {
                    Console.WriteLine("Podaj nr zadania które chcesz wykonać" +
                    "\n1.Liczby pierwsze 0-100" +
                    "\n2.Liczby parzyste 0-1000" +
                    "\n3.Ciąg Fibonacciego" +
                    "\n4. Piramida liczb" +
                    "\n5. 3 potęga 1-20" +
                    "\n6. Suma odworotności 1-20" +
                    "\n7. Rysowanie diamentu" +
                    "\n8. Odwrócenie kolejności znaków" +
                    "\n9. Konwersja liczby dziesiętnej na binarną" +
                    "\n10. Najmniejsza wspólna wielokrotność 2 liczb" +
                    "\n11. Zakończ \n");
                    parseresult = Int32.TryParse(Console.ReadLine(), out nr_zadania);
                }
                while (!parseresult || nr_zadania > 12 && nr_zadania < 1);

                Console.WriteLine($"\nWybrałeś zadanie nr {nr_zadania}\n");

                switch (nr_zadania)
                {
                    case 1:
                        //CLiczby pierwsze 0-100
                        int licznik = 0;

                        for (double a = 1; a < 101; a++)
                        {
                            for (double i = 2; i <= Math.Sqrt(a) + 1 || i < 3; i++)
                            {
                                if (a == 2 || a == 3)
                                {
                                    Console.WriteLine($"Liczba {a} jest liczbą pierwszą");
                                    licznik++;
                                }
                                else if (a % i == 0)
                                {
                                    i = Math.Sqrt(a) + 1;
                                }
                                else if (a % i != 0 && i > Math.Sqrt(a))
                                {
                                    Console.WriteLine($"Liczba {a} jest liczbą pierwszą");
                                    licznik++;
                                }
                            }

                        }

                        Console.WriteLine($"Od 0 do 100 jest {licznik} liczb pierwszych");
                        break;

                    case 2:
                        //2.Liczby parzyste 0-1000

                        int b = 0;

                        do
                        {
                            b = b + 2;
                            Console.WriteLine(b);
                        }
                        while (b < 1000);
                        break;

                    case 3:
                        //Ciąg Fibonacciego

                        int n1 = 0;
                        int n2 = 1;

                        do
                        {
                            Console.WriteLine(n1);
                            n2 = n1 + n2;
                            n1 = n2 - n1;
                        }
                        while (n2 > 0);
                        break;

                    case 4:
                        //Piramida liczb

                        int p1 = 0;
                        int p2 = 1;
                        int p3 = 1;
                        //Numer read
                        Console.WriteLine("Podaj liczbę");
                        Int32.TryParse(Console.ReadLine(), out p1);

                        //Calculation
                        while (p1 >= p2)
                        {
                            for (int i = 0; i <= p3; i++)
                            {
                                if (p1 >= p2)
                                {
                                    if (i == 0)
                                    {
                                        Console.WriteLine(p2);
                                        p2++;
                                    }
                                    else
                                    {
                                        Console.Write(p2);
                                        p2++;
                                    }
                                }
                            }
                            p3++;
                        }
                        break;

                    case 5:
                        {
                            //3 potęga 1-20        
                            for (int i = 1; i <= 20; i++)
                            {
                                Console.WriteLine(Math.Pow(i, 3));
                            }
                        }
                        break;
                    case 6:
                        double a1 = 0;

                        //Calculation         
                        for (double i = 1; i <= 20; i++)
                        {
                            a1 = a1 + 1 / i;
                        }
                        Console.WriteLine(a1);
                        break;

                    case 7:
                        //Rysowanie diamentu
                        int x = 0;
                        string str = "";
                        Console.WriteLine("Podaj dlugosc przekatnej");
                        Int32.TryParse(Console.ReadLine(), out x);
                        //Calculation and drawing
                        // Upper part and horizontal diagonal
                        for (int n = x % 2; n <= x; n = n + 2)
                        {
                            str = "";
                            for (int j = 1; j <= (x - n) / 2; j++)
                            {
                                str = str + " ";
                            }
                            for (int j = 1; j <= n; j++)
                            {
                                str = str + "*";
                            }
                            Console.WriteLine(str);
                        }
                        //Lower part
                        for (int n = x - 2; n >= 1; n = n - 2)
                        {
                            str = "";
                            for (int j = 1; j <= (x - n) / 2; j++)
                            {
                                str = str + " ";
                            }
                            for (int j = 1; j <= n; j++)
                            {
                                str = str + "*";
                            }
                            Console.WriteLine(str);
                        }
                        break;

                    case 8:
                        //Odwrócenie kolejności znaków
                        string str1 = "";
                        string str2 = "";
                        Console.WriteLine("Wpisz dowolny tekst");
                        str1 = Console.ReadLine();
                        //Creating inverted string
                        for (int l = str1.Length - 1; l >= 0; l--)
                        {
                            str2 = str2 + str1[l];
                        }
                        Console.WriteLine(str2);
                        break;
                    case 9:
                        //Konwersja liczby dziesiętnej na binarną
                        int a2 = 0;
                        string wynik = "";
                        bool parseresult2;

                        do
                        {
                            Console.WriteLine("Podaj liczbe do konwersji na zapis binarny");
                            parseresult2 = Int32.TryParse(Console.ReadLine(), out a2);
                        }
                        while (!parseresult2 && a2 > 0);


                        //Convertion do binary
                        do
                        {

                            if (a2 % 2 == 1)
                            {
                                wynik = "1" + wynik;
                            }
                            else if (a2 % 2 == 0)
                            {
                                wynik = "0" + wynik;
                            }
                            a2 = a2 / 2;
                        }
                        while (a2 > 0);

                        Console.WriteLine(wynik);
                        break;
                    case 10:
                        //Najmniejsza wspólna wielokrotność 2 liczb
                        int a3 = 0;
                        int b3 = 0;
                        int k = 1;
                        int wynik3 = 0;
                        int wynik1 = 0;
                        int wynik2 = 0;
                        bool parseresult3;

                        do
                        {
                            Console.WriteLine("Podaj pierwszą liczbe do wyszukania najmniejszej wspólnej wielokrotności");
                            parseresult3 = Int32.TryParse(Console.ReadLine(), out a3);
                        }
                        while (!parseresult3 && a3 > 0);

                        do
                        {
                            Console.WriteLine("Podaj drugą liczbe do wyszukania najmniejszej wspólnej wielokrotności");
                            parseresult3 = Int32.TryParse(Console.ReadLine(), out b3);
                        }
                        while (!parseresult3 && a3 > 0);

                        //Calculation

                        do
                        {
                            wynik1 = a3 * k;
                            wynik2 = b3 * k;
                            k++;
                        }
                        while (wynik1 % b3 != 0 && wynik2 % a3 != 0);

                        if (wynik1 % b3 == 0 && wynik2 % a3 != 0)
                        {
                            wynik3 = wynik1;
                        }
                        else if (wynik2 % a3 == 0 && wynik1 % b3 != 0)
                        {
                            wynik3 = wynik2;
                        }
                        else if (wynik1 >= wynik2)
                        {
                            wynik3 = wynik2;
                        }
                        else if (wynik1 < wynik2)
                        {
                            wynik3 = wynik1;
                        }

                        Console.WriteLine($"Najmniejsza wspólna wielokrotność liczb {a3} i {b3} to: {wynik3}");
                        break;
                }
                Console.WriteLine("\n");


            }
            while (nr_zadania != 11);
        }
    }
}
