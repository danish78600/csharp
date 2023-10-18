// using System;
// using System.Collections.Generic;
// namespace MyNamespace
// {
//     public class Student : IComparable<Student>
//     {

//         public int roll{get;set;}
//         public string name{get;set;}
//         public int marks{get;set;}

//         public int CompareTo(Student other)
//         {
//         if(this.roll>other.roll)  //current roll no is greater than other roll no
//         {
//             return 1;
//         }
//         else if(this.roll<other.roll)
//         {
//             return -1;
//         }
//         else{
//             return 0;
//         }
//         }
//     }


//     class child:IComparer<Student>{
// public int Compare(Student x,Student y)
// {
// if(x.marks>y.marks)
// {
//     return 1;
// }
// else if(x.marks<y.marks)
// {
//     return -1;
// }
// else{
//     return 0;
// }
// }
//     }


//     class dans{
//         public static int CompareNames(Student s1,Student s2)
//         {
//             return s1.name.CompareTo(s2.name);
            
//         }
//         public static void Main(string[] args)
//         {
//             Student s1=new Student{roll=10,name="danish",marks=10};
//             Student s2=new Student{roll=9,name="shifali",marks=8};
//             Student s3=new Student{roll=12,name="kartik",marks=4};
            

//             List<Student>students=new List<Student>(){s1,s2,s3};
//             // students.Sort();

//                  child c=new child();
//             // students.Sort(c);
//             // students.Sort(0,2,c);

//             Comparison<Student>obj =new Comparison<Student>(CompareNames);

//             students.Sort(obj);  //calls the delegate and the delegate will then call the method to execute the logic

//             foreach (Student s in students)
//             {
//              Console.WriteLine(s.roll+" "+s.name+" "+s.marks);   
//             }

       
//         }
//     }
// }