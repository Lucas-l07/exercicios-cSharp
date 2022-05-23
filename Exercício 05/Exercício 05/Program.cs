using System;

namespace Exercício_05 {
    class Program {
        static void Main(string[] args) {
            double highestValue = 0;
            string[] vetor = Console.ReadLine().Split(' ');

            // vector reading
            for(int i=0; i < vetor.Length; i++) {
                if(double.Parse(vetor[i]) > highestValue) {
                    highestValue = double.Parse(vetor[i]);
                }
            }

            Console.WriteLine(highestValue.ToString("F2"));
        }
    }
}
