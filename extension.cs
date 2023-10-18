// using System;
// namespace MyNamespace
// {
//     class extmeth{
//         public static void Main(string[] args)
//         {
//             MyClass m=new MyClass();
//             m.print(2);
//             m.danish();
//             m.kartik();

//             int i=5;
//            long res= i.factorial();
//            Console.WriteLine(res);

//            string str="HelO DaNisH";
//           str= str.ToProper();
//           Console.WriteLine(str);


//         }
//     }
//     static class stat
//     {
//         public static void print(this MyClass s,int i)   //print method is binded to MyClass class
//         {
//             Console.WriteLine("meth1 "+i);
//         }
//         public static long factorial(this Int32 x)  //binding factorial method to Int32 structure
//         {
//             if(x==1)
//             {
//                 return 1;
//             }
//             if(x==2)
//             {
//                 return 2;
//             }
//             else
//             {
//                 return x*factorial(x-1);
//             }
//         }

//         public static string ToProper(this String oldstr )
//         {
//             if(oldstr.Trim().Length>0)
//             {
// String newstr=null;
// oldstr=oldstr.ToLower();
// string []sarr=oldstr.Split(' ');
// foreach (string str in sarr)
// {
//     char []arr= str.ToCharArray();
//     arr[0]=Char.ToUpper(arr[0]);
//     if(newstr==null)
//     {
//     newstr=new string(arr); //this character is converted to string again 
//     }
//     else
//     {
//     newstr+=" "+new string(arr);
//     }

// }
// return newstr;
//             }
//             else{
//                 return oldstr;
//             }
            


//         }
//     }
//     public class MyClass
//     {
//         public void danish()
//         {
//             Console.WriteLine("hello");
//         }
//         public void kartik()
//         {
//             Console.WriteLine("kartik");
//         }
//         // public static void Main(string[] args)
//         // {
//         //     MyClass m=new MyClass();
//         //     m.danish();
//         //     m.kartik();
//         // }
//     }
// }