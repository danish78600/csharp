// using System;
// using System.Diagnostics;
// using StringBuilder= System.Text.StringBuilder;

// namespace MyNamespace
// {
//     public class MyClass
//     {
//         public static void Main(string[] args)
//         {
//             string sa="";
//             Stopwatch s=new Stopwatch();
//             s.Start();
//             //11 copies will be present at this location
//             for (int i = 1; i < 100000; i++)
//             {
//                 sa=sa+1;
//             }
//             s.Stop();

//             StringBuilder sb=new StringBuilder();
//             Stopwatch s2=new Stopwatch();
//             s2.Start();
//             for (int i = 1; i <100000; i++)
//             {
//                 sb.Append(i);
//             }
//             s2.Stop();
//             Console.WriteLine("time taken for string "+s.ElapsedMilliseconds);
//             Console.WriteLine("time taken for string builder "+s2.ElapsedMilliseconds);
//         }
//     }
// }