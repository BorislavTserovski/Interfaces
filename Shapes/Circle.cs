using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circle : IDrawable
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get { return this.radius; }
        private set { this.radius = value; }
    }
    public void Draw()
    {
        double r_In = this.Radius - 0.4;
        double r_Out = this.Radius + 0.4;

        for (double y = this.Radius; y >= -this.Radius; --y)
        {
            for (double x = -this.Radius; x < r_Out; x += 0.5)
            {
                double value = x * x + y * y;

                if (value >= r_In * r_In && value <= r_Out * r_Out)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();

        }
    }
}

