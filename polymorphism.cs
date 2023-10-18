// using System;
// namespace Cons{
//     class Emp{
//   public string name;
//   public int sal;
//   public virtual void info()    //virtual means that this method can be ovveriden in its child class
//   {
//     Console.WriteLine($"{name}  got per/month salary of {sal}");

//   }
//     }

//     class fulltimeemp:Emp{
//  public string time;
//  public override void info()        //override means overriding the base class method
//   {
//     Console.WriteLine($"{name}  got per/month salary of {sal} of full time");

//   }
//     }


//     class halftimeemp:Emp{
//       public  string times;
//       public new void info()   
//   {
//     Console.WriteLine($"{name}  got per/month salary of {sal} of part time");

//   }
//     }




//     class Inherit{
//        public static void Main()
//         {

// Emp[] em=new Emp[3];    //reference of a base class
// em[0]=new fulltimeemp();  //base class variable pointing to child class ref variable
// em[1]=new halftimeemp();

// foreach (Emp e in em)
// {
//     e.info();
// }

//         }
//     }
// }