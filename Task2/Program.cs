var car = new Car("red",100.1,"bmw");

var bus = new Bus("white",102.1,"mersedes");

public class IInterface
{
    void MoveLeft() {}
    void MoveRight() {}
}
public class Car : IInterface
{
    string _color;
    double _speed;
    string _model;
    public Car(string color,double speed,string model)
    {
        _color = color;
        _speed = speed;
        _model = model;
    }
    public void  MoveLeft()
    {
        System.Console.WriteLine("Left");
    }
    public void MoveRight()
    {
        System.Console.WriteLine("Right");
    }
}
public class Bus : IInterface
{
    string _color;
    double _speed;
    string _model;
    public Bus(string color,double speed,string model)
    {
        _color = color;
        _speed = speed;
        _model = model;
    }
     public void  MoveLeft()
    {
        System.Console.WriteLine("Left");
    }
    public void MoveRight()
    {
        System.Console.WriteLine("Right");
    }
}