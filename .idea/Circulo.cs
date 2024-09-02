using System;
namespace DefaultNamespace;

public class Circulo
{
    private double radio;

    public double Radio
    {
        get { return radio; }
        set { radio = value; }
    }
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    public double GetPerimeter()
    {
        double perimeter = (radio * 2) * (3.1416);
        return perimeter;
    }

    public double GetArea()
    {
        double area = (radio * radio) * (3.1416);
        return area;
    }
}

