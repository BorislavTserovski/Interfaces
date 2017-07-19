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
           string input = Console.ReadLine();
            List<IInhabitant>inhabitants = new List<IInhabitant>();
           while (input!="End")
           {
               string[] args = input.Split();
               if (args.Length==2)
               {
                   string model = args[0];
                   string id = args[1];
                    IInhabitant robot = new Robot(id, model);
                    inhabitants.Add(robot);
               }
               else if (args.Length==3)
               {
                   string name = args[0];
                   int age = int.Parse(args[1]);
                   string id = args[2];
                   IInhabitant citizen = new Citizen(id, name, age);
                   inhabitants.Add(citizen);
               }
               input = Console.ReadLine();
           }

           string fakeId = Console.ReadLine();

           foreach (var inhabitant in inhabitants)
           {
               if (inhabitant.Id.EndsWith(fakeId))
               {
                    Console.WriteLine(inhabitant.Id);
               }
           }
       }
    }
}
