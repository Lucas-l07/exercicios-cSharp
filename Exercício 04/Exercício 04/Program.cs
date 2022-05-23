using System;

namespace Exercício_04 {
    class Program {
        static void Main(string[] args) {
            double glucoseValue;

            glucoseValue = double.Parse(Console.ReadLine());

            if (glucoseValue <= 100) {
                Console.WriteLine("NORMAL");
            }
            else if (glucoseValue <= 140) {
                Console.WriteLine("ELEVADO");
            }
            else {
                Console.WriteLine("DIABETES");
            }
        }
    }
}
