using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;

           // Console.WriteLine(GetHint(""));
            // Console.WriteLine(GetGuess("AOT"));

            SayHi("Levi");
            Contain();

            // Console.WriteLine(anime("AOT YO"));

            anime("yo");
            SayNo(7);
            Array();

            Console.WriteLine(GetDay(0));
            Console.WriteLine(GetNo(255));

            Story lie = new Story();
            lie.name = "Robin Hood";
            lie.location = "Westworld";
            lie.hasWeapon = true;
            lie.teller();

            Story truth = new Story();
            truth.name = "King's mage";
            truth.location = "Palace";
            truth.hasWeapon = true;
            truth.teller();

            Story book = new Story();
            book.name = "Love or Hate manga";
            book.location = "Internet";
            book.hasWeapon = false;
            book.teller();

            Song playlist = new Song();
            playlist.artist = "BTS";
            playlist.duration = 3.55;
            playlist.title = "DNA";
            playlist.genre = "K-pop";
            playlist.music();

            Student minor = new Student();
            minor.name = "Jim";
            minor.major = "Business";
            minor.gpa = 2.8;
            minor.learner();
            Console.WriteLine(minor.hasHoners());

            Student underage = new Student();
            underage.name = "Pam";
            underage.major = "Arts";
            underage.gpa = 3.6;
            underage.learner();
            Console.WriteLine(underage.hasHoners());
        }
        static void Contain()
        {
            string name = "Levi";
            if (name == "Levi")
            {
                Console.WriteLine("Kamona");
                Console.Beep();

            }
            else
            {
                Console.WriteLine("Nani");
            }

            bool Weather = false;
            bool Umbrella = false;
            if (Weather && Umbrella)
            {
                Console.WriteLine("You can buy something for family cos u hv an umbrella");
            }
            else if (!Weather || Umbrella)
            {
                Console.WriteLine("You come enter rain without Umbrella");
            }
            else if (Weather || !Umbrella)
            {
                Console.WriteLine("The weather is clear so nice need for umbrella.....in fact u no even get one sha");
            }
            else
            {
                Console.WriteLine("It raining ......stay home dear u no get umbrella or u want enter rain");
            }
        }

        static void Array() //Array of numbers
        {
            try
            {
                int[,] numberGrid =
            {
                {106,7},
                {2,69},
                {22,19}
            };
                Console.WriteLine(numberGrid[0, 7]);
            }
            catch {
                Console.WriteLine("ERROR");
            }

        }

        static int SayNo(int num)
        {
            if (num == 7)
            {
                Console.WriteLine("The Number for BTS");
            }
            else
            {
                Console.WriteLine("The code did not work");
            }
            return num;
        }

        static void SayHi(string name)
        {
            Console.WriteLine("YO " + name + " You feeling the UPTOWN FUNK"); // This is a method without a return function
        }


        static string anime(string name) // method with return function

        {
            string result = "AOT";
            return result;
        }

        static string GetDay(int dayNum) // a switch
        {
            string dayName = "";

            switch (dayNum)
            {
                case 0:
                    dayName = "This";
                    break;
                case 1:
                    dayName = "second"; break;
            }
            return dayName;
        }

        static int GetNo(int dayNo) // a switch
        {
            int dayNumber = 25;
            switch (dayNo)
            {
                case 0:
                    dayNumber = 1;
                    break;
                case 1:
                    dayNumber = 2;
                    break;
                case 25:
                    dayNumber = 3;
                    break;

            }
            return dayNumber;
        }

        static string GetHint(String hint) //a while
        {
            string Hint = "";
            string HintAns = "yes";
            string Lost = "i dont know";
            string SecretWord = "Freedom";

            while (Hint != Lost && Hint != SecretWord)
            {
                Console.WriteLine("This is a guessing game and you need to answer correctly to get the info");
                Console.Write("What is Eren Yeager motto:  ");
                Hint = Console.ReadLine();
            }

            while (Hint != HintAns && Hint != SecretWord)
            {
                Console.Write("DO you want an Hint?    ");
                Hint = Console.ReadLine();
                Console.WriteLine(" What did EREN YEAGER say to ARMIN in the lastest season?");
                Hint = Console.ReadLine();
            }
            return hint;
        }
    }

    public class Story   //a class
    {
        public string name;
        public string location;
        public bool hasWeapon;

        public void teller()
        {
            Console.WriteLine("The person was spotted stealing " + name + " at the place of the dead meet " + location);
        }

    }

    public class Song   //a class
    {
        public string artist;
        public double duration;
        public string title;
        public string genre;

        public void music()
        {
            Console.WriteLine("Hey guys have you heard " + title + " by this dope singer " + artist + ",It might not be your taste of song since its " + genre + " but am sure you will love it since it a " + duration + "minute song......but just give it a listen before you cancel it out of your playlist");
        }
    }

    public class Student   //working with a class......i
    {
        public string name;
        public string major;
        public double gpa;

        public void learner()
        {
            Console.WriteLine("");
        }

        public bool hasHoners()  //working with an class that has a method.....ii
        {
            if (gpa >= 3.5)
            {
               return true;
            }
             return false;
        }
        
    }


}
