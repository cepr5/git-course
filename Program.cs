using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_draft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 24, 24, 24 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            int[] b = Distinct(a);

            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

            Two two = new Two();
            Console.WriteLine("YES YES YES");
        }

        public static int[] Distinct(int[] array)
        {
            var intermediateArray = new int[array.Length];
            int uniqueCount = 0;
            for (int index = 0; index < array.Length; index++)
            {
                bool unique = true;
                for (int intermediateIndex = 0; intermediateIndex < uniqueCount; intermediateIndex++)
                {
                    if (intermediateArray[intermediateIndex] == array[index])
                    {
                        unique = false;
                        break;
                    }
                }
                if (unique)
                {
                    uniqueCount++;
                    intermediateArray[uniqueCount - 1] = array[index];
                }
            }
            var outArray = new int[uniqueCount];
            Array.Copy(intermediateArray, 0, outArray, 0, uniqueCount);
            return outArray;
        }
    }
}
