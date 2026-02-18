using System;
using System.Collections.Generic;
using System.Text;

namespace Task_18
{
    internal class Customer
    {
        private static int ID;

        public int Id { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(string name, string city)
        {
            ID ++;
            Id = ID;
            Name = name;
            City = city;
        }
    }
}
