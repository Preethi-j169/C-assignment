using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    class assign3
    {
        static void prime(int[] arr, int n)
        {
       
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
      int limit = 1000000;
      int[] position = new int[limit + 1];

static void sieve()
{
    
    position[0] = -1;
    position[1] = -1;

 
    int pos = 0;
    for (int i = 2; i <= limit; i++)
    {
        if (position[i] == 0)
        {

            position[i] = ++pos;
            for (int j = i * 2; j <= limit; j += i)
                position[j] = -1;
        }
    }
}


 static void Main (String[] args)
{
    sieve();

    int n = 11;
    Console.Write(position[n]);
}
