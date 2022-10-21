using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASSIGNMENT_7_1_
{
    class Client
    {
        static void Main(string[] args)
        {
            string EmployeeID = String.Empty;
            while (Validator.FieldIsEmpty(EmployeeID))
            {
                Console.WriteLine("Please enter the client EmployeeID: ");
                EmployeeID = Console.ReadLine();
            }
                //Validate and store all client input values
            string FirstName = String.Empty;
            while (Validator.FieldIsEmpty(FirstName))
            {
                Console.WriteLine("Please enter the client first name: ");
                FirstName = Console.ReadLine();
            }

            string LastName = String.Empty;
            while (Validator.FieldIsEmpty(LastName))
            {
                Console.WriteLine("Please enter the client last name: ");
                LastName = Console.ReadLine();
            }

            string Title = String.Empty;
            while (Validator.FieldIsEmpty(Title))         
            { 
                Console.WriteLine("Please enter the client Title: ");
                Title = Console.ReadLine();
            }

            String DOB = String.Empty;
            while (Validator.FieldIsEmpty(DOB))
            {
                Console.WriteLine("Please enter the client DOB: ");
                DOB = Console.ReadLine();
            }

            string DOJ = String.Empty;
            while (Validator.FieldIsEmpty(DOJ))
            { 
                Console.WriteLine("Please enter the client DOJ: ");
                DOJ= Console.ReadLine();
            }
            string City = String.Empty;
            while (Validator.FieldIsEmpty(City))
            {
                Console.WriteLine("Please enter the client City: ");
                City = Console.ReadLine();
            }

            //At this point we have all the required information, we can create our object!
            Client NewClient = new Client();

            //Display the client with the ToString method
            Console.Write(NewClient.ToString());
            Console.ReadKey();
        }
    }
} 

