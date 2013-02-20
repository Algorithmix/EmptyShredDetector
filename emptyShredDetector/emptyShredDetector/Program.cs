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
            Bitmap bmp = new Bitmap("C:\\Users\\jacob\\Pictures\\shred.png");
            bool ans = isEmpty(bmp);
            Console.Write(ans);
            Console.ReadLine();
        }

        static bool isEmpty(Bitmap bmp)
        {
            int threshold = 80;  //threshold for number of zeroes in the histogram or number of missing grayscale values

            ImageStatistics rgbStatistics = new ImageStatistics(bmp);
            int[] redValues = rgbStatistics.Red.Values;
            int[] greenValues = rgbStatistics.Green.Values;
            int[] blueValues = rgbStatistics.Blue.Values;

            int zeroTally = 0;

            for (int i = 0; i < 256; i++)
            {
                int value = (redValues[i] + greenValues[i] + blueValues[i]) / 3;
                if (value == 0)
                    zeroTally++;
            }

            bool output = zeroTally > threshold;
            return output;
        }
    }
}
