using System;
namespace Constructor
{
    // class info{
    //     string name;
    //     string lname;
    //     public info()
    //     {
    //         Console.WriteLine("constructor is created but with not any parameters");
    //     }
    //     public info(string fname,string flname)
    //     {
    //         this.name=fname;
    //         this.lname=flname;

    //     }
    //     public void printFullName()
    //     {
    //         Console.WriteLine(name+" "+lname);
    //     }
    //     ~info()
    //     {
    //         Console.WriteLine("object is destroyed");
    //     }
        
    // }

    public class Prop{
        // public int y;
    //   public int x;
private int _id;
private int _marks=81;
private string _name;

// public Prop(int j)
// {
//     x=j;
// Console.WriteLine(j +" is the no of parameterised constrictor");
// }


// public void display ()
// {
//     Console.WriteLine(x +" is the value of x");
// }

public int Mark{
    get{
        return this._marks;
    }
}

public string Name
{
    set{
    this._name=value;

    }
    get{
        return this._name;
    }
}


public int Id
{
    set{
if(value<0)
{
    throw new Exception("student id cannot be negative");

}
else
{
    this._id=value;
}
    }
    get{
        return this._id;
    }

}

public string email{
    get;
    set;
}


    }

    class Player
    {
        // static void Main(String []args)
        // {
//             info i=new info("danish","bhandari");
//             i.printFullName();

//             info in=new info();
// in.printFullName();


            // int[] arr=new int[3];
            // arr[0]=2;
            // arr[1]=4;
            // arr[2]=6;
            // int len=arr.Length;
            // Console.WriteLine(arr[1]);

            // int i,j;
            // for(i=0;i<len;i++)
            // {
            //     Console.WriteLine($"value of index {i} is {arr[i]}");
            // }


// Prop p=new Prop();
// p.Id=101;
// p.Name="danish";
// p.email="bhandridanisg@gmail,con";
// Console.WriteLine(p.Id +" is the value of id");
// Console.WriteLine(p.Name+" is the name of obj");
// Console.WriteLine(p.Mark);
// Console.WriteLine("email is "+p.email);



        // }
    }
}