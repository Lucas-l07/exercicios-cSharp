using System;

namespace Exercício_03 {
    class Program {
        static void Main(string[] args) {
            int widthPhoto, heightPhoto, widthPictureFrame, heightPictureFrame;
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            Program teste = new Program();
            widthPhoto = int.Parse(vet1[0]);
            heightPhoto = int.Parse(vet1[1]);
            widthPictureFrame = int.Parse(vet2[0]);
            heightPictureFrame = int.Parse(vet2[1]);

            if (teste.SizeVerify(widthPhoto, heightPhoto, widthPictureFrame, heightPictureFrame) == false) {
                widthPhoto = int.Parse(vet1[1]);
                heightPhoto = int.Parse(vet1[0]);

                if (teste.SizeVerify(widthPhoto, heightPhoto, widthPictureFrame, heightPictureFrame) == true) {
                    Console.WriteLine("SIM");
                }
                else {
                    Console.WriteLine("NAO");
                }
            }
            else {
                Console.WriteLine("SIM");
            }
        }
        public bool SizeVerify(int widthPhoto, int heightPhoto, int widthPictureFrame, int heightPictureFrame) {
            return (widthPhoto <= widthPictureFrame && heightPhoto <= heightPictureFrame);
        }

    }

}

