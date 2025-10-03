namespace ADP_Lab02;

public interface IShape
{
    double CalculateArea();
}

class Circle : IShape
{
    private double _radius;
    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}

class Square : IShape
{
    private double _side;
    public Square(double side)
    {
        _side = side;
    }

    public double CalculateArea()
    {
        return _side * _side;
    }
}