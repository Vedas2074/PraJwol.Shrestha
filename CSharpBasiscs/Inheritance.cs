using System;
public abstract class Shape // here abstract does not allow to make other object of its class but can be inherite
{
    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual void PrintDetails()
    {
        Console.WriteLine("Printing Detail For Shape...");
    }    

}

    public interface IDiagonalComputable
    {
        public double GetDiagonalLength();
    }
    public class Rectangle : Shape, IDiagonalComputable
    {
        public Rectangle(double l, double b)
        {
            this.Length = l;
            this.Breadth = b;
        }
public class Square : Rectangle
{
    public Square(double s) : base(s, s)
    {

    }
   
}

      public double Length {get; set;}
      public double Breadth { get; set;}
      public override double GetArea() => Length * Breadth ;
      public double GetDiagonalLength() => Math.Sqrt(Length * Length + Breadth * Breadth);
      public override double GetPerimeter() => 2 * (Length+Breadth);

}
public class Circle : Shape
{
    public Circle(double r)
    {
        Radius = r; 
    }
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