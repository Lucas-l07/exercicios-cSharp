using System;

namespace Exercício_06 {
    class Program {
        static void Main(string[] args) {
            int sum=0;
            string[] vetor = Console.ReadLine().Split(' ');

            for (int i = int.Parse(vetor[0]); i <= int.Parse(vetor[1]); i++) {
                if (i % 2 != 0) {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
