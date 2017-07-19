﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
   public class Rebel:IBuyer
   {
       private string group;
       private string name;
       private int age;

       public Rebel(string name, int age, string group)
       {
           this.Name = name;
           this.Age = age;
           this.Group = group;
       }
       public int Food { get; set; }
       public string Name { get; set; }
       public int Age  { get; set; }
       public string Group { get; set; }
       public int BuyFood()
       {
           return 5;
       }
   }
}
