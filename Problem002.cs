using System;

namespace ProjectEulerWorkspace
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var counter = 2;
            var prevCounter = 1;
            var prevXCounter = 1;
            
            var total = 0;
            
            while (counter < 4000000)
            {
                if (counter % 2 == 0)
                {
                    total += counter;
                }

                prevXCounter = prevCounter;
                prevCounter = counter;
                counter = prevCounter + prevXCounter;
            }
            
            Console.WriteLine(total);
            Console.ReadLine();
        }
    }
}
