using System;
using System.Collections.Generic;
using System.Text;

namespace Fun_With_For_Loops
{
    abstract class Application
    {
        public string ApplicationName;
        public string ApplicationType;
        public double RequiredRAM;
        public double RequiredStorage;

        
        public Application()
        {
            ApplicationName = "Slack";
            ApplicationType = "Messaging service";
            RequiredRAM = 4.0; //In Gigabytes
            RequiredStorage = 0.512; //In Gigabytes
        }

    }
}
