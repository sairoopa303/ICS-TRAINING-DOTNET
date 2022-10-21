using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASSIGNMENT_7_1_
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }

        public Employee(int employeeID,
                      string FirstName,
                      string LastName,
                      string Title,
                      DateTime DOB,
                      DateTime DOJ,
                      string City)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Title = Title;
            this.DOB = DOB;
            this.DOJ = DOJ;
            this.City = City;
        }

        public Employee()
        {
            EmployeeID = 1030057;
            FirstName = "Sai";
            LastName ="Roopa";
            Title = "Associate Software Engineer";
            DOB = "23/09/2001";
            DOJ = "29/09/2022"
            City = "Andhrapradesh";
            ;
        }

        public override string ToString()
        {
            return 
                   "EmployeeID: " + EmployeeID + "\n" +
                   "FirstName: " + FirstName + "\n" +
                   "LastName: " + LastName + "\n" +
                   "Title: " + Title + "\n" +
                   "DOB: " + DOB + "\n" +
                   "DOJ: " + DOJ + "\n" +
                   "City: " + City + "\n" ;
            
        }
        
       
    }
}
