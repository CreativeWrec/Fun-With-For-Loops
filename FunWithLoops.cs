using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_With_For_Loops
{
    class FunWithLoops
    {
        public int repetition;

        //Enter the amount of times you want the loop to run

        public FunWithLoops()
        {
            
        }
        public void LoopsMethod()
        {
            Console.WriteLine("How Many Times Would You Like For The Loop To Run?");

            int repetition = int.Parse(Console.ReadLine());

            Console.WriteLine("Run Loop:" + repetition + " Times");
            
            for (int i = repetition; 0 < i; i++)
            {
                Console.WriteLine();
            }
        }
    }   
}
