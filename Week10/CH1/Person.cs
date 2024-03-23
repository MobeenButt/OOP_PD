using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    internal class Person
    {
        protected string name;
        protected string address;
        public Person(string address)
        {
            this.address = address;
        }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public string getName()
        {
            return name;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getAddress() 
        {
            return address;
        }
        public void setAdress(string address)
        {
            this.address = address;
        }
        public string toString() 
        {
            return $"Person [name={name},adress={address}]";
        }

    }
}
