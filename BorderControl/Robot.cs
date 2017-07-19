using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
   public class Robot: IInhabitant
   {
       private string id;
       private string model;

       public Robot(string id, string model)
       {
           this.Id = id;
           this.Model = model;
       }
       public string Model
       {
           get { return this.model; }
           private set { this.model = value; }
       }

       public string Id
       {
            get { return this.id; }
            private set { this.id = value; }
       }
    }
}
