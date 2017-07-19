using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizen: IInhabitant, IBirthable, IBuyer
    {
        private string id;
        private string name;
        private int age;
        private string birthday;

        public Citizen(string id, string name, int age, string birthday)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.BirthDay = birthday;
        }
        public string Id
        {
            get { return this.id; }
            private set { this.id = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }
        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string BirthDay
        {
            get { return this.birthday; }
            private set { this.birthday = value; }
        }

        public int Food { get; set; }
        public int BuyFood()
        {
           return 10;
        }
    }
}
