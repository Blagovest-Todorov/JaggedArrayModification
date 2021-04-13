using System;
using System.Linq;

namespace JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaggedArrRows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[jaggedArrRows][];

            for (int row = 0; row < jaggedArrRows; row++)
            {
                int[] arrNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jaggedArray[row] = new int[arrNumbers.Length];

                for (int col = 0; col < arrNumbers.Length; col++)
                {
                    jaggedArray[row][col] = arrNumbers[col]; // fill the jaggedArray
                }
            }

            while (true) 
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    //ToDo
                    PrintJaggedArray(jaggedArray);
                    break;
                }

                string[] parts = line.Split().ToArray();

                string command = parts[0];
                int currRow = int.Parse(parts[1]);
                int currCol = int.Parse(parts[2]);
                int currValue = int.Parse(parts[3]);
                

                if (currRow >= 0 && currRow <= jaggedArray.Length - 1 && currCol >= 0 && 
                    currCol <= jaggedArray[currRow].Length -1)
                {
                    if (command == "Add")
                    {
                        jaggedArray[currRow][currCol] += currValue;
                    }
                    else if (command == "Subtract")
                    {
                        jaggedArray[currRow][currCol] -= currValue;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                } 
            }
        }

        private static void PrintJaggedArray(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
