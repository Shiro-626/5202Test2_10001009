using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program

        //Mabel Cao - 5202 Test 2
        //This program captures information that the user inputs to record data about a New Zealand Bird of Prey. 
        //It displays the Name, Species, Sex, Weight and Band number after prompting the user to update the Bird information
    {
        static void Main(string[] args)
        {
            //Creates a new Bird object
            Bird bird1 = new Bird("Name Unknown", "Species Unknown", "Sex Unknown", "Weight Unknown", "Band Number Unknown");   //populated with default data

            Console.WriteLine("\nPLEASE UPDATE BIRD DATA");

            Console.WriteLine("\nEnter Bird name: ");
            bird1.Name = Console.ReadLine();

            Console.WriteLine("Enter Species: ");
            bird1.Species = Console.ReadLine();

            Console.WriteLine("Enter Sex of Bird: ");
            bird1.Sex = Console.ReadLine();

            Console.WriteLine("Enter Weight of Bird: ");
            bird1.Weight = Console.ReadLine();

            Console.WriteLine("Enter Band Number of Bird: ");
            bird1.BandNo = Console.ReadLine();

            Console.WriteLine("\n*****************************");
            Console.WriteLine("BIRD OF PREY DATA OUTPUT");
            Console.WriteLine(bird1.DisplayBird());                                   //Calls the DisplayBird method
            Console.WriteLine("*****************************");

            Console.ReadLine();

        }

        //Class
        class Bird
        {
            //Private properties
            private string name;
            private string species;
            private string sex;
            private string weight;
            private string bandNo;

            //Public getters and setters
            public string Name { get { return name; } set { name = value; } }
            public string Species { get { return species; } set { species = value; } }
            public string Sex { get { return sex; } set { sex = value; } }
            public string Weight { get { return weight; } set { weight = value; } }
            public string BandNo { get { return bandNo; } set { bandNo = value; } }


            //Public constructor
            public Bird(string _name, string _species, string _sex, string _weight, string _bandNo)
            {
                Name = _name;
                Species = _species;
                Sex = _sex;
                Weight = _weight;
                BandNo = _bandNo;

                Console.WriteLine("Bird object created and default data loaded...");
            }

            //Public method
            //Returns the Name, Species, Sex, Weight, Band Number
            public string DisplayBird()
            {
                return "Bird name: " + Name + "\nSpecies: " + Species + "\nSex: " + Sex + "\nWeight: " + Weight + "\nBand Number: " + BandNo;
                
            }


        }

    }
}
