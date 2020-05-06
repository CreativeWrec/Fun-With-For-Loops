using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_With_For_Loops
{
    class CalculatorMadness
    {
        public void AddTwoNumbers()
        {
            Console.WriteLine("please enter the first number:");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the second number");
            int numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addition is: " + result);
        }
        public void RunCalculations()
        {
            AddTwoNumbers(5, 7);

        }

    }

}
