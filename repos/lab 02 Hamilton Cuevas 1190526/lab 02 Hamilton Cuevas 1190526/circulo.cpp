#include "pch.h"
#include <iostream>
#include "circulo.h"

Circulo::Circulo(double r ) {
	radio = r;
}

void Circulo::getPerimetro() {
	double perimetro = 2 * 3.14159 * radio;
	std::cout << "El perimetro del circulo es: " << perimetro << std::endl;
} 

void Circulo::getArea() {
	double area = 3.14159 * radio * radio;
	std::cout << "El area del circulo es: " << area << std::endl;
}

void Circulo::getVolumen() {
	double volumen = (4.0 /3.0) * 3.14159 * std::pow(radio, 3);
	std::cout << "El volumen del circulo es: " << volumen << std::endl;
}