
//class Base
//{
//    public void Demo()
//    {
//        Console.WriteLine("This is demo method without parameters");
//    }
//    public void Demo(int a)
//    {
//        Console.WriteLine("This is demo method with parameters");
//    }
//}


//class Child : Base
//{
//    public new void Demo(int a)
//    {
//        Console.WriteLine("This is child method");
//    }
//}

//class Day4
//{
//    public static void Main(string[] args)
//    {
//        double da = 0.1D + 0.3D;
//        Console.WriteLine(da);

//        double d = 1D / 3;
//        Console.WriteLine(d);

//        decimal de = 1M / 3;
//        Console.WriteLine(de);

//        Base obj = new Child();
//        obj.Demo(54);
//    }
//}


//class Person
//{
//    public string Name { get; set; }
//}

//class Employee : Person
//{
//    public string JobTitle { get; set; }
//}
//class Candidate : Person
//{

//}

//class CastingDemo
//{ 
//   public static void Main()
//    {
//        string name = "Amit";

//        var employee = new Employee()
//        {
//            Name = "John Doe",
//            JobTitle = "C# Developer"
//        };

//        //up casting converting child class object into parent reference
//        Person person = employee;
//        Console.WriteLine(person.Name);
//        //Console.WriteLine(person.jobTitle);


//        //down casting converting the parent refrence back to child refrence
//        //but condition is that parent refrence must be object of child class
//        Employee employee2=(Employee)person;

//        //Candidate candidate = (Candidate)person; // downcast fail at runtime gives the exception
//        Candidate candidate = person as Candidate;
//        if (candidate != null)
//        {
//            Console.WriteLine(candidate.Name);
//        }

//    }
//}


//Extenditon method

//public static class StringExtension
//{
//    public static string ConvertFirstLetterToUpperCase(this string s)
//    {
//        string str = " ";
//        s.ToLower().Split(' ').ToList().ForEach(x =>
//        {
//            str += char.ToUpper(x[0]) + x.Substring(1) + " ";
//        });
//        return str;
//    }
//}

//public class ExtensionMethodDemo()
//{
//    public static void Main()
//    {
//        string name = "pateliya ashish vasharambhai";

//        Console.WriteLine(name.ConvertFirstLetterToUpperCase());
//    }
//}


//public class UnhandleException
//{
//    public static void Main()
//    {

//        AppDomain.CurrentDomain.UnhandledException +=
//        new UnhandledExceptionEventHandler(HandleException);

//        int a = 5;
//        int b = 0;
//        int ans = a / b;


//    }

//    private static void HandleException(object sender, UnhandledExceptionEventArgs e)
//    {

//        Console.WriteLine("Unhandle Exception Occurs");
//    }
//}




//using static System.Console;

//int Divide(int a, int b)
//{
//    return a / b;
//}

//AppDomain.CurrentDomain.UnhandledException +=
//        new UnhandledExceptionEventHandler(HandleException);


//// cause an exception
//var result = Divide(10, 0);

//WriteLine(result);


//static void HandleException(object sender, UnhandledExceptionEventArgs e)
//{
//    WriteLine($"Sorry, there was a problem occurs. The program is terminated. \n {e.ExceptionObject}");
//}


public class GenericRepo<Gen>
{
    List<Gen> ll = new List<Gen>();

    public void Insert(Gen value)
    {
        ll.Add(value);
    }

    public void Remove(Gen value)
    {
        ll.Remove(value);
    }

    public void Display()
    {
        foreach(var item in ll)
        {
            Console.WriteLine(item);
        }
    }
}


public class GenericEx
{
    public static void Swap<Gen>(ref Gen value1,ref Gen Value2)
    {
        Gen temp=value1;
        value1 = Value2;
        Value2= temp;
    }

    public static void Main(string[] args)
    {
        int num1 = 12, num2 = 13;
        string name1 = "Ashish", name2 = "Anisha";


        Console.WriteLine("1.Ineteger Swapping using Swap<Gen> ");
        Console.WriteLine($"Integer Before Swaping num1:{num1} num2:{num2}");
        Swap<int>(ref num1, ref num2);
        Console.WriteLine($"Integer After Swaping num1:{num1} num2:{num2}");

        Console.WriteLine("2.String Swapping using Swap<Gen>");
        Console.WriteLine($"Names Before Swaping name1:{name1} name2:{name2}");
        Swap<string>(ref name1, ref name2);
        Console.WriteLine($"Names After Swaping name1:{name1} name2:{name2}");


        GenericRepo<int> obj1=new GenericRepo<int>();

        obj1.Insert(1);
        obj1.Insert(2);
        obj1.Insert(5);
        obj1.Insert(55);
        obj1.Insert(45);
        obj1.Insert(70);
        obj1.Insert(88);


        obj1.Remove(1);
        obj1.Remove(500);

        obj1.Display();


        GenericRepo<string> ll2=new GenericRepo<string>();

        ll2.Insert("Ashish");
        ll2.Insert("Aman");
        ll2.Insert("Anisha");
        ll2.Insert("Rakesh");

        ll2.Remove("Aman");

        ll2.Display();

    }
}