using System.Collections;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {

       /* static bool czyPalindrom(string text)
        {
            if(text.Length==0) return false;
            {
                for (int i = 0; i < text.Length ; i++)
                {
                    {
                        if (text[i] != text[text.Length - i - 1])

                            return false;
                    }
                }
                return true;
            }
        }
       */

        /*
        static int from8to10(int number)
        {
            string numberString = number.ToString();
            int wynik = 0;
            for (int i = 0; i <numberString.Length; i++)
            {
                wynik +=(int) (int.Parse(numberString[i].ToString()) * Math.Pow(8, numberString.Length -i-1)); 
            }
        return wynik;
        }
        */
/*
        static double f( double x)
        {


            return x*x+2*x+3;
        }
*/
    static ArrayList naCzynniki(double liczba)
        {
            ArrayList lista = new ArrayList();
            int k = 2;
            while (liczba  != 1)
            {
                while (liczba %k == 0)
                    {


                    liczba = liczba / k;
                    lista.Add(k);
                }
                k++;
            }
            

            return lista;
        }
    static void Main(string[] args)
        {
            // Console.WriteLine(czyPalindrom("kajak"));
            //Console.WriteLine(from8to10(762));
            /* Cała
            double poczatek = 0;
            double koniec = 10;
            double h = 0.1;
            int n=(int) ((koniec - poczatek) / h);
            double pole = 0;
            for (int i = 0; i < n; i++)
            {
                double x0 = poczatek + i * h;
                double x1 = x0 + h;
                double a = f(x0);
                double b = f(x1);
                double poleTrapezu = ((a + b) / 2) * h;
                pole = pole + poleTrapezu;
            }
            Console.WriteLine($"Pole funkcji: {pole}");
            */

            ArrayList czynniki = naCzynniki(4314);
            foreach (var asdf in czynniki)
            {
                Console.WriteLine(asdf);
            }
            Console.WriteLine("witam serdecznie");
        }
    }
}