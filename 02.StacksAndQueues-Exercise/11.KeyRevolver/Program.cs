using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelCapacity = int.Parse(Console.ReadLine());
            List<string> inputBulletsData = Console.ReadLine().Split().ToList();
            Stack<int> bullets = new Stack<int>(inputBulletsData.Select(int.Parse));
            List<string> inputLocksData = Console.ReadLine().Split().ToList();
            Queue<int> locks = new Queue<int>(inputLocksData.Select(int.Parse));
            int intelligence = int.Parse(Console.ReadLine());
            int bulletsFired = 0;
            while (bullets.Count != 0 && locks.Count != 0)
            {
                bulletsFired++;               
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {
                    locks.Dequeue();
                    Console.WriteLine("Bang!");
                }
                else if (currentBullet > currentLock)
                {
                    Console.WriteLine("Ping!");
                }
                if (bulletsFired % barrelCapacity == 0 && bullets.Count != 0)
                {
                    Console.WriteLine("Reloading!");
                }
            }
            if (bullets.Count == 0 && locks.Count != 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                intelligence -= bulletsFired * bulletPrice;
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence}");
            }
        }
    }
}
