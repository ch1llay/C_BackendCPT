using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = 0;
                int y = a / b;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
