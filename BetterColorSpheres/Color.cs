using System;
using System.Drawing;

namespace BetterColorSpheres
{
    class Color{
        private readonly byte r ;
        private readonly byte g;
        private readonly  byte b;
        private readonly byte a;
        private const byte aplhamax = 255;
        public Color(byte red,byte green,byte blue,byte alpha){
            r = red;
            g = green;
            b = blue;
            a = alpha;

        }         
        public Color(byte red,byte green,byte blue){
            r = red;
            g = green;
            b = blue;
            a = aplhamax;

        } 
        public byte GetRed{
            get{
                return r;
            }     
        }
        public byte GetGreen{
            get{
                return g;
            }
        }
        
        public byte GetBlue{
            get{
                return b;
            }
        }
        public byte GetAlpha{
            get{
                return a;
            }
        }

        public int GetGrey(int red, int green, int blue){
            return (red+green+blue)/3;
        }
            
        
        

    }


}
