using System;

namespace Exercício_01 {
    class Program {
        static void Main(string[] args) {

            int initialVolume, pumpFlow, time, poisonVolume;

            initialVolume = int.Parse(Console.ReadLine());
            pumpFlow = int.Parse(Console.ReadLine());
            time = int.Parse(Console.ReadLine());

            poisonVolume = initialVolume - (pumpFlow * time);

            if (poisonVolume < 0) {
                Console.WriteLine("nao eh possivel");
            }
            else {
                Console.WriteLine(poisonVolume);
            }
        }
    }
}
