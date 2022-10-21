using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASSIGNMENT_7_2
{
    class Employee
    {
        int EmployeeID;
        string FirstName, LastName, Title, City;
        DateTime DOB, DOJ;
        public static List<Employee> employees()
        {

            List<Employee> emp = new List<Employee>()
            {
                new Employee { EmployeeID = 1001, FirstName = "abcd", LastName = "Daruwalla", Title = "Manager", City = "Mumbai", DOB = new DateTime(1984/11/20), DOJ = new DateTime(2011,6,8) },
                new Employee { EmployeeID =1002, FirstName = "efgh", LastName = "Dhalla", Title = "AsstManager", City = "Mumbai", DOB=new DateTime(1984,08,20), DOJ =new DateTime(2012,7,7) },
                new Employee {EmployeeID=1003,FirstName= "Madhavi",LastName= "Oza",Title ="Consultant",City= "Pune",DOB=new DateTime(1987,11,14),DOJ=new DateTime(2015,4,12) },
                new Employee { EmployeeID = 1004, FirstName = "Saba", LastName = "Shaikh", Title = "SE", City = "Pune", DOB =new DateTime (1990,6,3), DOJ =new DateTime(2016,2,2) },
                new Employee {EmployeeID= 1005,FirstName= "Nazia", LastName = "Shaikh",Title="SE",City="Mumbai",DOB=new DateTime(1991,3,8),DOJ=new DateTime(2016,2,2)},
                new Employee {EmployeeID=1006,FirstName= "Amit",LastName= "Pathak",Title="Consultant",City= "Chennai",DOB=new DateTime(1989,11,7),DOJ=new DateTime(2014,8,8)},
                new Employee {EmployeeID=1007,FirstName="Vijay",LastName= "Natrajan",Title="Consultant",City= "Mumbai",DOB=new DateTime(1989,12,2),DOJ=new DateTime(2015,6,1)},
                new Employee {EmployeeID=1008,FirstName= "Rahul",LastName= "Dubey",Title= "Associate",City= "Chennai",DOB=new DateTime(1993,11,11),DOJ=new DateTime(2014,11,6)},
                new Employee {EmployeeID=1009,FirstName= "Suresh",LastName= "Mistry",Title= "Associate",City= "Chennai",DOB=new DateTime(1992,8,12),DOJ=new DateTime(2014,12,3)},
                new Employee {EmployeeID=1010,FirstName= "Sumit",LastName="Shah",Title="Manager",City= "Pune",DOB=new DateTime(1991,4,12),DOJ=new DateTime(2016,1,2) },
            };
            return emp;
            Console.ReadLine();
        }
        public static void Main()
        {
            DisplayEmployee();
            SkippingMumbai();
            PostionFilter();
            LastnameFilter();
            // DateOfJoinAfter2015();
            PostionFilterCandA();
            No_Of_Employee_in_Total();
            No_Of_Employee_in_Chennai();
            No_Of_Employee_not_Associate();
            // No_Of_Employee_groupde_City();
            Console.Read();
        }
        public static void DisplayEmployee()
        {
            Console.WriteLine("Employee details are : ");
            var e = from s in employees()
                    select s;
            foreach (var c in e)
            {
                Console.WriteLine("{0}     {1}        {2}       {3}       {4}       {5}      {6}", c.EmployeeID, c.FirstName, c.LastName, c.Title, c.City, Convert.ToDateTime(c.DOB).ToShortDateString(), Convert.ToDateTime(c.DOJ).ToShortDateString());
            }
        }
        //Skipping mumbai city
        public static void SkippingMumbai()
        {
            Console.WriteLine();
            Console.WriteLine("#########Skipping Mumbai city Employees##########");
            var SkipMumbai = from s in employees()
                             where s.City != "Mumbai"
                             select s;
            foreach (var c in SkipMumbai)
            {
                Console.WriteLine("{0}     {1}        {2}       {3}       {4}       {5}      {6}", c.EmployeeID, c.FirstName, c.LastName, c.Title, c.City, Convert.ToDateTime(c.DOB).ToShortDateString(), Convert.ToDateTime(c.DOJ).ToShortDateString());
            }
        }
        //Show only Employee details positioning AsstManager.
        public static void PostionFilter()
        {
            Console.WriteLine();
            Console.WriteLine("##########Displaying Assitant Managers in our Employee############");
            var Show_Asst_Manager = from s in employees()
                                    where s.Title == "AsstManager"
                                    select s;
            foreach (var c in Show_Asst_Manager)
            {
                Console.WriteLine("{0}     {1}        {2}       {3}       {4}       {5}      {6}", c.EmployeeID, c.FirstName, c.LastName, c.Title, c.City, Convert.ToDateTime(c.DOB).ToShortDateString(), Convert.ToDateTime(c.DOJ).ToShortDateString());
            }
        }
        //show only lname starts with s employee details
        public static void LastnameFilter()
        {
            Console.WriteLine();
            Console.WriteLine("############Employee detail with the sorting of last name starting with 'S'############");
            var LnameStartsWithS = from s in employees()
                                   where s.LastName.StartsWith("S")
                                   select s;
            foreach (var c in LnameStartsWithS)
            {
                Console.WriteLine("{0}     {1}        {2}       {3}       {4}       {5}      {6}", c.EmployeeID, c.FirstName, c.LastName, c.Title, c.City, Convert.ToDateTime(c.DOB).ToShortDateString(), Convert.ToDateTime(c.DOJ).ToShortDateString());
            }
        }
        ////  public static void DateOfJoinAfter2015()
        //  {
        //      int year = 2015;

        //      var Date_of_join = from s in employees()
        //                         //where 
        //                         select s;
        //      foreach (var c in Date_of_join)
        //      {
        //          Console.WriteLine("{0}     {1}        {2}       {3}       {4}       {5}      {6}", c.EmployeeID, c.FirstName, c.LastName, c.Title, c.City, Convert.ToDateTime(c.DOB).ToShortDateString(), Convert.ToDateTime(c.DOJ).ToShortDateString());
        //      }
        //  }
        public static void PostionFilterCandA()
        {
            Console.WriteLine();
            Console.WriteLine("#########Displaying Associates ang Consultants Managers in our Employee#########");
            var Show_Asst_Manager = from s in employees()
                                    where (s.Title == "Consultant" || s.Title == "Associate")
                                    select s;

            foreach (var c in Show_Asst_Manager)
            {
                Console.WriteLine("{0}     {1}        {2}       {3}       {4}       {5}      {6}", c.EmployeeID, c.FirstName, c.LastName, c.Title, c.City, Convert.ToDateTime(c.DOB).ToShortDateString(), Convert.ToDateTime(c.DOJ).ToShortDateString());
            }
        }
        public static void No_Of_Employee_in_Total()
        {
            Console.WriteLine();
            Console.WriteLine("########Number of Employees in this organization############");
            var num_Of_emp = from s in employees()
                             where s.EmployeeID > 0
                             select employees().Count();
            Console.WriteLine("No of Employees in All Branches: {0}", num_Of_emp.Count());
        }
        public static void No_Of_Employee_in_Chennai()
        {
            Console.WriteLine();
            Console.WriteLine("######Number of Employees in this organization Chennai Branch#######");
            var num_Of_emp = from s in employees()
                             where s.City == "Chennai"
                             select employees();
            Console.WriteLine("No of Employees in chennai office: {0}", num_Of_emp.Count());
        }
        public static void No_Of_Employee_not_Associate()
        {
            Console.WriteLine();
            Console.WriteLine("###########Number of Employees in this organization Not  Associate########");
            var num_Of_emp = from s in employees()
                             where s.Title != "Associate"
                             select employees();
            Console.WriteLine("No of Employees Except  Associate in our office: {0}", num_Of_emp.Count());
        }
        //public static void no_of_employee_groupde_city()
        //{
        //    Console.WriteLine();
        //    Console.WriteLine("########number of employees in this organization not  associate##########");
        //    var num_of_emp = from s in employees()
        //                     where s.City == "Mumbai"
        //                     select s;
        //    Console.WriteLine("no of employees except  associate in our mumbai office: {0}", num_of_emp.count());
        //}

    }
}



