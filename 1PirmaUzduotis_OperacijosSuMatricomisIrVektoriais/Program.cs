namespace PirmaUzduotis_OperacijosSuMatricomisIrVektoriais
{
        //Sukurkite klasę Matrica, kuri turės dvimatį masyvą ir metodus:
        //IsvestiMatrica - išvesti matricą į konsolę.
        //Transponuoti - grąžina transponuotą matricą.
        //Sudeti - sudeda dvi matricas.
        //Dauginti - daugina matricą iš vektoriaus.
        //Sukurkite klasę Vektorius, kuri turės vienmatį masyvą ir metodą:
        //IsvestiVektorius - išvesti vektorių į konsolę.
        public class Program
        {
                public static void Main(string[] args)
                {
                        Matrica matrica = new Matrica();
                        matrica.RndMatrica();
                        matrica.IsvestiMatrica();

                        matrica.Transponuoti();

                        Matrica matrica1 = new Matrica();
                        matrica1.RndMatrica();

                        Matrica matrica2 = new Matrica();
                        matrica2.RndMatrica();

                        Matrica matricaSum = new Matrica();
                }

        }

        public class Matrica
        {

                int[,] matrica = new int[3, 3];

                public void RndMatrica()
                {
                        Random rnd = new Random();
                        for (int i = 0; i < matrica.GetLength(0); i++)
                        {
                                for (int j = 0; j < matrica.GetLength(1); j++)
                                {
                                        matrica[i, j] = rnd.Next(1, 10);
                                }
                        }
                }

                public void IsvestiMatrica()
                {
                        for (int i = 0; i < 3; i++)
                        {
                                Console.WriteLine();
                                for (int j = 0; j < 3; j++)
                                {
                                        Console.Write("{0} ", matrica[i, j]);
                                }
                        }
                        Console.WriteLine();
                }

                public void Transponuoti()
                {
                        for (int i = 0; i < 3; i++)
                        {
                                Console.WriteLine();
                                for (int j = 0; j < 3; j++)
                                {
                                        Console.Write("{0} ", matrica[j, i]);
                                }
                        }
                        Console.WriteLine();
                }

                public Matrica Sudeti(ref Matrica matrica1, ref Matrica matrica2, out Matrica matricaSum)
                {
                        for (int i = 0; i < 3; i++)
                        {
                                for (int j = 0; j < 3; j++)
                                {
                                        return matricaSum= matrica1[i,j] + matrica2[i,j];
                                }


                        }

                }
        }
}
