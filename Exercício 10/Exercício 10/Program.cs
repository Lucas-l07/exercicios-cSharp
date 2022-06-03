using System;

namespace Exercício_10 {
    class Program {
        static void Main(string[] args) {
            double[] media;
            int studentQuantity;

            studentQuantity = int.Parse(Console.ReadLine());
            media = new double[studentQuantity];

            for(int i=0; i < studentQuantity; i++) {
                string[] note = Console.ReadLine().Split(' ');
                media[i] = double.Parse(note[0]) + double.Parse(note[1]) + double.Parse(note[2]);

                Console.WriteLine(media[i].ToString("F2"));
            }

        }
    }
}
