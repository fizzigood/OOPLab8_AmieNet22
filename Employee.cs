using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab8_Collection_Generics_AmieNet22
{
    internal class Employee
    {
        public int _Id { get; set; }
        public string _Name { get; set; }
        public string _Gender { get; set; }    
        public int _Salary { get; set; }

        public Employee(int id, string name, string gender, int salary) //Constructor för employee.
        {
            this._Id = id;                                             
            this._Name = name;
            this._Gender = gender;
            this._Salary = salary;
        }
        public override string ToString() //Omvandlar objekten och möjliggör string output
        {
            return $"[Employee id: {_Id}, Name: {_Name}, Gender: {_Gender}, Salary: {_Salary}]"; 
        }

    }
}
