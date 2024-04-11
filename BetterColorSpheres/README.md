classDiagram
Program o-- Sphere
Sphere --o Color

Program: Sphere RedSphere
Program: Sphere GreenSphere
Program: Sphere BlueSphere

Sphere: Color cor
Sphere: float raio
Sphere: int quantasVezesAtirada
Sphere: const int quantasVezesAtiradaMin
Sphere: const float raioreset

Color: readonly byte r 
Color: readonly byte g 
Color: readonly byte b 
Color: readonly byte a 
Color: const byte aplhamax 