using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            int kol1 = 0;
            int kol2 = 0;
            string line = Console.ReadLine();
            for (int i = 97; i < 123; i++)
            {
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == i)
                    {
                        kol1++;
                    }
                }
            }

            for (int i = 65; i < 90; i++)
            {
                for (int j = 0; j < line.Length; j++)
                {
                    if (line[j] == i)
                    {
                        kol2++;
                    }
                }


            }
            if (kol1 > kol2)
            {
                Console.WriteLine(line.ToLower());
            }
            else if (kol1 < kol2)
            {
                Console.WriteLine(line.ToUpper());
            }
            else if (kol1 == kol2)
            {
                Console.WriteLine(line.ToLower());
            }
            Console.ReadKey();
        }
    }
}