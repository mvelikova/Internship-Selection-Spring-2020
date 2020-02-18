using System;

namespace MedianScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[] { 100, 20, 50, 70, 45 };

            int[] output = CalculculateScores(scores);

            for (int i = 0; i < output.Length; i++)
            {
                Console.WriteLine(output[i]);
            }
        }



        static int[] CalculculateScores(int[] scores)
        {
            int[] output = new int[scores.Length];

            if (scores.Length < 1)
            {
                throw new ArgumentException("INVALID INPUT ENTRY...");
            }

            output[0] = scores[0];

            for (int i = 0; i < scores.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (scores[j - 1] > scores[j])
                    {
                        int temp = scores[j - 1];
                        scores[j - 1] = scores[j];
                        scores[j] = temp;
                    }
                }
                if (i % 2 == 0)
                {
                    output[i + 1] = (int)Math.Ceiling((decimal)(scores[i / 2] + scores[i / 2 + 1]) / 2);
                }
                else
                {
                    output[i + 1] = scores[i / 2 + 1];
                }
            }
            return output;
        }
    }
}
