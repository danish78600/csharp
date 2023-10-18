// using System;
// namespace MyNamespace
// {
//     public delegate void addnodelegate(int a,int b);

//     public class MyClass
//     {
//         public void addno(int a ,int b)
//         {
//             Console.WriteLine(a+b);
//         }
//         public static void Main(string[] args)
//         {
//             MyClass m=new MyClass();
//             //the below code is for instatiating the delegate
//             addnodelegate ad=new addnodelegate(m.addno);  //address of method given to delegate
//             ad(100,100);
//             // ad.Invoke(100,100);

           

//         }
//     }
// }