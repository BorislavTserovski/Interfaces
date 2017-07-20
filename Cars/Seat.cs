using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Seat: ICar
{
    public string Model { get; }
    public string Color { get; }

    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
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
        sb.AppendLine($"{this.Color} Seat {this.Model}");
        sb.AppendLine(this.Start());
        sb.Append(this.Stop());
        return sb.ToString();
    }
}

