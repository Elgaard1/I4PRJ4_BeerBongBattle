﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unosquare.RaspberryIO;
using Unosquare.RaspberryIO.Abstractions;
using Unosquare.WiringPi;

namespace Sensor
{
    public class MagnetSensor : ISensor
    {
        public void Initiate()
        {
            Pi.Init<BootstrapWiringPi>();
        }
        public bool Detected()
        {
            var magnet = Pi.Gpio[17];
            magnet.PinMode = GpioPinDriveMode.Input;
            if (magnet.Read() == false)
            {
                //Console.WriteLine("No Magnet detected");
                return false;
            }
            else
            {
                //Console.WriteLine("Magnet detected");
                return true;
            }
        }
    }
}
