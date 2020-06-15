using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = null;

            OurHashTable<Student> table = new OurHashTable<Student>();

            for (int i = 100; i < 10000; i += 100)
            {
                s = new Student();
                s.ID = (uint)(97 + i);

                table.Add((int)s.ID, s);
            }

            s = new Student();
            s.ID = (uint)(97 + 9800);

            table.Add((int)s.ID, s);

            var z = table.Get(999997, new Student { ID = 197 });

            s = new Student();
            s.ID = (uint)(97 + 9900);

            table.Add((int)s.ID, s);
        }
    }
}
