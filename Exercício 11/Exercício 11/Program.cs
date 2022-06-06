using System;

namespace Exercício_11 {
    class Program {
        static void Main(string[] args) {
            int volume;
            int command;

            volume = int.Parse(Console.ReadLine());
            command = int.Parse(Console.ReadLine());

            while (command != 0) {
                
                volume += command;

                if (volume > 100) {
                    volume = 100;
                }
                if (volume < 0) {
                    volume = 0;
                }

                Console.WriteLine(volume);
                command = int.Parse(Console.ReadLine());
            }
        }
    }
}
