
//Encapsulation Example

//public class Employee
//{
//    private double balance;

//    public double Balance
//    {
//        get
//        {
//            return balance;
//        }
//        set
//        {
//            if (value < 0)
//            {
//                Console.WriteLine("Negative balance is not allowed");
//                return;
//            }
//            else
//            {
//                balance = value;
//            }
//        }
//    }

//    public double GetBalance()
//    {
//        return balance;
//    }
//}

//public class OopsDemo
//{
//    public static void Main(string[] args)
//    {
//        Employee employee = new Employee();
//        employee.Balance = -200;
//        employee.Balance = 900;
//        Console.WriteLine(employee.GetBalance());

//    }
//}

//Abstraction

//using abstract class

//abstract class Vehicle
//{
//    public abstract void Start();

//    public void Fuel()
//    {
//        Console.WriteLine("fuel is added succesfully");
//    }
//}

//class Car:Vehicle
//{
//    public override void Start()
//    {
//        Console.WriteLine("Start method for the car...");
//    }
//}

//class Bike:Vehicle
//{
//    public override void Start()
//    {
//        Console.WriteLine("Start method for the bike...");
//    }
//}




//interface IPayment
//{
//    void Pay();
//}

//class UpiPayment:IPayment
//{
//    public void Pay()
//    {
//        Console.WriteLine("Payment is done using UPI...");
//    }
//}

//class CreditCardPayment : IPayment
//{
//    public void Pay()
//    {
//        Console.WriteLine("Payment is done using Credit Card...");
//    }
//}

//class OopsDemo
//{
//    public static void Main(string[] args)
//    {
//        Vehicle Bike = new Bike();
//        Bike.Fuel();
//        Bike.Start();

//        Vehicle Car = new Car();
//        Car.Fuel();
//        Car.Start();


//        IPayment creditcard = new CreditCardPayment();
//        creditcard.Pay();

//        IPayment upi = new UpiPayment();
//        upi.Pay();
//    }
//}

//public class Base
//{
//    public Base(int x) : this()
//    {
//        Console.WriteLine("Base class paramterrized constructor is called");
//    }
//    public Base()
//    {
//        Console.WriteLine("Base constructor start logging");
//    }


//}
//public class Derived : Base
//{

//    public Derived() : base(56)
//    {
//        Console.WriteLine("Base Constructor finish logging");

//        Console.WriteLine("Derived class now start..");

//        string name = "ashish";
//        Console.WriteLine("Derived class now start working");
//        Console.WriteLine("Derived class constructor initializes new field name : " + name);
//    }
//}
//public class baseEx
//{
//    public static void method()
//    {
//        Console.WriteLine("static method");
//    }
//    public static void Main(string[] args)
//    {
//        const int a = 4;
//        method();
//        Base bd = new Derived();
//    }
//}


//public class Base
//{
//    public virtual void Method()
//    {
//        Console.WriteLine("Thid is base class method");
//    }
//    public void Method2()
//    {
//        Console.WriteLine("This is base class method2");
//    }
//}

//public class Derived : Base
//{
//    public override void Method()
//    {
//        Console.WriteLine("This is the method using override");
//    }
//    public  new void Method2()
//    {
//        Console.WriteLine("This is the method2 using new key word");
//    }
//}

//public class Program
//{
//    public static void Main(string[] args)
//    {

//        Base b = new Base();
//        b.Method();
//        b.Method2();
//        Console.WriteLine("------------------------------------------------");


//        Base b1 = new Derived();
//        b1.Method();
//        b1.Method2();
//        Console.WriteLine("------------------------------------------------");

//        Derived d1 = new Derived();
//        d1.Method();
//        d1.Method2();

//    }
//}


////Custom Exception

using static System.Console;

class MyCustomException : Exception
{
    MyCustomException() : base() { }
    MyCustomException(string message) : base(message) { }
    MyCustomException(string message, Exception innerException) : base(message, innerException) { }
}


public class Account
{
    private decimal balance;
    public decimal Balance => balance;

    public Account(decimal initialBalance = 0)
    {
        if (initialBalance < 0)
        {
            throw new ArgumentOutOfRangeException($"The {nameof(initialBalance)} must be zero or positive.");
        }
        balance = initialBalance;
    }

    public Account Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new ArgumentOutOfRangeException(
                nameof(amount),
                $"Could not withdraw an amount ({amount:C}) that is more than balance ({Balance:C})"
            );
        }

        balance -= amount;
        return this;
    }
    public Account Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(amount));
        }
        balance += amount;
        return this;
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        var account = new Account(100);
        try
        {
            account.Withdraw(200);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            WriteLine(ex.Message);
        }

        ReadLine();
    }
}
