// using System;
// namespace Constructors
// {
//     class Construct{
//       string name;
//       string roll;
//       public Construct()
//       {
//         Console.WriteLine("i dont take any parameteres");
//       }


//       public Construct(string fname,string froll)
//       {
//       this.name=fname;
//       this.roll=froll;
//       }

//       public void dis()
//       {
//         Console.WriteLine($"your name is {this.name} and roll no is {this.roll} ");
//       }

//       ~Construct()
//       {
//         //clean up code
//       }
//     }

//     class Classes{
//         static void Main()
//         {
//             Construct c=new Construct("danish","12");
//             c.dis();

//             Construct d=new Construct();
//             d.dis();
//         }
//     }
// }