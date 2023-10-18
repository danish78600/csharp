// using System;
// namespace MyNamespace
// {
//     public class parent
//     {
//         public virtual void meth1()
//         {
// Console.WriteLine("hello from meth1 parent");
//         }
//         public void meth2()
//         {
// Console.WriteLine("hello from meth2 parent");
//         }
//     }
//     public class MyClass:parent
//     {
//         public override void meth1()    //method overriding
//         {
// Console.WriteLine("hello from meth1 child");
//         }
//         public new void meth2()   //method hiding or shadowing
//         {
//             Console.WriteLine("hello from meth 2 child");
//         }

        
//         public void parentmeth1()
//         {
//             base.meth1();
//         }
//         public void parentmeth2()
//         {
//             base.meth2();
//         }

//         public static void Main(string[] args)
//         {
//             // parent p=new parent();
//             // p.meth1();
//             // p.meth2();

//             // MyClass m=new MyClass();
//             // m.parentmeth1();
//             // m.parentmeth2();
//             // m.meth1();
//             // m.meth2();

//             MyClass m=new MyClass();//instance of child class
//             parent p=m;  //p is a ref of parent class by using child insatnce

//             p.meth1();
//             p.meth2();

//         }
//     }
// }