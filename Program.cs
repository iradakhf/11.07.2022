using System;
namespace ConsoleApp28
{
    class Program
    {
        public static void Main(string[] args)
        {

            string[,] smileys = new string[3, 2] { { ":)", ":D" }, { ":(", ":D" }, { ":)", ":<" } };


            Matrix matrix = new Matrix();
            int count = matrix.CountSmileyFace(smileys);

            Console.WriteLine(count);

        }
        public class Matrix
        {
            public int CountSmileyFace(string[,] smileys)
            {
                int count = 0;
                for (int i = 0; i < smileys.GetLength(0); i++)
                {
                    for (int j = 0; j < smileys.GetLength(1); j++)
                    {
                        if (smileys[i, j] == ":)" || smileys[i, j] == ":D")
                        {
                            count++;
                        }
                    }
                }
                return count;

            }
        }
    }
}