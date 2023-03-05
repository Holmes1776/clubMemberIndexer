using System;
using System.Security.Cryptography.X509Certificates;

namespace Club
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }

            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = Members[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        Members[index] = value;
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            ClubMembers tunnelSnakes = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which club member do you wish to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }
                Console.WriteLine("Enter the name of the club member");
                tunnelSnakes[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop == "q")
                    end = true;
            }
            Console.WriteLine("What kind of club is it?");
            tunnelSnakes.ClubType = Console.ReadLine();
            Console.WriteLine("Where is their meet-up spot?");
            tunnelSnakes.ClubLocation = Console.ReadLine();
            Console.WriteLine("What date will they meet up?");
            tunnelSnakes.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here is information about the club");
            Console.WriteLine($"Club Members");
            for (int i = 0; i < Size; i++)
            {
                if (tunnelSnakes[i] != string.Empty)
                    Console.WriteLine(tunnelSnakes[i]);
            }
            Console.WriteLine($"Clue Type: {tunnelSnakes.ClubType}");
            Console.WriteLine($"Club Location: {tunnelSnakes.ClubLocation}");
            Console.WriteLine($"MeetingDate: {tunnelSnakes.MeetingDate}");
            Console.ReadLine();
        }
    }
}