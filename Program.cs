using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace EgetArbete
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Välj ett val:");
            Console.WriteLine(" 0) Stäng av programmet");
            Console.WriteLine(" 1) Skriv ut Hello world");
            Console.WriteLine(" 2) Förse namn och ålder");
            Console.WriteLine(" 3) Ändra färg på texten");
            Console.WriteLine(" 4) Vad är dagens datum");
            Console.WriteLine(" 5) Vilket nummer är störst?");
            Console.WriteLine(" 6) Gissa siffran!");
            Console.WriteLine(" 7) Spara text till en fil");
            Console.WriteLine(" 8) Skriv ut innehållet i en fil");
            Console.WriteLine(" 9) Roten ur, Upphöjt i 2 och 10");
            Console.WriteLine(" 10) Multiplikationstabel");
            Console.WriteLine(" 11) Sorterar talen");
            Console.WriteLine("##### 12)");
            Console.WriteLine("##### 13)");
            Console.WriteLine("##### 14)");
            Console.WriteLine("##### 15)");
            Console.WriteLine("##### 16)");
            Console.Write("\r\nVälj en siffra och tryck på ENTER: ");

            switch (Console.ReadLine())
            {
                case "0":
                    return false;
                case "1":
                    O1();
                    return true;
                case "2":
                    O2();
                    return true;
                case "3":
                    O3();
                    return true;
                case "4":
                    O4();
                    return true;
                case "5":
                    O5();
                    return true;
                case "6":
                    O6();
                    return true;
                case "7":
                    O7();
                    return true;
                case "8":
                    O8();
                    return true;
                case "9":
                    O9();
                    return true;
                case "10":
                    O10();
                    return true;
                case "11":
                    O11();
                    return true;
                case "12":
                    O12();
                    return true;
                case "13":
                    O13();
                    return true;
                case "14":
                    O14();
                    return true;
                case "15":
                    O15();
                    return true;
                case "16":
                    O16();
                    return true;
                default:
                    return true;
            }
        }

        private static void O1()
        {
            Console.Clear();
            Console.WriteLine("Hello world");
            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();

        }

        private static void O2()
        {
            Console.Clear();
            Console.WriteLine("Skriv ditt förnamn:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Skriv ditt efternamn:");
            string sureName = Console.ReadLine();
            Console.WriteLine("Skriv din ålder:");
            string age = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hejsan \r\n" + firstName + ' ' + sureName + "\r\nSå du är " + age + "år gammal");
            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O3()
        {
            if (Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            else
            {
                Console.ResetColor();
            }
        }

        private static void O4()
        {
            DateTime thisDay = DateTime.Today;
            Console.Clear();
            Console.WriteLine("Dagens datum är " + thisDay.ToString("D"));
            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O5()
        {
            Console.Clear();
            Console.WriteLine("Skriv första siffran");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv andra siffran");
            int secondNumber = int.Parse(Console.ReadLine());
            if (secondNumber > firstNumber)
            {
                firstNumber = secondNumber;
            }
            Console.WriteLine("Högsta talet är: " + firstNumber);
            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O6()
        {
            Random rand = new Random();
            int guess = 0;
            string welcome = "Gissa på en siffra mellan 1 och 100, kompis!";
            int num = rand.Next(1, 100);
            Console.WriteLine(welcome);


            int i = 0;

            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                    {
                        Console.WriteLine("Lägre");
                    }
                    else
                    {
                        Console.WriteLine("Högre");
                    }
                }

                catch
                {
                    Console.WriteLine("Måste vara ett nummer, kompis!");
                    i--;
                }


                i++;
            }
            Console.WriteLine("Grymt, det tog dig " + i + " gissningar");
            Console.ReadLine();
            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O7()
        {
            Console.Clear();
            Console.WriteLine("Skriv ditt förnamn:");
            string firstName = Console.ReadLine();

            string[] lines = 
            {
                firstName
            };

            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "input.txt")))
            {
                foreach (string line in lines)
                    outputFile.WriteLine(line);
            }

            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O8()
        {
            Console.Clear();
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string text = File.ReadAllText(Path.Combine(docPath, "input.txt"));
            
            Console.WriteLine("output = {0}", text);

            

            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O9()
        {
            Console.Clear();
            Console.WriteLine("Skriv in ett positivt tal:");
            double x = Convert.ToDouble(Console.ReadLine());
            double z = Math.Pow(x, 2);
            double y = Math.Pow(x, 10);
            double result = Math.Sqrt(x);

            Console.Clear();
            Console.WriteLine("Roten ur " + x + " är " + result);
            Console.WriteLine(x + " upphöjt i 2, är " + z);
            Console.WriteLine(x + " upphöjt i 10, är " + y);
            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O10()
        {
            Console.Clear();
            int j, n;

            Console.Write("Skriv en siffra för att få veta tabelen: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }
            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O11()
        {
            Console.Clear();
            int Min = 0;
            int Max = 100;

            Console.WriteLine(String.Join(",", Enumerable.Range(Min, Max).OrderBy(x => Guid.NewGuid()).Take(5).OrderBy(n => n)));

            Console.Write("\r\nTryck på ENTER för att komma tillbaka till huvudmenyn");
            Console.ReadLine();
        }

        private static void O12()
        {

        }

        private static void O13()
        {

        }

        private static void O14()
        {

        }

        private static void O15()
        {

        }

        private static void O16()
        {

        }
    }
}