using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace _2AntraUzduotis_KortuZaidimas.Models
{
        // Sukurti klasę korta
        // Kuri gali turėti 4 skirtingas reiksmes(string)
        // clubs(:clubs:), diamonds(:diamonds:), hearts(:hearts:) and spades(:spades:) Ir eilesNumeris(string)
        internal class Kortos
        {
                public Korta[] kalade;
                public int kortosNr;
                const int kaladesDydis = 52;
                Random rnd;


                public Kortos()
                {
                        string[] KortuVertesString = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                        string[] KortuTipai = { "♥", "♦", "♣", "♠" };      //"Hearts", "Diamonds", "Clubs", "Spades"
                        kalade = new Korta[kaladesDydis];
                        kortosNr = 0;
                        rnd = new Random();
                        for (int i = 0; i < kalade.Length; i++)
                                kalade[i] = new Korta(KortuVertesString[i % 13], KortuTipai[i / 13]);
                }

                public void Isspausdinti()
                {
                        for (int i = 0; i < kalade.Length; i++)
                        {
                                Console.Write($"{kalade[i].ToString()} ");
                        }

                }

                public void Sumaisyti()
                {
                        kortosNr = 0;

                        for(int i =0; i < kalade.Length; i++)
                        {
                                int randomNr = rnd.Next(kaladesDydis);
                                Korta tempKorta = kalade[i];
                                kalade[i] = kalade[randomNr];
                                kalade[randomNr] = tempKorta;
                        }

                }



        }
}
