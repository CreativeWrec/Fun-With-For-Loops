using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_With_For_Loops
{
    class FunWithLoops
    {
        //public int repetition;
        public string forLoop;
        public string userInput;

        //Enter the amount of times you want the loop to run

        public FunWithLoops()
        {

        }
        public void LoopsMethod()
        {
            //Console.WriteLine();
            //int repetition = int.Parse(Console.ReadLine());

            userInput = "Hello World";

            for (int i = 0; i < userInput.Length; i++)
            {
                if (i % 3 == 0)
                    //forLoop += " " + i + " ";
                Console.WriteLine(userInput[i]);
                Console.ReadLine();
            }
        }

        public void AddTwoNumbers()
        {
            Console.WriteLine("please enter the first number:");
            int numberOne = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the second number");
            int numberTwo = int.Parse(Console.ReadLine());

            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addition is: " + result);
        }
    }
}
