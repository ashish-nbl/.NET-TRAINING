using System;
using System.Collections.Generic;
using System.Text;
using DAY2;
namespace DAY3
{
     public class Example
    {
        private string Id;
        protected string Name;
        internal int age;
        public string marks;
        protected internal double weight;
        private protected double height;
        public void SetName()
        {
            DAY2.Example e1= new DAY2.Example();
            //e1.name = "Aaaaa";
            
        }
    }

    public class Child:Example
    {
        public void Show()
        {
            Console.WriteLine(height);
            //Console.WriteLine();
        }
    }
    
}
