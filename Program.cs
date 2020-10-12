using System;
using System.Globalization;

namespace AlgoOne {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");

            Test ();
            Test2 ();
            Test3 ();
            Test4 ();
        }

        public static void Test () {
            string firstname = "abby", lastname = "olive";
            int year = 2016;

            string note = firstname + " " + lastname.ToUpper () + "got me mad back in OG" + year;

            string initials = firstname[0] + "." + lastname[0] + ".";

            Console.WriteLine (firstname);

            string notex = string.Format ("{0} {1} was born in {2}", firstname, lastname.ToUpper (), year);

            Console.WriteLine (note);
            Console.WriteLine (notex);
        }

        public static void Test2 () {

            string dateTimeString = Console.ReadLine ();
            if (!DateTime.TryParseExact (dateTimeString, "M/d/yyyy HH:mm", new CultureInfo ("en-US"), DateTimeStyles.None, out DateTime dateTime)) {
                dateTime = DateTime.Now;

            }

            ConsoleKeyInfo Key = Console.ReadKey ();
            switch (Key.Key) {
                case ConsoleKey.S:
                    break;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.Escape:
                    break;
            }

        }

        // Writting To Output
        public static void Test3 () {
            string roomNumber = "B35";
            int peopleCount = 2;
            DateTime reservationDate = new DateTime (2020, 10, 12, 16, 0, 0);
            CultureInfo cultureInfo = new CultureInfo ("en-us");

            Console.WriteLine (
                "Room {0} has been booked for {1} people on {2} at {3} by Marlians",
                roomNumber,
                peopleCount,
                reservationDate.ToString ("M/d/yyy", cultureInfo),
                reservationDate.ToString ("HH:mm", cultureInfo));

        }

        public static void Test4 () {

            CultureInfo cultureInfo = new CultureInfo ("en-US");

            Console.Write ("The Teams Playing:-");
            string teams = Console.ReadLine ();

            Console.Write ("The numbers of Players:-");
            string countPlayers = Console.ReadLine ();
            int.TryParse (countPlayers, out int count);

            Console.Write ("The fixture date (MM/dd/yyyy):-");
            string dateTimeString = Console.ReadLine ();
            if (!DateTime.TryParseExact (dateTimeString,
                    "M/d/yyyy HH:mm",
                    cultureInfo,
                    DateTimeStyles.None, out DateTime dateTime)) {
                dateTime = DateTime.Now;
            }

            Console.WriteLine ("Field {0} have been scheduled to for {1} players on {2} at {3}", teams, countPlayers, dateTime.ToString ("M/d/yyyy", cultureInfo),
                dateTime.ToString ("HH:mm", cultureInfo));

        }

    }
}