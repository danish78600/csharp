// using System;
// using System.Collections;
// namespace MyNamespace
// {
//     public class MyClass
//     {
//         public static void Main(string[] args)
//         {
//             ArrayList al=new ArrayList(10); //initial capacity is 10
//           //capacity of array list keeps increasing which is known as auto resizing
//             Console.WriteLine(al.Capacity);
//             al.Add(20);    //for adding element at the end
//             Console.WriteLine(al.Capacity);
//             foreach (object obj in al)
//             {
//                 Console.WriteLine(obj);
//             }
//             al.Insert(1,100);
//             al.Remove(2);
//             foreach (object obj in al)
//             {
//                 Console.WriteLine(obj);
//             }
//         }
//     }
// }