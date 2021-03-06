﻿using System;

namespace HashTableDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {   
            Student s;
            OurHashTable<Student> table = new OurHashTable<Student>();

            // Let's do something real-world and add names to these
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
            Random rnd = new Random();

            // If you want to test using random IDs, uncomment this line....
            //int[] idArray = IDArray(rnd);

            // ... and then comment this block
            int[] idArray = new int[]
            {
                99999999, 99999999, 75000000, 50000000, 25000, 15000, 10000, 5000, 1,
                20000, 15783, 13452, 12336, 8833, 5587, 2364, 1201, 739, 294, 19
            };

            // this is only the iterator for the names array
            int i = 0;

            foreach (int _id in idArray)
            {
                s = new Student {ID = (uint) (_id), Name = names[i], GPA = MakeGPA(rnd)};
                table.Add((int)s.ID, s);
                Console.WriteLine("ID NO:\t\t" + s.ID + "\t\tNAME:\t" + s.Name.ToString() + "\t\tGPA: " + s.GPA);
                i++;
            }

            Environment.Exit(0);
        }

        /// <summary>
        /// Builds a random-ish GPA.
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>decimal</returns>
        public static decimal MakeGPA(Random rnd)
        {
            int fullPoint = rnd.Next(0, 4);
            int decVals = rnd.Next(0, 100);
            string gpa = fullPoint.ToString() + "." + decVals.ToString();
            decimal fullGPA = decimal.Parse(gpa);
            return fullGPA;
        }

        /// <summary>
        /// Method to return a random ID between 1 and 99999999 inclusive.
        /// See comments in Program class.
        /// </summary>
        /// <param name="rnd"></param>
        /// <returns>int[]</returns>
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
