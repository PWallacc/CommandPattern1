using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern1
{

    public class Light
    {
        String mName;

        public Light( String lightName)
        {
            mName = lightName;
        }
        public void on()
        {
            Console.WriteLine(mName + " Lights On.");
        }
        public void off()
        {
            Console.WriteLine(mName + " Lights Off.");
        }
    }
}
