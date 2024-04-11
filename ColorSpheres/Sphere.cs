using System;
using System.Drawing;

namespace ColorSpheres
{
    class Sphere{
        private Color cor;
        private float raio;
        private int quantasVezesAtirada;
        public Sphere(Color cor,float r){
            this.cor = cor;
            raio = r;
            quantasVezesAtirada = 0;

        }  
        
        public void pop(){
            raio = 0f;
        }
        public void Throw(){
            if (raio > 0) quantasVezesAtirada +=1;
        }
        public int GerTimesThrown(){
            return quantasVezesAtirada;
        }

    }
}