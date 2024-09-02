using System;
using System.Collections;
namespace DefaultNamespace;
    public class Circulo
    {
        private double radio; //creacion atributo

        public double Radio //para poder acceder luego al radio
        {
            get{return radio;}
            set { radio = value; }
        }

        public Circulo(double radio)
        {
            this.radio = radio;
        }
        public double GetPerimeter()
        {
            double perimetro = (radio * 2) * 3.1416; 
            return perimetro;
        }

        public double GetArea()
        {
            double area= (radio*radio)*3.1416
            return area;
        }
    }

    public class Program
    {
        public void CrearCirculo()
        {
            Circulo circulo = new Circulo(3.0);
            circulo.GetPerimeter();
            circulo.GetArea();
            Console
            
        }


    }
    