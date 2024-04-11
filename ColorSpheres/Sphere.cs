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
            Console.WriteLine("Sphere was popped");
            raio = 0f;
        }
        public void Throw(){
            if (raio > 0){
                quantasVezesAtirada +=1; 
                Console.WriteLine("Sphere was Thrown");
            } else{
                Console.WriteLine("Sphere is popped cannot be thrown");
            }

        }
        public void GerTimesThrown(){
            Console.WriteLine($"Sphere was Thrown {quantasVezesAtirada} times");
        }

    }
}