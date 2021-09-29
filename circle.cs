using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class circle
    {
        public class Circle
        {
            private double radius;               
             double PI = 3.14159;   
             public Circle(double radius)
            {
                this.radius = radius;
            }
            public Circle()
            {
                radius = 0.0;
            }
            public void setRadius(double radius)
            {
                this.radius = radius;
            }
            public double getRadius()
            {
                return radius;
            }
            public double getArea()
            {
                return PI * radius * radius;
            }
            public double getDiameter()
            {
                return radius * 2;
            }
            public double getCircumference()
            {
                return 2 * PI * radius;
            }
        }
    }
}
