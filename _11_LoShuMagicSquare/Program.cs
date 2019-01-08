using System;

namespace _11_LoShuMagicSquare
{
    class MainClass
    {

        private static int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        private static Random rand = new Random();

        public static void Main(string[] args)
        {
        }

        private static void SwitchCells()
        {
            int[] number1 = new int[2];
            int[] number2 = new int[2];

            number1[0] = rand.Next(0, 3);
            number1[1] = rand.Next(0, 3);
            number1[0] = rand.Next(0, 3);
            number1[1] = rand.Next(0, 3);

            int temp = numbers[number1[0], number1[1]];
            numbers[number1[0], number1[1]] = numbers[number2[0], number2[1]];
            numbers[number2[0], number2[1]] = temp;

        }


    }
}
