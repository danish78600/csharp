// using System;
// namespace MyNamespace
// {
//     public class MyClass
//     {
//         private void danish()
//         {
//             Console.WriteLine("danish");
//         }
//         internal void inte()
//         {
//             Console.WriteLine("internal");
//         }
//         protected void prot()
//         {
//             Console.WriteLine("protected");
//         }
//         protected  internal void protinte()
//         {
//             Console.WriteLine("protected internal");
//         }
//         public void pub()
//         {
//             Console.WriteLine("danish publicly");
//         }
//         //consuming member of class from same class


//         // public static void Main(string[] args)
//         // {
//         //     MyClass m=new MyClass();
//         //     m.danish();
//         //     m.pub();
//         //     m.prot();
//         //     m.protinte();
//         //     m.inte();
//         // }
//     }
//     public class dana:MyClass
//     {
//         //consuming member of class from child class 


//         // public static void Main(string[] args)
//         // {
//         //     dana m=new dana();
//         //     // m.danish();
//         //     m.pub();
//         //     m.prot();
//         //     m.protinte();
//         //     m.inte();
//         // }
//     }
//     public class kana
//     {
//         //consuming member of class from non child class

//         public static void Main(string[] args)
//         {
//             MyClass m=new MyClass();
//             // m.danish();
//             m.pub();
//             // m.prot();
//             m.protinte();
//             m.inte();
//         }
//     }
// }