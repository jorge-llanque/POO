using System;

namespace methodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5, 6);
            Add("hello", "world");
            Add(5.5, 6.6);
        }

        public static void Add(int x, int y)
        {
            int answer = x + y;
            Console.WriteLine(answer);
        }
        public static void Add(string x, string y)
        {
            string answer = x + " " + y;
            Console.WriteLine(answer);
        }
        public static void Add(double x, double y)
        {
            double answer = x + y;
            Console.WriteLine(answer);
        }
    }
}
