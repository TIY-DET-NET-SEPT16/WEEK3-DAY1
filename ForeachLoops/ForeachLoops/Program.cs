using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new empty list of strings
            //List<string> myList = new List<string>();

            //Fill the list with nonsense
            //for (int i = 0; i < 50; i++)
            //{
            //    myList.Add(string.Format("list item {0}", i));
            //}

            //Loop for each item(string this time) in the list
            //foreach(String temp in myList)
            //{
            //    Console.WriteLine(temp);
            //}

            //Create a new empty list of Employees
            //List<Employee> empList = new List<Employee>();

            //Fill the list with nonsense
            //for(int i = 0; i < 5; i++)
            //{
            //    Employee temp = new Employee();
            //    temp.EmployeeName = string.Format("Employee {0}", i);
            //    temp.EmployeeOccupation = string.Format("Occup {0}", i + 5);
            //    empList.Add(temp);
            //}

            //All this writes out is the type because console doesn't know how to write out a List
            //Console.WriteLine(empList);

            //Loop for each item (this time Employees) in the list
            //foreach(Employee thisEmployee in empList)
            //{
            //    Console.Write(thisEmployee.EmployeeName + " ");
            //    Console.WriteLine(thisEmployee.EmployeeOccupation);
            //}

            //Create a string to work with
            string myString = "The quick brown fox jumped over the lazy dog";
            //Length is a built in method on string
            int numChars = myString.Length;

            //Use the extension method
            int wcount = myString.CountWords();

            //Use a regular method
            DoesSomething somVar = new DoesSomething();
            bool cool = somVar.IsSomethingCool();

            //Using a different regular method that happens to return a bool
            bool stillCool = DoesSomethingElse.IsSomethingCool();

            Console.ReadKey();
        }
    }
}
