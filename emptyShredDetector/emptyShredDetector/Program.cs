using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Imaging;

namespace emptyShredDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            Bitmap bmp = new Bitmap("C:\\Users\\jacob\\Pictures\\image1.png");
            bool ans = isEmpty(bmp);
            Console.Write(ans);
            Console.ReadLine();
        }

        static bool isEmpty(Bitmap bmp)
        {
            ImageStatistics rgbStatistics = new ImageStatistics(bmp);
            int[] redValues = rgbStatistics.Red.Values;
            int[] greenValues = rgbStatistics.Green.Values;
            int[] blueValues = rgbStatistics.Blue.Values;

            int zeroTally = 0;

            for (int i = 0; i < 256; i++)
            {
                if (redValues[i] == 0)
                    zeroTally++;
                if (greenValues[i] == 0)
                    zeroTally++;
                if (blueValues[i] == 0)
                    zeroTally++;
            }

            bool output = zeroTally > 300;
            return output;
        }
    }
}
