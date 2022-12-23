using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, i, j, flag;

            Console.WriteLine(
            "Enter N1: ");
            n1 = Convert.ToInt32(
            Console.ReadLine());

            Console.WriteLine(
            "Enter N2: ");
            n2 = Convert.ToInt32(
            Console.ReadLine());

            Console.Write("\nThe list of the prime numbers from  " + n1
                        + " to " + n2 + " are: ");

            if (n1 == 1)
            {
                Console.Write(n1 + " ");
                n1++;
                if (n2 >= 2)
                {
                    Console.Write(n1 + " ");
                    n1++;
                }
            }
            if (n1 == 2)
            {
                Console.Write(n1 + " ");
            }

            if (n1 % 2 == 0)
            {
                n1++;
            }

            for (i = n1; i <= n2; i = i + 2)
            {

                flag = 1;

                for (j = 2; j * j <= i; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
