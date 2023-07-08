using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow
{
    internal class Rainbow
    {
        public delegate void RGBColorHandler(int red, int green, int blue);

        public static void GetRGBColor(string color, RGBColorHandler rgbColorHandler)
        {
            switch (color.ToLower())
            {
                case "red":
                    rgbColorHandler(255, 0, 0);
                    break;
                case "orange":
                    rgbColorHandler(255, 165, 0);
                    break;
                case "yellow":
                    rgbColorHandler(255, 255, 0);
                    break;
                case "green":
                    rgbColorHandler(0, 128, 0);
                    break;
                case "blue":
                    rgbColorHandler(0, 0, 255);
                    break;
                case "indigo":
                    rgbColorHandler(75, 0, 130);
                    break;
                case "violet":
                    rgbColorHandler(148, 0, 211);
                    break;
                default:
                    Console.WriteLine("Invalid color.");
                    break;
            }
        }
    }

    class Programe
    {
        static void Main()
        {
            Rainbow.GetRGBColor("red", (red, green, blue) =>
            {
                Console.WriteLine($"Red: {red}, Green: {green}, Blue: {blue}");
            });

            Rainbow.GetRGBColor("blue", (red, green, blue) =>
            {
                Console.WriteLine($"Red: {red}, Green: {green}, Blue: {blue}");
            });

            Rainbow.GetRGBColor("yellow", (red, green, blue) =>
            {
                Console.WriteLine($"Red: {red}, Green: {green}, Blue: {blue}");
            });
        }
    }
}
