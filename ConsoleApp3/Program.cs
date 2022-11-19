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

    static void Main(string[] args)
        {
            // Console.WriteLine(czyPalindrom("kajak"));
            Console.WriteLine(from8to10(762));

        }
    }
}