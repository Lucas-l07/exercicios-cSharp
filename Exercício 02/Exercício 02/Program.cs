using System;

namespace Exercício_02 {
    class Program {
        static void Main(string[] args) {
            double note1, note2, note3, finalNote;
            //lucas braatz
            string[] vet = Console.ReadLine().Split(' ');
            note1 = double.Parse(vet[0]);
            note2 = double.Parse(vet[1]);
            note3 = double.Parse(vet[2]);

            finalNote = note1 + note2 + note3;

            Console.WriteLine(finalNote.ToString("F2"));

            if (finalNote < 60.00) {
                Console.WriteLine("DEPENDENCIA");
            }
        }
    }
}
