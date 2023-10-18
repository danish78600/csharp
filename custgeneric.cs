// using System;
// using System.Collections.Generic;
// namespace MyNamespace
// {
//     public class Dict
//     {
//         public string name{get;set;}
//             public int roll{get;set;}
//     }
//     public class MyClass
//     {
//         public static void Main(string[] args)
//         {
//             List<Dict> li=new List<Dict>();    //to store Dict class type values
//             Dict d1=new Dict{name="danish",roll=12};
//             Dict d2=new Dict{name="danish2",roll=13};
//             Dict d3=new Dict{name="danish3",roll=14};

//             li.Add(d1);
//             li.Add(d2);
//             li.Add(d3);

//             foreach (Dict obj in li)  //obj represents instacne of Dict
//             {
//               Console.WriteLine(obj.roll+" "+obj.name);
//             }


//         }
//     }
// }