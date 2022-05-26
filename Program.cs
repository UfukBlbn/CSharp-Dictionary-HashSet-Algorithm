using System;
using System.Collections.Generic;


namespace C_Algorithms
{
    
      public class Employee{
    
        public string name {get;set;}

        public int id {get;set;}

        public string department {get;set;}

        public Employee(string name,int id, string department)
        {
            this.name=name;
            this.id=id;
            this.department=department;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee("Rob",1234,"Tech");
            Employee emp2 = new Employee("John",4211,"IT");
            Employee emp3 = new Employee("Sam",3432,"HelpDesk");
            
            //Using Dictionary
            Dictionary<int,Employee> emplpyeesById = new Dictionary<int,Employee> ();
            emplpyeesById.Add(emp.id,emp);
            emplpyeesById.Add(emp2.id,emp2);
            emplpyeesById.Add(emp3.id,emp3);

            Employee e;
            if (emplpyeesById.TryGetValue(1234,out e)){

                Console.WriteLine(e.name+""+e.department);

                //Using HashSet
                HashSet<string> productCodes = new HashSet<string>();
                productCodes.Add("AEXS1");
                productCodes.Add("NYX15");
                productCodes.Add("33BX1");

                productCodes.Contains("AEXS1");

            }
        }
    }
}
