using System.Linq.Expressions;
using System;
using System.Collections;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace OOP_Lab8_Collection_Generics_AmieNet22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fem nya instanser/objekt av klassen Employee i main()-metoden:
            var e1 = new Employee(100, "Cristopher Krus", "Male", 35000);
            var e2 = new Employee(101, "Ida Holmberg", "Other", 35000);
            var e3 = new Employee(102, "Su Saibogujimans", "Female", 40000);
            var e4 = new Employee(103, "Kjell Larsson", "Male", 20000);
            var e5 = new Employee(104, "Emma Nordström", "Female", 25000);


            Console.WriteLine("PART 1 - STACK< >");
            Console.WriteLine();

            Stack<Employee> estack = new Stack<Employee>(); //En stack för Employee
            //Stoppar in instanserna/objekten av Employee i en Stack med hjälp av push:
            estack.Push(e1); 
            estack.Push(e2); 
            estack.Push(e3); 
            estack.Push(e4); 
            estack.Push(e5);

            Console.WriteLine("Number of employees in stack: {0}", estack.Count()); //Berättar antal objects in stack
            Console.WriteLine();

            Console.WriteLine("Who is Employee 3 in stack? ");             // Kollar om object nummer 3 finns i stack
            if (estack.Contains(e3))                                       // om det gör det
            {
                Console.WriteLine(e3);                                     // Skriver den ut objekt 3
                Console.WriteLine();
            }
            else                                                           // I annat fall
            {
                Console.WriteLine("No such item in stack.");               // Skriver den ut att den inte gör det.
                Console.WriteLine();
            }

            Console.WriteLine("Foreach-loop prints each object:");
            foreach (var e in estack)                                      //Loopar genom alla Employees och skriver ut objectens värden:
            {
                Console.WriteLine(e);                                      //skriver ut objecten med hjälp av "public override string ToString()" i Employee-klassen
            }
            Console.WriteLine();

            Console.WriteLine("While-loop using pop- & peek, while counting how many employees are left in stack: ");
            while (estack.Count > 0)                                              //Så länge det finns employees kvar i stacken fortsätter loopen som...
            {
                Console.WriteLine("Number of employees left in stack: {0}", estack.Count); // ...kollar och skriver ut hur många som är kvar
                Console.WriteLine(estack.Peek());                                 // ...kikar och skriver ut vem som är nästa i stacken med peek-metoden
                estack.Pop();                                                     // ...och tar bort dem med pop-metoden
            }
            Console.WriteLine("Number of employees left in stack: {0}", estack.Count);     // ...Berättar sedan hur många som är kvar
            Console.WriteLine();

            Console.WriteLine("PART 2 - LIST < >");
            Console.WriteLine();

            List<Employee> elist = new List<Employee> { e1 , e2 , e3 , e4 , e5 }; //En List för Employee där alla instanserna/objekten stoppas in direkt.

            Console.WriteLine("Does list of employees contain employee 2? ");

            if (elist.Contains(e2))
            {
                Console.WriteLine("Employee slot number 2:");
                Console.WriteLine(e2);
                Console.WriteLine("is contained in the list.");
            }
            else
            {
                Console.WriteLine("List of employees does not contain the desired item.");
            }
            Console.WriteLine();

            Console.WriteLine("Find first male employee in list: ");
            Console.WriteLine(elist.Find(e => e._Gender.Contains("Male")));

            Console.WriteLine("Find all male employees in list: ");
            List<Employee> males = elist.FindAll(e => e._Gender == "Male");     //Skapar en lista med de objekt i elist som uppfyller villkoren 
            foreach(Employee e in males)                                        //Loopar genom dessa objekt och skriver ut.
            {
                Console.WriteLine(e);
            }

        }
    }
}