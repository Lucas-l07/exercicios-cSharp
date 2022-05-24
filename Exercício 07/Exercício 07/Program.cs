using System;

namespace Exercício_07 {
    class Program {
        static void Main(string[] args) {
            int num = 1;

            while (num != 0) {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(num, 2));
            }
        }
    }
}
