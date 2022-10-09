using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKETBOOKING_5_2_
{
    class TICKETBOOKING
    {
        static void Main()
        {
            Passenger passenger = new Passenger();
            bool IsBookingFailed;
            do
            {
                IsBookingFailed = false;

                string name1; string name2; int age2; int age1;
                Console.WriteLine("Enter How Many Tickets");
                try
                {
                    int noOfTickets = Convert.ToInt32(Console.ReadLine());
                    if (noOfTickets > 2)
                    {
                        passenger.TicketBooking(noOfTickets);
                    }
                    else if (noOfTickets == 2)
                    {
                        Console.WriteLine("Enter the Name of the Passanger: ");
                        name1 = Console.ReadLine();
                        Console.WriteLine("Enter the Age of the Passanger: ");
                        age1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name of the Passanger: ");
                        name2 = Console.ReadLine();
                        Console.WriteLine("Enter the Age of the Passanger: ");
                        age2 = Convert.ToInt32(Console.ReadLine());
                        passenger.TwoPassanger(name1, name2, age1, age2);
                        passenger.TicketBooking(noOfTickets);
                    }
                    else
                    {
                        Console.WriteLine("Enter the Name of the Passanger: ");
                        name1 = Console.ReadLine();
                        Console.WriteLine("Enter the Age of the Passanger: ");
                        age1 = Convert.ToInt32(Console.ReadLine());
                        passenger.OnePassenger(name1, age1);
                        passenger.TicketBooking(noOfTickets);
                    }
                }
                catch (NoOfPersonExceedsException NE)
                {
                    Console.WriteLine("Ticket Booking Failed: " + NE.Message);
                    IsBookingFailed = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid details");
                    IsBookingFailed = true;
                }
            } while (IsBookingFailed == true);

            Console.ReadLine();
        }
    }
    class Passenger
    {
        string Name1; string Name2; int Age1; int Age2;
        public void OnePassenger(string Name1, int Age1)
        {
            this.Name1 = Name1;
            this.Age1 = Age1;
        }
        public void TwoPassanger(string Name1, string Name2, int Age1, int Age2)
        {
            this.Name1 = Name1; this.Age1 = Age1; this.Age2 = Age2; this.Name2 = Name2;
        }
        public void TicketBooking(int noOfTickets)
        {
            if (noOfTickets > 2)
            {
                throw (new NoOfPersonExceedsException("Cannot book more than two tickets "));
            }
            else
            {
                TicketStatus(noOfTickets);
            }
        }
        public void TicketStatus(int noOfTickets)
        {
            if (noOfTickets == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for booking tickets");
                Console.WriteLine("Passenger Name: " + Name1);
                Console.WriteLine("Passanger Age: " + Age1);
                Console.WriteLine("Passenger Name: " + Name2);
                Console.WriteLine("Passanger Age: " + Age2);
                Console.WriteLine("Total number of passangers: " + noOfTickets);
                Console.WriteLine();
                Console.WriteLine("Ticket Booked Successfully");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for booking tickets");
                Console.WriteLine("Passenger Name: " + Name1);
                Console.WriteLine("Passanger Age: " + Age1);
                Console.WriteLine("Total number of passangers: " + noOfTickets);
                Console.WriteLine("Ticket Booked Successfully");
            }
        }
    }
    class NoOfPersonExceedsException : ApplicationException
    {
        public NoOfPersonExceedsException(string msg) : base(msg)
        {
        }
    }
}
