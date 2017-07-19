using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
   public class StartUp
    {
      public  static void Main()
      {
          string driver = Console.ReadLine();
          ICar car = new Ferrari(driver);
          Console.WriteLine(car.ToString());
      }
    }
}
