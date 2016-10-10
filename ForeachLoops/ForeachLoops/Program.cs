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
            //List<string> myList = new List<string>();

            //for (int i = 0; i < 50; i++)
            //{
            //    myList.Add(string.Format("list item {0}", i));
            //}

            //foreach(String temp in myList)
            //{
            //    Console.WriteLine(temp);
            //}

            //List<Employee> empList = new List<Employee>();

            //for(int i = 0; i < 5; i++)
            //{
            //    Employee temp = new Employee();
            //    temp.EmployeeName = string.Format("Employee {0}", i);
            //    temp.EmployeeOccupation = string.Format("Occup {0}", i + 5);
            //    empList.Add(temp);
            //}

            //Console.WriteLine(empList);

            //foreach(Employee thisEmployee in empList)
            //{
            //    Console.Write(thisEmployee.EmployeeName + " ");
            //    Console.WriteLine(thisEmployee.EmployeeOccupation);
            //}

            string myString = "The quick brown fox jumped over the lazy dog";
            int numChars = myString.Length;

            int wcount = myString.CountWords();

            DoesSomething somVar = new DoesSomething();
            bool cool = somVar.IsSomethingCool();

            bool stillCool = DoesSomethingElse.IsSomethingCool();

            Console.ReadKey();
        }
    }
}
