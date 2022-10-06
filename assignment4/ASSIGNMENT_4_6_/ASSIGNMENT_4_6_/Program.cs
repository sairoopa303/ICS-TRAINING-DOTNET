using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ASSIGNMENT_4_6_
{
    class Doctor
    {
        private int RegNo
        {
            get;
            set;
        }
        private string Name
        {
            get;
            set;
        }
        private int FeesCharged
        {
            get;
            set;
        }
        static void Main(string[] args)
        {
            Doctor d = new Doctor();
            d.setName();
            d.getName();

            Console.Read();

        }
        public void setName()
        {
            Name = "SAIROOPA";
            RegNo = 1030057;
            FeesCharged = 666;
        }
        public void getName()
        {
            Console.WriteLine("Docter fee");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Register No :" + RegNo);
            Console.WriteLine("FeesCharged: " + FeesCharged);
        }
    }
}
