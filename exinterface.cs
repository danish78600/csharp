// using System;
// namespace MyNamespace
// {
//     interface I1{
//         void inte();
//     }
//    interface I2{
// void inte();
//    }


//     public class exinterface:I2,I1{
//         void I1.inte(){
// Console.WriteLine("inte 1 method is invoked");
//         }

//         public void inte(){
// Console.WriteLine("inte 2 method is invoked");
//         }

//         public static void Main()
//         {
// // exinterface ex=new exinterface();
// // ((I1)ex).inte();
// // ((I2)ex).inte(); //typecasting so as to print the inte() of the I2 interface

// // I1 i=new exinterface();
// // I2 i2=new exinterface();
// // i2.inte();
// // i.inte();

// exinterface ex=new exinterface();
// ex.inte();

//         }
//     }
// }