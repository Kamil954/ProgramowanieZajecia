namespace ConsoleApp3
{
    internal class Program
    {

        static bool czyPalindrom(string text)
        {
            
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