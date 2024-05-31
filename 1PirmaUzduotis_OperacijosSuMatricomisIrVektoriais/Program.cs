namespace PirmaUzduotis_OperacijosSuMatricomisIrVektoriais
{
        public class Program
        {
                public static void Main(string[] args)
                {

                }

        }

        public class Matrica(string[] args)
        {
                int[,] matrica1 = { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

                int x = matrica1.GetLength(0);
                int y = matrica1.GetLength(1);
                int y = matrica1.GetLength(2);
                IsvestiMatrica(ref int x, ref int y, ref int z);

                static void IsvestiMatrica(ref int x, ref int y, ref int z)
                {
                        for (int i = 0; i < x; i++)
                        {
                                Console.Write(x);

                                for (int j = 0; j < numbers.GetLength(1); j++)
                                {
                                        Console.Write(Matrica.matrica1[i, j] + " ");

                                }
                                Console.WriteLine();
                        }
                }


        }
