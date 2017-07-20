using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Tesla:ICar, IElectricCar
{
    public string Model
    {
        get;
    }
    public string Color { get; }
    public int Battery { get; }
    public Tesla(string model, string color, int batteries)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = batteries;
    }
    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

  

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
         sb.AppendLine($"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}

