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
            List<IBirthable> living = new List<IBirthable>();
           while (input!="End")
           {
               string[] args = input.Split();
               string type = args[0];
               switch (type)
               {
                    case "Robot":
                        string model = args[1];
                        string id = args[2];
                        IInhabitant robot = new Robot(id, model);
                        inhabitants.Add(robot);
                        break;
                    case "Pet":
                        string nameOfPet = args[1];
                        string birthday = args[2];
                        IBirthable pet = new Pet(birthday, nameOfPet);
                        living.Add(pet);
                        break;;
                    case "Citizen":
                        string nameOfPerson = args[1];
                        int age = int.Parse(args[2]);
                        string idOfPerson = args[3];
                        string birthdayOfPerson = args[4];
                        IBirthable person = new Citizen(idOfPerson, nameOfPerson, age, birthdayOfPerson);
                        IInhabitant citizen = new Citizen(idOfPerson, nameOfPerson, age, birthdayOfPerson);
                        inhabitants.Add(citizen);
                        living.Add(person);
                        break;
               }
               input = Console.ReadLine();
           }

           string year = Console.ReadLine();

           foreach (var creature in living)
           {
               if (creature.BirthDay.EndsWith(year))
               {
                    Console.WriteLine(creature.BirthDay);
               }
           }
       }
    }
}
