using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch3
{
    internal class Student:Person
    {
        private string program;
        private int year;
        private double fee;
        public Student(string name,string address,string program, int year, double fee):base(name,address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
            this.name = name;
            this.address = address;
        }
        public Student(string program,int year, double fee):base(program)
        {
            this.program=program;
            this.year
                = year;
           this.fee=fee;    
        }
        public string getProgram()
        {
            return program;
        }
        public void setProgram(string program)
        {
            this.program=program;
        }
        public int getYear()
        {
            return year;
        }
        public void setYear(int year)
        {
            this.year=year; 
        }
        public double getFee()
        {
            return fee;
        }
        public void setFee(double fee)
        {
            this.fee=fee;   
        }
        public new string  toString()
        {
            return $"Student[Person[name={name},address={address}]program={program},year={year},fee={fee}]";
        }
    }
}
