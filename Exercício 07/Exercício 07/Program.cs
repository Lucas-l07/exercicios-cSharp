using System;

namespace Exercício_07 {
    class Program {
        static void Main(string[] args) {
            int num = 1;

            num = int.Parse(Console.ReadLine());

            while (num != 0) {
                Console.WriteLine(Math.Pow(num, 2));
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}
