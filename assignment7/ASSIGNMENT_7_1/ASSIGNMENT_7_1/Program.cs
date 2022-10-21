using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_7_1
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string city { get; set; }

        //public int EmployeeID;
        //public string FirstName;
        //public string LastName;
        //public string title;
        //public DateTime DOB;
        //public DateTime DOJ;
        //public string city;


        public static List<Employee> GetEmployee()
        {
            List<Employee> emplist = new List<Employee>
            {
                new Employee {EmployeeID = 1001, FirstName = "Malcolm", LastName = "Daruwalla", title = "Manager", city = "Mumbai", DOB = new DateTime(1984/11/20), DOJ = new DateTime(2011,6,8) },
                new Employee {EmployeeID =1002, FirstName = "Asdin", LastName = "Dhalla", title = "AsstManager", city = "Mumbai", DOB=new DateTime(1984,08,20), DOJ =new DateTime(2012,7,7) },
                new Employee {EmployeeID=1003,FirstName= "Madhavi",LastName= "Oza",title ="Consultant",city= "Pune",DOB=new DateTime(1987,11,14),DOJ=new DateTime(2015,4,12) },
                new Employee {EmployeeID=1004, FirstName = "Saba", LastName = "Shaikh", title = "SE", city = "Pune", DOB =new DateTime (1990,6,3), DOJ =new DateTime(2016,2,2) },
                new Employee {EmployeeID= 1005,FirstName= "Nazia", LastName = "Shaikh",title="SE",city="Mumbai",DOB=new DateTime(1991,3,8),DOJ=new DateTime(2016,2,2)},
                new Employee {EmployeeID=1006,FirstName= "Amit",LastName= "Pathak",title="Consultant",city= "Chennai",DOB=new DateTime(1989,11,7),DOJ=new DateTime(2014,8,8)},
                new Employee {EmployeeID=1007,FirstName="Vijay",LastName= "Natrajan",title="Consultant",city= "Mumbai",DOB=new DateTime(1989,12,2),DOJ=new DateTime(2015,6,1)},
                new Employee {EmployeeID=1008,FirstName= "Rahul",LastName= "Dubey",title= "Associate",city= "Chennai",DOB=new DateTime(1993,11,11),DOJ=new DateTime(2014,11,6)},
                new Employee {EmployeeID=1009,FirstName= "Suresh",LastName= "Mistry",title= "Associate",city= "Chennai",DOB=new DateTime(1992,8,12),DOJ=new DateTime(2014,12,3)},
                new Employee {EmployeeID=1010,FirstName= "Sumit",LastName="Shah",title="Manager",city= "Pune",DOB=new DateTime(1991,4,12),DOJ=new DateTime(2016,1,2) },
            };
            return emplist;
        }
    }

    class EmployeeLinqEg
    {
        static void Main(string[] args)
        {
            //a. Displaying details of all the employees

            Console.WriteLine("Employee details are : ");
            var emp = from allEmplees in Employee.GetEmployee()
                      select allEmplees;

            foreach (var allEmps in emp)
            {

                Console.WriteLine(allEmps.EmployeeID + "\t" + allEmps.FirstName + "\t" + allEmps.LastName + "\t" + allEmps.title + "\t" + allEmps.city + "\t" + allEmps.DOB.ToShortDateString() + "\t" + allEmps.DOJ.ToShortDateString());

            }


            // b. Display details of all the employee whose location is not Mumbai


            //var emp1=from mumbaiEmp in Employee.GetEmployee()
            //         where mumbaiEmp.city.Length





            Console.ReadKey();
        }
    }
}
