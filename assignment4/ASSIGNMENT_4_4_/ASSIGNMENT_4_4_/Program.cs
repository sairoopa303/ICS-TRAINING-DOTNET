﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ASSIGNMENT_4_4_
{
    class SalesDetails
    {
        int SalesNo;int ProductNo;float Price;string DateOfSale;int Qty;float TotalAmount;

        static void Main(string[] args)
        {
            SalesDetails s = new SalesDetails(66, 547, 1057.56f, "01/01/2001", 6);
            s.Sales(s.Qty, s.Price);
            s.ShowData();
            Console.Read();
        }
        public SalesDetails(int SalesNo, int ProductNo, float Price, string DateOfSale, int Qty)
        {
            this.SalesNo = SalesNo;this.ProductNo = ProductNo;this.Price = Price;this.DateOfSale = DateOfSale;this.Qty = Qty;
        }
        public float Sales(int Qty, float Price)
        {
            TotalAmount = Qty * Price;
            return TotalAmount;
        }
        public void ShowData()
        {
            Console.WriteLine("SALES DETAILS");
            Console.WriteLine("Sales Number: " + SalesNo);
            Console.WriteLine("Product Number: " + ProductNo);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Date of Sale: " + DateOfSale);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Total Amount: " + TotalAmount);
        }
    }
}
