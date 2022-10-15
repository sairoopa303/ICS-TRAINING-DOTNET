
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ASSIGNMENT_6_
{
    public class PRODUCTS
    {
        static void Main(string[] args)
        {
            List<Products> stdlist = new List<Products>
            {
                new Products{ProductId=1,Product_Name="abcd",Price=10.0f},
                new Products{ProductId=2,Product_Name="efgh",Price=20.0f},
                new Products{ProductId=3,Product_Name="ijkl",Price=30.0f},
                new Products{ProductId=4,Product_Name="mnop",Price=40.0f},
                new Products{ProductId=5,Product_Name="qrst",Price=50.0f},
                new Products{ProductId=6,Product_Name="uvwx",Price=60.0f},
                new Products{ProductId=7,Product_Name="yzab",Price=70.0f},
                new Products{ProductId=8,Product_Name="cdef",Price=80.0f},
                new Products{ProductId=9,Product_Name="ghij",Price=90.0f},
                new Products{ProductId=10,Product_Name="qrst",Price=100.0f}
            };
            Display(stdlist);
            Console.Read();
        }
        public static void Display(List<Products> products)
        {
            Console.WriteLine();
            var val = products.OrderBy(a => a.Price).ToList();
            foreach (var p in val)
            {
                Console.WriteLine("name: {0}, id: {1}, Price: {2} ", p.Product_Name, p.ProductId, p.Price);
            }
        }
    }

    public class Products
    {
        public int ProductId 
        { 
            get;
            set;
        }
        public string Product_Name 
        { 
            get; 
            set;
        }
        public float Price
        { 
            get; 
            set;
        }


    }
}
