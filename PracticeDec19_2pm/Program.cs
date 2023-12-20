using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec19_2pm
{
    class MyError:ApplicationException
    {
        public void WaterOverflowException()
        {
            Console.WriteLine("Exception Happend Tank is full");
        }
    }
    
    internal class Program
    {
        public void water()
        {
            try
            {
                Console.WriteLine("How meny liters you want to fill your tank");
                int w = Convert.ToInt32(Console.ReadLine());
                if (w >= 100)
                {
                    throw new MyError();
                }
            }
            catch (MyError e)
            {
                    e.WaterOverflowException();
            }
        }
        private string pass="Suresh@123";
        private string email = "resuresh0@gmail.com";
        private long ph = 6302539493;
        enum Seson { summer=1, rainy,winter }
        enum Months { jan,feb,march}
        void set1(string p,string a,long ps)
        {
            this.ph = ps;
            this.email = a;
            this.pass = p; 
        }
        string getpass() { return pass; }
        string getemail() { return email; }
        long getph() { return ph; }
        string M1(int a)
        {
            Console.WriteLine("Method M1");
            Console.WriteLine(a);
            return "Method 1";
        }
        String M1(string a)
        {
            Console.WriteLine("Method M2");
            Console.WriteLine(a);
            return "Method 2";
        }
        int M1()
        {
            Console.WriteLine("Method M3");
            return 3;
        }
        static void Main(string[] args)
        {
            Program x= new Program();
             Console.WriteLine( x.M1(x.M1(x.M1())));
            Console.WriteLine(x.getemail() );
             Console.WriteLine(x.getpass());
             Console.WriteLine(x.getph());
             x.set1("Rayapati@123", "rayapati.reddy@mphasis.com", 9502208854);
             Console.WriteLine(x.getemail());
             Console.WriteLine(x.getpass());
             Console.WriteLine(x.getph());
              exceptionExample();
             Seson s1 = Seson.summer;
             Console.WriteLine(s1);
             int n1=(int)Seson.winter;
             Console.WriteLine(n1);
             Student st = new Student();
             st.display();
            x.water();
        }
        struct Student
        {
            public int id;
            public string name;
            public int age;
            public void display()
            {
                id = 100;
                name = "Naga Suresh Reddy";
                age = 22;
                Console.WriteLine($"Student Id={id}\nStudent Name{name}\nStudent age={age}");
               
            }
        }
       
        static void exceptionExample()
        {
            try
            {
                Console.WriteLine("Enter a abd b values");
                int a, b;
                a=Convert.ToInt32(Console.ReadLine());
                b=Convert.ToInt32(Console.ReadLine());
                int c = a / b;
                Console.WriteLine(c);
                try
                {
                    int a1=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a1);
                }
                catch (Exception x)
                {
                    Console.WriteLine(x);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                try
                {
                    int n = Convert.ToInt32(Console.ReadLine());
                    int[] arr = new int[n];
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    for (int i = 0; i <= i; i++)
                    {
                        Console.WriteLine(arr[i]);
                    }
                }
                catch (Exception y)
                {
                    Console.WriteLine(y);
                }
            }
        }

    }
}