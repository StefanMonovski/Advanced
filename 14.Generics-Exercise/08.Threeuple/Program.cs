using System;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstInput = Console.ReadLine().Split();
            Threeuple<string, string, string> firstThreeuple = new Threeuple<string, string, string>();
            firstThreeuple.FirstItem = firstInput[0] + " " + firstInput[1];
            firstThreeuple.SecondItem = firstInput[2];
            if (firstInput.Length == 3)
            {
                firstThreeuple.ThirdItem = firstInput[3];
            }
            else if (firstInput.Length > 3)
            {
                firstThreeuple.ThirdItem = string.Join(" ", firstInput, 3, firstInput.Length - 3);
            }
            string[] secondInput = Console.ReadLine().Split();
            Threeuple<string, int, bool> secondThreeuple = new Threeuple<string, int, bool>();
            secondThreeuple.FirstItem = secondInput[0];
            secondThreeuple.SecondItem = int.Parse(secondInput[1]);
            if (secondInput[2] == "drunk")
            {
                secondThreeuple.ThirdItem = true;
            }
            else if (secondInput[2] == "not")
            {
                secondThreeuple.ThirdItem = false;
            }
            string[] thirdInput = Console.ReadLine().Split();
            Threeuple<string, double, string> thirdThreeuple = new Threeuple<string, double, string>();
            thirdThreeuple.FirstItem = thirdInput[0];
            thirdThreeuple.SecondItem = double.Parse(thirdInput[1]);
            thirdThreeuple.ThirdItem = thirdInput[2];
            Console.WriteLine(firstThreeuple.ToString());
            Console.WriteLine(secondThreeuple.ToString());
            Console.WriteLine(thirdThreeuple.ToString());
        }
    }
}
