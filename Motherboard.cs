using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Text;

namespace Fun_With_For_Loops
{
    class Motherboard
    {
        public string Manufacturer;
        public RAM TemporaryMemory;
        public CPU Processor;
        public HardDrive Storage;
        public GPU Graphics;

        public Motherboard (string manufacturer, RAM ram, CPU cpu, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }

        public void InstallApplication(Application applications)
        {
            if (TemporaryMemory.TotalGigabytes > applications.RequiredRAM && Storage.AvailableStorage > applications.RequiredStorage)
            {
                Storage.ApplicationsInHardDrive.Add(applications);
            }
        }   

    }
}
