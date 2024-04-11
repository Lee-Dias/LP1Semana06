using System;

namespace ColorSpheres
{
    class ColorSpheres{
        private byte r;
        private byte g;
        private byte b;
        private byte a;

        private byte alphaMax;
        public ColorSpheres(byte red,byte green,byte blue,byte alpha){
            r = red;
            g = green;
            b = blue;
            a = alpha;

        }         
        public ColorSpheres(byte red,byte green,byte blue){
            r = red;
            g = green;
            b = blue;
            a = alphaMax;

        } 
        public byte getred(){
            return r;
        }
        public byte getgreen(){
            return g;
        }
        
        public byte getblue(){
            return b;
        }
        public byte getalpha(){
            return a;
        }
        public byte getgrey(){
            int media = (r+g+b)/3;
            byte grey = (byte)media;
            return grey;
        }
        

    }


}
