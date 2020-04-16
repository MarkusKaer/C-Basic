using System;

namespace my_console_app
{
    class GlazerCalc
    {
        static void Main(string[] args)
        {
            double width;
            double woodLength;
            double height;
            
            width = 3;
            height = 4;

            double glassArea = 2 * (width * height);

            woodLength = (width + height) * 2 * 3.25;

            Console.WriteLine("Længden af træet er "
                    + woodLength
                    + " fod");
            
            Console.WriteLine("areal af glas er " + glassArea);
        }
    }
}
