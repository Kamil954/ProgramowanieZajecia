namespace ConsoleApp3
{
    internal class Program
    {

        static bool czyPalindrom(string text)
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

    static void Main(string[] args)
        {
            Console.WriteLine(czyPalindrom("kajak"));
        }
    }
}