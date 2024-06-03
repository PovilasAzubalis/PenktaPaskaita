using _2AntraUzduotis_KortuZaidimas.Models;

namespace AntraUzduotis_KortuZaidimas
{
        public class Program
        {
                public static void Main(string[] args)
                {
                        Kortos kalade1 = new Kortos();
                        kalade1.Isspausdinti();

                        Console.WriteLine("\n");

                        kalade1.Sumaisyti();
                        kalade1.Isspausdinti();



                }


        }
}