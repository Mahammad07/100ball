using System;

namespace reqemlerin_cemiii
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 19;
            int count = 0;
            int result = 0;

            if (number < 10)
            {
                Console.WriteLine("eded 10 ve ya 10 dan boyuk olmalidir");
            }
            else
            {
                for(int i = 0; i < 2; i++)
                {
                    result = number % 10;
                    number /= 10;
                    count += result;

                }
                

            }

            {
                Console.WriteLine(count);
            }

        }
    }
}
