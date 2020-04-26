using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_With_For_Loops
{
    class FunWithLoops
    {
        //public int repetition;
        public string forLoop;

        //Enter the amount of times you want the loop to run

        public FunWithLoops()
        {
            
        }
        public void LoopsMethod()
        {
            //Console.WriteLine();
            //int repetition = int.Parse(Console.ReadLine());
            string forLoop = ("Hello World");

            
            for (int i = 0; i < 11; i++)
            {
                //forLoop += " " + i + " ";
                Console.WriteLine(i);
                //Console.ReadLine();
            }
        }
    }   
}
