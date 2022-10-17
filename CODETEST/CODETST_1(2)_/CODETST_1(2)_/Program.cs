using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CODETEST_2_
{
    class Box
    {
        private double length;
        private double breadth;


        public void setLength(double len)
        {
            length = len;
        }
        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public double getlength()
        {
            return length + breadth;
        }
        public double getbreadth()
        {
            return length + breadth;
        }

    }

        class Box1
        {
            static void Main(string[] args)
            {
                Box Box1 = new Box();
                Box Box2 = new Box();
                double length;
                double breadth;

                Box1.setLength(6.0);
                Box1.setBreadth(16.0);

                Box2.setLength(6.0);
                Box2.setBreadth(16.0);


                length = Box1.getlength();
                Console.WriteLine("length of Box1 : {0}", length);

                length = Box2.getlength();
                Console.WriteLine("length of Box2 : {0}", length);

                Console.ReadLine();


                breadth = Box1.getbreadth();
                Console.WriteLine("breadth of Box1 : {0}", breadth);

                breadth = Box2.getbreadth();
                Console.WriteLine("breadth of Box2 : {0}", breadth);
                Console.ReadLine();


            }
        }
    }



