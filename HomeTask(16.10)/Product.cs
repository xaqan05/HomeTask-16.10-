using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16._10_
{
    public class Product
    {
        private double _price;
        private int _count;

        public int No;
        public string Name;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price 0 ve ya menfi ola bilmez.");
                }


            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {

                    _count = value;
                }
                else
                {
                    Console.WriteLine("Count 0 ve ya menfi ola bilmez.");
                }
            }

        }
        public Product(double price,int count,int no,string name)
        {
            Price = price;
            Count = count;
            No = no;
            Name = name;
        }
    }
}
