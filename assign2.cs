using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class assign2
    {
        static void Main()
        {
            Console.WriteLine("PLEASE ENTER THE DAY");
            string day = Console.ReadLine();
            int n = int.Parse(day);
            if (n == 0 || n > 7)
            {
                Console.WriteLine("IT IS AN INVALID DAY");
            }
            else if (n <= 5)
            {
                Console.WriteLine("IT IS A WORKING DAY");
            }
            else
                Console.WriteLine("IT IS A HOLIDAY");
        }
    }
}
