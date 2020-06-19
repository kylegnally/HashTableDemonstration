using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemonstration
{
    class Student
    {
        private uint _id;
        private string _name;
        private decimal _gpa;

        public uint ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null)
                    _name = value;
                else
                    throw new ArgumentNullException("Name cannot be null!");
            }
        }


        public decimal GPA
        {
            get
            {
                return _gpa;
            }
            set
            {
                if (value >= 0.0m && value <= 4.0m)
                    _gpa = value;
            }
        }
        
        public override int GetHashCode()
        {
            // let's use this and hopefully scramble the numbers a bit more
            uint modId = (_id % 999);
            string id = modId.ToString().PadLeft(8, '0');
            id = id.Substring(6, 2);
            return int.Parse(id);
        }
    }
}
