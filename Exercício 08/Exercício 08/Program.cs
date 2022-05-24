using System;

namespace Exercício_08 {
    class Program {
        static void Main(string[] args) {
            int n, a, b;

            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            int i = a;
            while (i <= b) {
                if (i % n == 0) {
                    Console.WriteLine(i);
                }
                i += n;
            }
        }
    }
}
