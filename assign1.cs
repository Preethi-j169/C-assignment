using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class assign1
    {
        static void prime(int[] arr, int n)
        {
            // Find maximum value in the array
            int max_val = arr.Max();
            List<bool> prime = new List<bool>();
            for (int i = 0; i < max_val + 1; i++)
                prime.Add(true);
            prime.Insert(0, false);
            prime.Insert(1, false);
            for (int p = 2; p * p <= max_val; p++)
            {
                if (prime[p] == true)
                {
                   for (int i = p * 2; i <= max_val; i += p)
                        prime.Insert(i, false);
                }
            }

            
            int maximum = int.MinValue;
            for (int i = 0; i < n; i++)
                if (prime[arr[i]])
                {
                   
                    maximum = Math.Max(maximum, arr[i]);
                }

           
            Console.WriteLine("Maximum : " + maximum);
        }

       
        public static void Main()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int n = arr.Length;

            prime(arr, n);
        }
    }
}

