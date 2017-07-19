using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
   public class Ferrari: ICar
   {
      
       private string driverName;

       public Ferrari(string driverName)
       {
           this.DriverName = driverName;
       }

        public string DriverName { get;private set; }
        public string Drive()
        {
            return "Zadu6avam sA!";
        }

        public string PushBrakes()
        {
            return "Brakes!";
        }

       public override string ToString()
       {
           return $"488-Spider/{this.PushBrakes()}/{this.Drive()}/{this.DriverName}";
       }
   }
}
