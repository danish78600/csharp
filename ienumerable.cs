using System;
using System.Collections.Generic;
namespace MyNamespace
{
    class Employee{
        public int id{get;set;}
        public string name{get;set;}
        public string job{get;set;}
    }
public class organization{
    List<Employee>emps=new List<Employee>();
    public void add(Employee em)
    {
        emps.add(em);
    }

}
    public class MyClass
    {
        public static void Main(string[] args)
        {
            List<Employee> emp=new List<Employee>();
            emp.Add(new Employee{id=12,name="danish1",job="coder1"});
            emp.Add(new Employee{id=12,name="danish2",job="coder2"});
            emp.Add(new Employee{id=12,name="danish3",job="coder3"});
            emp.Add(new Employee{id=12,name="danish4",job="coder4"});
foreach(Employee e in emp)
        {
            Console.WriteLine(e.id+" "+e.name+" "+e.job);
        }
        }
        
    }
}