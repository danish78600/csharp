// using System;

// namespace MyNamespace
// {
//     public class MyClass
//     {
//         public bool com<T>(T a,T b)
//             {
//                 if(a.Equals(b))
//                 {
//                    return true;
//                 }
//                 else
//                 {
//                     return false;
//                 }
//             }

            
//         public static void Main(string[] args)
//         {
//            MyClass m=new MyClass();
//         //    bool res=m.com(1,1);
//         bool res=m.com<float>(1.12f,1.22f);  //<float> is replacing type by float type
//            Console.WriteLine(res);
//         }
//     }
// }


//Generics for classes
// using System;
// namespace MyNamespace
// {
//     public class MyClass<T>
//     {
//         public void add(T a,T b)
//         {
//             dynamic d1=a;
//             dynamic d2=b;
//             Console.WriteLine(d1+d2);
//         }

//         public void sub(T a,T b)
//         {
//             dynamic d1=a;
//             dynamic d2=b;
//             Console.WriteLine(d1-d2);
//         }
//     }

// class Generics{
//         public static void Main(string[] args)
//         {
//             MyClass<int> m=new MyClass<int>();
//             m.add(1,1);
//             m.sub(10,5);
//         }
//     }
// }