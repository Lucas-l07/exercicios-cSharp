using System;

namespace Exercício_09 {
    class Program {
        static void Main(string[] args) {
            double totalBatteryTime;
            int timesToPlay;
            double[] vetor;

            totalBatteryTime = double.Parse(Console.ReadLine());
            timesToPlay = int.Parse(Console.ReadLine());
            vetor = new double[timesToPlay];

            for (int i = 0; i < timesToPlay; i++) {
                vetor.SetValue(double.Parse(Console.ReadLine()), i);
                totalBatteryTime -= vetor[i];

                if (totalBatteryTime < 0) {
                    Console.WriteLine("recarregar");
                }
                else {
                    Console.WriteLine(totalBatteryTime.ToString("F1"));
                }
            }

        }
    }
}
