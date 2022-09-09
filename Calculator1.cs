using System;

namespace HelloWorld
{
    class Calculator1
    {
        public int Calculator()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a operator: ");
            string op = Console.ReadLine();

            Console.Write("Enter a number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "-")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            return 1;
        }
    }
}