using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class ElectricalDevice
    {
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        public void SwitchOn()
        {
            IsOn = true;
        }

        public void SwitchOff()
        {
            IsOn = false;
        }

        /*public void TuneDevice(string deviceName)
        {
            if (IsOn && deviceName == "TV")
            {
                Console.WriteLine("Watching TV!");
            }else if (IsOn && deviceName == "Radio" )
            {
                Console.WriteLine("Listening to the Radio");
            }
            else
            {
                Console.WriteLine( "{0} is switched off, switch it on first", deviceName);
            }
        }*/
    }
}
