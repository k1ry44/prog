using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

           
            int n = Convert.ToInt32(Console.ReadLine());
            string[] partys = new string[n];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                string party = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1];
                j = 0;
                while(party != partys[j] && partys[j] !=null)
                {
                    j++;
                }
                partys[j] = party;

            }
            Console.WriteLine("\n--------------\n");
            j = 0;
            while(partys[j] != null)
            {
                Console.WriteLine("Party " + partys[j]);
                j++;
            }
            
           
            Console.ReadKey();
        }
    }
}


