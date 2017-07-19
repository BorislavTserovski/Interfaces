using System;
using System.Collections.Generic;

namespace ExcplicitInterfaces
{
    public class StartUp
    {
      public static void Main()
      {

          string input = Console.ReadLine();
            List<Citizen>citizens = new List<Citizen>();
          while (input!="End")
          {
              string[] args = input.Split();
              string name = args[0];
              string country = args[1];
              int age = int.Parse(args[2]);
              Citizen citizen = new Citizen(name, country, age);
              citizens.Add(citizen);
              input = Console.ReadLine();
          }
          foreach (var citizen in citizens)
          {
              IPerson person = (IPerson)citizen;
              Console.WriteLine(person.GetName());
              IResident resident = (IResident) citizen;
              Console.WriteLine(resident.GetName());

          }
      }
    }
}
