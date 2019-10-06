using System;

namespace PART3
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 3
            int num1, num2, add, sub, mul, div;
            Console.Write("----------Part 3----------\nEnter First integer number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second integer number : ");
            num2 = int.Parse(Console.ReadLine());
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = num1 / num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + add);
            Console.WriteLine(num1 + " - " + num2 + " = " + sub);
            Console.WriteLine(num1 + " * " + num2 + " = " + mul);
            Console.WriteLine(num1 + " / " + num2 + " = " + div);
        }
    }
}
