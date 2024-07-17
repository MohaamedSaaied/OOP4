using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Question 01:

//Define an interface named IShape with a property Area and a method DisplayShapeInfo.
//Create two interfaces, ICircle and IRectangle, that inherit from IShape.
//Implement these interfaces in classes Circle and Rectangle.
//Test your implementation by creating instances of both classes and displaying their shape information.


#endregion
namespace OOP4
{
    
    public interface IShape
    {
       public double Area {  get;  }
       public void DisplayShapeInfo();
    }
    public interface ICircle : IShape
    {
        public double Radius { get; set; }
    }
    public interface IRectangle:IShape
    {
        double Length { get; set; }
        double Width { get; set; }
    }
    public class Circle : ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The are of this Cirle is {Area}");
        }
    }
    public class Rectangle : IRectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area => (Length+Width)*2;
        public Rectangle(double Length,double Width)
        {
            this.Length = Length;
            this.Width = Width;
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"The are of this Rectangle is {Area}");
        }
    }
}
