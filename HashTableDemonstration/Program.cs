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
            Student s;
            OurHashTable<Student> table = new OurHashTable<Student>();
            Random rnd = new Random();

            string[] names = new string[]{
                "Taylen Hooks",
                "Gianni Bruno",
                "Noe Sanders",
                "Fredy Mann",
                "Marissa Kern",
                "Evin Gardner",
                "Raymond Rosario",
                "Maycee Friedman",
                "Marcus Nava",
                "Scout Freeman",
                "Alyssa Triplett",
                "Malakhi Fuentes",
                "Dulce Crandall",
                "Heriberto Sears",
                "Branson Wesley",
                "Priscilla Montano",
                "Lucia Camacho",
                "Jai Mcguire",
                "Elia Perkins",
                "Nichole Wolf",
                "Jacelyn Springer",
                "Samson Flynn",
                "Aaradhya Mcfadden",
                "Milly Brown",
                "Fernando Henderson",
                "Kenleigh Pickett",
                "Amiya Bouchard",
                "Leilani Cantrell",
                "Janet Moss",
                "Briar Begay",
                "Winter Lane",
                "Demarcus Bowden",
                "Semaj Gunter",
                "Fred Talley",
                "Chester Kenny",
                "Grayson Holmes",
                "Raymond Underwood",
                "Kennedy Workman",
                "Lilianna Sanderson",
                "Brystol Staton",
                "Chael Spence",
                "Raheem Grace",
                "Scott Teague",
                "Zephaniah Mckinley",
                "Boyd Hull",
                "Kyrin Dougherty",
                "Margo Bishop",
                "Derick Vasquez",
                "Karma Purvis",
                "Kody Cote",
                "Kinleigh Fields",
                "Christian Bush",
                "Zaya Townsend",
                "Glenn Wills",
                "Ashtyn Fitzgerald",
                "Ever Pugh",
                "Cecily Nicholas",
                "Hayden Nash",
                "Duncan Hudson",
                "Briar Bland",
                "Isa Mcginnis",
                "Cash Ervin",
                "Brooks Newman",
                "Rodney Tracy",
                "Mickey Sparks",
                "Jean Medrano",
                "Kenzie Krueger",
                "Zachery Driver",
                "Dillon Hand",
                "Kaidan Prescott",
                "Jaya Beltran",
                "Isabella King",
                "Rylee Boyer",
                "Apollo Meade",
                "Sean Sinclair",
                "Avianna Weaver",
                "Preston Mathews",
                "Mariano Moreno",
                "Elayna Graham",
                "Gray Walsh",
                "Adriano Evans",
                "Serena Sanders",
                "Devante Ball",
                "Lilliana Cummins",
                "Lexie Mclaughlin",
                "Ada Engle",
                "Ross Mccarthy",
                "Audrie Slaughter",
                "Asha Hudson",
                "King Zapata",
                "Zaylee Hogue",
                "Lillyan Keenan",
                "Micah Mcallister",
                "Allyson Lott",
                "Dwayne Carey",
                "Roman Haas",
                "Matteo Lyon",
                "Nova Ladner",
                "Aston Callahan",
                "Antoine Norton"
            };

            int[] idArray = new int[]
            {
                99999999, 99999999, 75000000, 50000000, 25000, 15000, 10000, 7823, 4599, 9999, 300567, 5000, 1
            };

            //int[] idArray = IDArray(rnd);
            rnd = new Random();

            // int[] modulusResults = new int[idArray.Length + 1];
            int i = 0;

            foreach (int _id in idArray)
            {
                s = new Student();
                // modulusResults[i] = _id % 100;
                s.ID = (uint)(_id);
                s.Name = names[i];
                s.GPA = s.GetGPA(rnd);
                //s.Name = nameArray[i];
                table.Add((int)s.ID, s);
                //Console.WriteLine(modulusResults[i].ToString() + "\n");
                //Console.WriteLine(/*"NAME:\t\t\t" + s.Name + "\n" + */"ID:\t\t\t" + s.ID.ToString() + "\n");
                //i++;
            }

            Environment.Exit(0);

            //for (int i = 0; i < )
            //for (int i = 100; i < 10000; i += 100)
            //{
            //    s = new Student();
            //    s.ID = (uint)(97 + i);

            //    table.Add((int)s.ID, s);
            //}

            //s = new Student();
            //s.ID = (uint)(97 + 9800);

            //table.Add((int)s.ID, s);

            //var z = table.Get(999997, new Student { ID = 197 });

            //s = new Student();
            //s.ID = (uint)(97 + 9900);

            //table.Add((int)s.ID, s);
        }

        private static int[] IDArray(Random rnd)
        {
            int[] id = new int[100];
            int n;
            string t;

            for(int i = 0; i < id.Length; i++)
            {
                t = rnd.Next(1, 10000000).ToString().PadLeft(8,'0');
                id[i] = int.Parse(t);
            }

            return id;
        }
    }
}
