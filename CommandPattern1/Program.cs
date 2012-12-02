using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numButtons = 7;
            cRemote remote = new cRemote(numButtons);

            Light myLight = new Light("Bedroom");
            Light myKitchenLight = new Light("Kitchen");
            Stereo myStereo = new Stereo();

            LightOnCommand lightOn = new LightOnCommand(myLight);
            LightOffCommand lightOff = new LightOffCommand(myLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(myKitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(myKitchenLight);

            StereoOnCommand stereoOn = new StereoOnCommand(myStereo);
            StereoOffCommand stereoOff = new StereoOffCommand(myStereo);

            remote.setCommand(lightOn, lightOff, 0);
            remote.setCommand(kitchenLightOn, kitchenLightOff, 1);
            remote.setCommand(stereoOn, stereoOff, 2);

            for (int i = 0; i < numButtons; i++)
            {
                remote.onButtonPressed(i);
            }

            Console.WriteLine();

            for (int i = 0; i < numButtons; i++)
            {
                remote.offButtonPressed(i);
            }


            Console.ReadLine();
        }
    }
}
