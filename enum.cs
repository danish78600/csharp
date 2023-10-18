// using System;
// namespace MyNamespace
// {

//     public enum days{
//         mon,
//         tues,
//         wed,
//         thur,
//         fri=100,
//         sat
//     }
//     public class MyClass
//     {
//         public static days meet
//         {
//             get;set;
//         }=(days)1;  //default meeting day

//         public static void Main(string[] args)
//         {
//             Console.WriteLine(meet);
//             // meet ="sat";      //we cannot contain string to enum type
//             meet=days.fri;
//             Console.WriteLine(meet);


//             // Console.BackgroundColor=ConsoleColor.Red;
//             // foreach (int i in Enum.GetValues(typeof(days)))
//             // {
//             //     Console.WriteLine(i+": "+(days)i);
//             // }
//             // foreach (string s in Enum.GetNames(typeof(days)))
//             // {
//             //     Console.WriteLine(s);
//             // }
//             // days d=(days)2;
//             // Console.WriteLine(d);
//         }
//     }
// }