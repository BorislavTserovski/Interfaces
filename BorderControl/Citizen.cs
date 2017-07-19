using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Citizen: IInhabitant
    {
        private string id;
        private string name;
        private int age;

        public Citizen(string id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
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
    }
}
