using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public delegate void HelloFunctionDelegate(string Message);



namespace ConsoleApp
{
    //delegate declaration
    public delegate void HelloFunctionDelegate(string Message);

    //base class
    public class Vehicle
    {

        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Welcome");
        }

        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        //delegate object
        public HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);

        //function used with delegate
        public static void Hello(string strMessge)
        {
            Console.WriteLine(strMessge);
        }

    }
}
