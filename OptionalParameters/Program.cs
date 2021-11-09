using System;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(5);
            Add(5, z: 5);
        }

        public static void Add(int x, int y = 1, int z = 2)
        {
            int answer = x + y + z;
            Console.WriteLine(answer);
        }
    }
}
