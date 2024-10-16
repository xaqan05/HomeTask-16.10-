using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask_16._10_
{
    public class Book:Product
    {
        public string Genre;


        public Book(double price,int no,int count,string name,string genre):base(price,no,count,name)
        {
            Genre = genre;
        }

        public void showInfo()
        {
            Console.WriteLine($"Name: {Name}, Genre: {Genre}, No: {No}, Count: {Count}, Price: {Price}");
        }
    }
}
