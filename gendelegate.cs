// using System;
// namespace MyNamespace
// {
//     public class MyClass
//     {
//         public static void addno(int a ,int b)
//         {
//             Console.WriteLine(a+b);
//         }
//         public static int addno1(int a,int b)
//         {
//             return a+b;
//         }
//         public static bool print(string name)
//         {
//             Console.WriteLine("name is "+name);
//             return true;
//         }
//         public static void Main(string[] args)
//         {
//             Action<int,int> obj1=addno;
//             obj1.Invoke(1,2);

//             Func<int,int,int> obj2=addno1;
//            int res2= obj2.Invoke(2,2);
//            Console.WriteLine(res2);

//             Predicate<string> obj3=print;
//             obj3.Invoke("danish");


//         }
//     }
// }