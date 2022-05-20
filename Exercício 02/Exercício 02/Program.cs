using System;

namespace Exercício_02 {
    class Program {
        static void Main(string[] args) {
            double note1, note2, note3, finalNote;

            string[] vet = Console.ReadLine().Replace('.', ',').Split(' ');
            note1 = double.Parse(vet[0]);
            note2 = double.Parse(vet[1]);
            note3 = double.Parse(vet[2]);

            finalNote = double.Parse(teste(note1, note2, note3).ToString("F2"));

            Console.WriteLine(finalNote);

            if (finalNote < 60.00) {
                Console.WriteLine("DEPENDENCIA");
            }
        }
        public static double teste(double note1, double note2, double note3) {
            double finalNote = note1 + note2 + note3;
            return finalNote;
        }

    }
}
