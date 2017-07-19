using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
   public class StartUp
    {
       public static void Main()
       {
           string[] numbers = Console.ReadLine().Split();
           string[] urls = Console.ReadLine().Split();
           Smartphone phone = new Smartphone();

           foreach (var number in numbers)
           {
               try
               {
                    Console.WriteLine(phone.Call(number)); 
               }
               catch (Exception e)
               {
                   Console.WriteLine(e.Message);
                   
               }
           }

           foreach (var url in urls)
           {
               try
               {
                   Console.WriteLine(phone.Browse(url));
                  
               }
               catch (Exception e)
               {
                   Console.WriteLine(e.Message);
                  
               }
           }
       }
    }
}
