using System;

namespace HashTableDemonstration
{
    /// <summary>
    /// Model for a student.
    /// </summary>
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
        
        /// <summary>
        /// Gets a hash code for the table from the student ID.
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            uint modId = (_id % 999);
            string id = modId.ToString().PadLeft(8, '0');
            id = id.Substring(6, 2);
            return int.Parse(id);
        }
    }
}
