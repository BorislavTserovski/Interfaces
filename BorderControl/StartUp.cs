using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class StartUp
    {
       public static void Main()
       {
           int n = int.Parse(Console.ReadLine());
           List<IBuyer> buyers = new List<IBuyer>();

           for (int i = 0; i < n; i++)
           {
               string inputLine = Console.ReadLine();
               string[] args = inputLine.Split();
               if (args.Length==3)
               {
                   string name = args[0];
                   int age = int.Parse(args[1]);
                   string group = args[2];
                   IBuyer buyer = new Rebel(name, age, group);
                   buyers.Add(buyer);
               }
               else if (args.Length==4)
               {
                   string name = args[0];
                   int age = int.Parse(args[1]);
                   string id = args[2];
                   string birthday = args[3];
                   IBuyer buyer = new Citizen(id, name, age, birthday);
                   buyers.Add(buyer);
               }
           }
           int total = 0;
           string nameOfBuyer = Console.ReadLine();
           while (nameOfBuyer!="End")
           {

               IBuyer currentBuyer = buyers.FirstOrDefault(b => b.Name == nameOfBuyer);
               if (buyers.Contains(currentBuyer))
               {
                   total += currentBuyer.BuyFood();
                }
               
               nameOfBuyer = Console.ReadLine();
           }
           Console.WriteLine(total);
       }
    }
}
