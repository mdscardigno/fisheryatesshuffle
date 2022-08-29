using System;
using System.Collections.Generic;

namespace FisherYatesShuffle
{
    class Program
    {
        // static Random random = new Random();

        // //shuffle the array
        // static void Shuffle<T>(T[] array)
        // {
        //     int n = array.Length;
        //     System.Console.WriteLine(n);
        //     for (int i = 0; i < (n - 1); i++)
        //     {
        //         //use the Next on random instance with an argument.
        //         // the argument is an exclusive bound
        //         //so we will not go past the end of array.
        //         int r = i + random.Next(n - i);
        //         System.Console.WriteLine("I am r:", r);
        //         T t = array[r];
        //         System.Console.WriteLine("I am r:");
        //         array[r] = array[i];
        //         array[i] = t;
        //     }
        // }
        static void Main(string[] args)
        {
            //     Console.WriteLine("Welcome to Fisher Yates Shuffle");
            //     int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //     Shuffle(array);
            //     System.Console.WriteLine("Shuffle: {0}", string.Join(", ", array));

            //     string[] array2 = { "bird", "frog", "cat" };
            //     Shuffle(array2);
            //     System.Console.WriteLine("Shuffle: {0}", string.Join(", ", array2));


            var students = new List<string>() {
                "Bathsheba Haselgrove",
                "Corinna Ducket",
                "Tamqrah Denham",
                "Nikos Maylam",
                "Aubrey Oxtiby",
                "Wenona Geall",
                "Aubine Coulsen",
                "Neils McSherry",
                "Maxim Pozer",
                "Ramsey Esslemont",
                "Gisella Ivakhin",
                "Adorne Muffen",
                "Dulciana Butterly",
                "Duffy Kimbell",
                "Brian Brehault",
                "Brig Johannes",
                "Clemmy Ickowicz",
                "Charles Capponer",
                "Hermie Casford",
                "Gwenora Walpole",
                "Jesse Datte",
                "Ignazio Esland",
                "Kassi Silverthorn",
                "Kristoforo Metzke",
                "Elinore Trickey",
                "Rowen Succamore",
                "Dyanna Lenglet",
                "Xylia Merchant",
                "Wilt Rushbury",
                "Florenza Cowen",
                "Barbabra Cashmore",
                "Chrysa Shaudfurth",
                "Osgood Heinel",
                "Mart Villa",
                "Sheelah Conklin",
                "Camila Primak",
                "Gunter Papa",
                "Erinna Tellenbrook",
                "Lilas Master",
                "Windham Bisson",
                "Nickie Minto",
                "Cassey Hawney",
                "Jethro Mityakov",
                "Will Lempke",
                "Thaine Dioniso",
                "Dicky Loraine",
                "Rodina Conaboy",
                "Auguste Stevens",
                "Wilie Mahood",
                "Phebe Baudy",
                "Ham Colling",
                "Sergei Woodworth",
                "Bessie Binny",
                "Berri Feveryear",
                "Eudora Darton",
                "Johna Wales",
                "Pascal McKeowon",
                "Angelica Bushen",
                "Sunny MacKaig",
                "Fleurette Gotobed",
                "Meggie MacGillivray",
                "Frederik Moff",
                "Duane Ackers",
                "Olvan Brownsey",
                "Joceline Wyld",
                "Brewster Inkles",
                "Jacquenetta Brobyn",
                "Tab Beiderbeck",
                "Margie Joskowicz",
                "Syd Albasiny",
                "Pacorro Stainbridge",
                "Lisbeth OHarney",
                "Nikolas Adame",
                "Berny Frewer",
                "Otha Fisby",
                "Debby Slowgrove",
                "Belicia Van",
                "Noami Currm",
                "Rheta Haquin",
                "Con Cheshir",
                "Arvie Scorthorne",
                "Gunther Skeeles",
                "Margette Ridler",
                "Edeline Stammer",
                "Pryce Bound",
                "Archie Neljes",
                "Rutger Keyson",
                "Jeddy Ralph",
                "Arlen Ashborne",
                "Taylor Anglin",
                "Frannie Nassy",
                "Jeremy Preuvost",
                "Willey Vallery",
                "Zacharie Woolfoot",
                "Warren Tiery",
                "Meggi Owlner",
                "Danette Jerok",
                "Norbie Simakov",
                "Rodney Whittaker",
                "Vere Timny"
            };

            //numberOfStudents = length of our students
            var numberOfStudents = students.Count;

            for (var rightIndex = numberOfStudents - 1; rightIndex >= 1; rightIndex--)
            {
                // for rightIndex from numberOfStudents - 1 down to 1 do:
                var randomNumberGenerator = new Random();
                //leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. See the section "How do we get a random integer")
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                System.Console.WriteLine($"Random number is: {leftIndex}");
                // System.Console.WriteLine($"The leftIndex is {leftIndex}");
                // System.Console.WriteLine($"The rightIndex is {rightIndex}");

                //   Now swap the values at rightIndex and leftIndex by doing this:
                //     leftStudent = the value from students[leftIndex]
                var leftStudent = students[leftIndex];

                //     rightStudent = the value from students[rightIndex]
                var rightStudent = students[rightIndex];

                //     students[rightIndex] = leftStudent
                students[rightIndex] = leftStudent;
                // System.Console.WriteLine($"The right student is {rightStudent}");

                //     students[leftIndex] = rightStudent
                students[leftIndex] = rightStudent;
                // System.Console.WriteLine($"The left student is {leftStudent}");
            }
            var firstStudent = students[0];
            System.Console.WriteLine($"The first student is {firstStudent}");
            // var secondStudent = students[1];
            // System.Console.WriteLine($"The second student is {secondStudent}");
            // foreach (var student in students)
            // {
            //     System.Console.WriteLine(student);
            // }
            //notes for hw
            //question is: do we just want to peek at the card or do we deal the card
            //What physical actions 
            //dealing the card removes it - how do i remove the two cards
            //
        }
    }
}
