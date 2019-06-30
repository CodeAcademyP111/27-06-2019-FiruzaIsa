using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroup
{
    class GroupType
    {

        private static int ID;
        public string Name;
        public float Price;
        public GroupType(string type,int price)
        {
            ID++;
            Name = type;
            Price = price;
        }


    }


}
