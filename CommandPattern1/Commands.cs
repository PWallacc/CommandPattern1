using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern1
{
    public interface Commands
    {
        void execute();
    }

    public class LightOnCommand : Commands
    {
        Light mLight;

        public LightOnCommand(Light myLight)
        {
            mLight = myLight;
        }

        public void execute()
        {
            mLight.on();
        }
    }

    public class LightOffCommand : Commands
    {
        Light mLight;

        public LightOffCommand(Light myLight)
        {
            mLight = myLight;
        }

        public void execute()
        {
            mLight.off();
        }
    }

    public class StereoOnCommand : Commands
    {
        Stereo mStereo;

        public StereoOnCommand(Stereo myStereo)
        {
            mStereo = myStereo;
        }

        public void execute()
        {
            mStereo.on();
        }
    }

    public class StereoOffCommand : Commands
    {
        Stereo mStereo;

        public StereoOffCommand(Stereo myStereo)
        {
            mStereo = myStereo;
        }

        public void execute()
        {
            mStereo.off();
        }
    }

    public class noCommand : Commands
    {
        public noCommand()
        {
            //do nothing
        }

        public void execute()
        {
            Console.WriteLine("Empty slot.");
        }
    }
}
