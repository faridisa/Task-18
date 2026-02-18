using System;
using System.Collections.Generic;
using System.Text;

namespace Task_18
{
    internal class Courier
    {
        private static int ID;
        public int Id { get; set; }
        public string CoruierName { get; set; }
        public bool IsAviaAble { get; set; }

        public Courier (string coruierName , bool isAviaAble)
        {
            CoruierName = coruierName;
            IsAviaAble = isAviaAble;
            ID++;
            Id = ID;
        }
    }
}
