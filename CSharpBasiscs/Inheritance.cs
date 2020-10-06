using System;
public abstract class Shape // here abstract does not allow to make other object of its class but can be inherite
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public void printDetail()
    {
        Console.WriteLine("Printing Detail For Shape...");
    }    

}

public class Square : Shape
{
    public double Side{ get; set; }
    public override double GetArea() => Side * Side;
    public override double GetPerimeter() => 4 * Side;
    
}
public class Rectangle : Shape
{
    public double Length {get; set;}
    public double Breadth { get; set;}
      public override double GetArea() => Length * Breadth ;
    public override double GetPerimeter() => 2 * (Length+Breadth);

}
public class Circle : Shape
{
    public double Radius{get; set;}
    public override double GetArea() => Math.PI * Radius *Radius;
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}

//Single ubgerutabce
// Multilevel inheritance
// Multiple inheritance

class A
{

}

class B : A
{

}
class C : B
{

}

// Multiple inheritance
class D : C, IX, IY
{

}
interface IX
{

}
interface IY
{

}