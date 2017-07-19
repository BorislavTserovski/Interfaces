using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    public class Pet: IBirthable
    {
        private string birthday;
        private string name;

        public Pet(string birthday, string name)
        {
            this.BirthDay = birthday;
            this.Name = name;
        }
        public string BirthDay
        {
            get { return this.birthday; }
            private set { this.birthday = value; }
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
    }
}
