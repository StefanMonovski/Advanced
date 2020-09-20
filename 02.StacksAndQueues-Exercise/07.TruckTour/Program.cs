using System;
using System.Collections.Generic;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPetrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> inputData = new Queue<int[]>();
            for (int i = 0; i < totalPetrolPumps; i++)
            {
                int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                inputData.Enqueue(input);
            }
            int firstPumpCompletedTour = 0;
            bool completeTour = false;
            for (int i = 0; i < totalPetrolPumps; i++)
            {
                if (completeTour)
                {
                    break;
                }
                Queue<int[]> currentTour = new Queue<int[]>(inputData);
                int[] nextTourLastPump = inputData.Dequeue();
                inputData.Enqueue(nextTourLastPump);
                int amountPetrol = 0;
                int distanceNextPetrol = 0;
                for (int j = 0; j < totalPetrolPumps; j++)
                {
                    int[] currentPump = currentTour.Dequeue();
                    amountPetrol += currentPump[0];
                    distanceNextPetrol = currentPump[1];
                    if (amountPetrol < distanceNextPetrol)
                    {
                        currentTour = inputData;
                        break;
                    }
                    else
                    {
                        amountPetrol -= distanceNextPetrol;
                        currentTour.Enqueue(currentPump);
                    }
                    if (j == totalPetrolPumps - 1)
                    {
                        firstPumpCompletedTour = i;
                        completeTour = true;
                    }
                }
            }
            Console.WriteLine(firstPumpCompletedTour);
        }
    }
}
