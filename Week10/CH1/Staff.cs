using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    internal class Staff:Person
    {
        private string school;
        private double pay;
        public Staff(string name,string adress,string school, double pay):base(name,adress)
        {
            this.school = school;
            this.pay = pay;
            this.name=name;
            this.address = adress;
            
        }
        public string getSchool()
        {
            return school;
        }
        public void setSchool(string school)
        {
            this.school=school;
        }
        public double getPay()
        {
            return pay;
        }
        public void setPay(double pay)
        {
            this.pay=pay;
        }
        public new string  toString()
        {
            return $"Student[Person[ name={name},address={address}],school={school},pay={pay}";
        }
    }
}
