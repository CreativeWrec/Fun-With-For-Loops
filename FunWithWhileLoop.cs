using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_With_For_Loops
{
    class FunWithWhileLoop
    {
        public string userInput;
        public int counter;

        public FunWithWhileLoop()
        {

        }

        public void WhileLoopMethod()
        {
            Console.WriteLine("Please enter the number 42");
            userInput = Console.ReadLine();
            //userInput += Convert.ToInt32(Console.ReadLine());
            //int counter = Int32.Parse(userInput);
            //Console.WriteLine(counter);

            while(userInput != "42")
            {
                //userInput += counter;
                //counter++;
                
                Console.WriteLine("Try again. Please enter the number 42");
                userInput = Console.ReadLine();
            }
            

        }
    }
}
