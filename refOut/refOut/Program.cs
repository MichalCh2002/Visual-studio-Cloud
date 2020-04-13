using System;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var life = new Life(new[,]
            {
                { false, true, false },
                { false, true, false },
                { false, true, false }
            });

            while (true)
            {
                string str;
                life.Draw('X', out str);
                Console.WriteLine(str);
                life.NextGen();
            }
        }
    }
}
