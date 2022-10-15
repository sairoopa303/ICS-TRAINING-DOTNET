
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ASSIGNMENT_6_
{
    class TESTSTRUCTURES
    {
        static void Main(string[] args)
        {
            Books books = new Books();
            books.SetValues("MUKTHI FREEDOM", "Atman Ravi", "Discover a Way to Live with freedom from nisory om earth and from rebirth", 1030057);
            books.GetValues();
            Console.Read();
        }
    }
    struct Books
    {
        private string title; private string Author; private string Subject; private int Book_Id;

        public void GetValues()
        {
            Console.WriteLine("Book Details");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Subject: " + Subject);
            Console.WriteLine("Book ID: " + Book_Id);

        }
        public void SetValues(string Title, string authour, string subject, int BId)
        {
            title = Title; Author = authour; Subject = subject; Book_Id = BId;
        }

    }

}
