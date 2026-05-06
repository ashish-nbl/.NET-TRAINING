//using System.Transactions;

//enum RequestStatus
//{
//    Inapproval,
//    Approved,
//    Rejected,
//    Cancelled,
//    Closed,
//    Draft=500
//}


// struct StructEx
//{
//   public int a;

//    public StructEx()
//    {
//        Console.WriteLine(a);
//    }
//}
//class Example
//{
//    public static void Main(String[] args)
//    {
//        Console.WriteLine((int)RequestStatus.Closed);
//        Console.WriteLine((RequestStatus)500);

//        StructEx obj = new StructEx();
//        Console.WriteLine(obj.a);

//        int num1 = 12;
//        int num2 = 0;

//            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8};
//        try
//        {
//            Console.WriteLine(arr[50]);
//            Console.WriteLine("Enter your age");
//            int age = int.Parse(Console.ReadLine());
//            int ans = num1 / num2;

//            Console.WriteLine(ans);
//        }
//        catch(FormatException ex)
//        {
//            Console.WriteLine(ex);
//        }
//        catch (DivideByZeroException ex) {
//            Console.WriteLine(ex);
//        }
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            MethodA();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Caught in Main");
//            Console.WriteLine(ex);
//        }
//    }

//    static void MethodA()
//    {
//        MethodB();
//    }

//    static void MethodB()
//    {
//        try
//        {
//            MethodC();
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("Handled in MethodB");
//            throw; // ✅ rethrow
//        }
//    }

//    static void MethodC()
//    {
//        int x = 10, y = 0;
//        int result = x / y; // ❌ Exception origin
//    }
//}


//Reverse the array 

//using System;

//class Example
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = new int[5] { 1, 2, 3, 4, 5 };

//        int start = 0;
//        int end = arr.Length - 1;

//        while (start < end)
//        {
//            int temp = arr[start];
//            arr[start] = arr[end];
//            arr[end] = temp;
//            start++;
//            end--;
//        }

//        foreach(int item in arr)
//        {
//            Console.WriteLine(item);
//        }
//    }
//}


//second largest element in array

//using System;

//class Example
//{
//    public static void Main(string[] args)
//    {
//        int[] arr = { 3,1,2,76,55};

//        int firstLargest=arr[0];
//        int secondLargest=arr[0];

//        foreach(int num in arr)
//        {
//            if(num>firstLargest)
//            {
//                secondLargest = firstLargest;
//                firstLargest=num;
//            }
//            else if(num>secondLargest && num!=firstLargest)
//            {
//                secondLargest=num;
//            }
//        }

//        Console.WriteLine("Second Largest : "+secondLargest);
//        Console.WriteLine("Largest : " + firstLargest);

//    }
//}

using System;
using System.Runtime.InteropServices;

class Example
{
    public static void Main(string[] args)
    {
        List<int> ll = new List<int>() { 1, 2, 3, 4, 5, 6, 1, 2, 8 };
        List<string> ll2 = new List<string>() { "Ashish","Ajay","Amit" };

        int result = ll.Find(x =>x==1);
        Console.WriteLine(result);

        string result2 = ll2.Find(x => x == "A");
        Console.WriteLine(result2.GetType());
    }

}
