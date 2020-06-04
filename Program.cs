using System;

namespace play_with_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many test cases?");
            int cases = int.Parse(Console.ReadLine());
            if (cases > 1000)
            {
                Console.WriteLine("Too much test cases.");
            }
            else
            {
                for (int i = 0; i < cases; i++)
                {
                    Console.WriteLine("Write A value: ");
                    int a = int.Parse(Console.ReadLine());

                    Console.WriteLine("Write B value: ");
                    int b = int.Parse(Console.ReadLine());

                    if (a > 1000000000 || b > 1000000000)
                    {
                        Console.WriteLine("values can't be grater than 1 000 000 000");
                    }
                    else
                    {
                        int g = GFG.gcd(a, b);

                        Console.Write(b / g);
                        Console.WriteLine(" {0}", a / g);
                    }


                }
            }
        }
    }

   public class GFG
    {
        public static int gcd(int x, int y)
        {
            if (x == 0)
                return y;

            else
            return gcd(y % x, x);
        }
    }
}
