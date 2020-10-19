using System;

namespace MostFrequentCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string strValue;
                int max = 0;
                do
                {
                    Console.Write("Enter string:");
                    strValue = Console.ReadLine();

                    if (string.IsNullOrEmpty(strValue))
                    {
                        Console.WriteLine("Empty input, please try again");
                    }
                    else
                    {
                        Console.WriteLine(string.Format("Frequent character = '{0}', count:'{1}'", GetMostFrequentCharacter(strValue.ToLowerInvariant(), ref max), max));

                        Console.Write("Do you want to continue (Y/N)? ");
                    }
                } while (string.IsNullOrEmpty(strValue) || Console.ReadLine().ToLower() == "y");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Get most frequent character with count
        /// </summary>
        /// <param name="strValue"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        private static char GetMostFrequentCharacter(string strValue, ref int max)
        {
            int[] count = new int[255];
            char result = char.MinValue;
            Array.Clear(count, 0, count.Length - 1);

            foreach (char chr in strValue)
            {
                if (++count[chr] > max)
                {
                    max = count[chr];
                    result = chr;
                }
            }
            return result;
        }
    }
}
