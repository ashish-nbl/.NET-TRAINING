using DAY2;

public class Student
{
    public string name;
    public int age;

    public void Show()
    {
        Console.WriteLine($"Hello {name}");
    }

    public void CallShow()
    {
        Show();
    }
}

class Demo
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.age = 45;
        s1.name = "Ashish";
        s1.Show();

        Student s2 = new Student();
        s2.age = 50;
        s2.name = "Aman";

        Example obj = new Example();
        //Console.WriteLine(obj.name);
    }
}