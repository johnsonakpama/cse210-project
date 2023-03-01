using System;

class Program
{
    static void Main(string[] args)
    {
      List<Shape> Shape = new List<Shape>();  
    }
     Square s1 = new Square("blue",3);
     Shapes.Add(s1);

     Rectangle s2 = new Rectangle("red",4,5);
     Shapes.Add(s2);

     Circle s3 = new Circle("Yellow",6);
     Shapes.Add(s3);

     foreach (Shape s in Shapes)
     {
        // Notice that all shape have a GetColor method from the Super class

        string Color = s.GetColor();
        // Notice that all Shapes have a GetArea method, but the behavior is 
        // different from each type of Shape
        double area = s.GetArea();

        Console.WriteLine($"The {Color}Shape has an area of {area}.");

     }
    
 
    
}