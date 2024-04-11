using System;
using System.Drawing;

namespace ColorSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            //all colors
            Color red = new Color(255, 0,0,255);
            Color green = new Color(0, 255,0,255);
            Color blue = new Color(0, 0,255,255);
            //creates all spheres
            Sphere RedSphere = new Sphere(red, 2f);
            Sphere greenSphere = new Sphere(green, 4f);
            Sphere blueSphere = new Sphere(blue, 6f);

            RedSphere.pop();
            RedSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();
            RedSphere.GerTimesThrown();
            greenSphere.GerTimesThrown();
            blueSphere.GerTimesThrown();


            
        }
    }
}
