using System;
using System.Drawing;

namespace ColorSpheres
{
    class Sphere{
        private readonly Color cor;
        private float raio;
        private  int quantasVezesAtirada;

        private  const int quantasVezesAtiradamin = 0;
        public Sphere(Color cor,float r){
            this.cor = cor;
            raio = r;
            quantasVezesAtirada = quantasVezesAtiradamin;

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