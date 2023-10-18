// using System;
// namespace MyNamespace
// {
//     public class MyClass
//     {
//         int eno;
//             string name,location;
//             public MyClass(int eno,string name,string location)
//             {
//                 this.eno=eno;
//                 this.name=name;
//                 this.location=location;
//             }


//             public object this [int index]
//             {
//                 get{
//                     if(index==0)
//                     {
//                         return eno;
//                     }
//                     else if(index==1)
//                     {
//                         return name;
//                     }
//                     else if(index==2){
//                         return location;
//                     }
//                     return null;
//                 }
//                 set{
//                     if(index==0)
//                     {
//                         eno=(int)value;
//                     }
//                     else if(index==1)
//                     {
//                         name=(string)value;
//                     }
//                     else if(index==2)
//                     {
//                         location=(string)value;
//                     }
//                 }
//             }
       
//     }
//     public class test
//     {
//         public static void Main(string[] args)
//         {
//             MyClass m=new MyClass(10,"danish","amritsar");
//            Console.WriteLine( m[0]);
//            Console.WriteLine(m[1]);
//            Console.WriteLine(m[2]);

//            m[2]="chandigarh";
//            Console.WriteLine( m[0]);
//            Console.WriteLine(m[1]);
//            Console.WriteLine(m[2]);
//         }
//     }
// }