using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_MVC_Countries
{
    class CountryController
    {
        public List<Country> CountryDb { get; set; } = new List<Country>
        {
            new Country("Mexico",Continent.NorthAmerica,new List<string>{"green", "white","red" }),
            new Country("Denmark",Continent.Europe,new List<string>{"white", "red"}),
            new Country("Canada",Continent.NorthAmerica,new List<string>{"red", "white","blue" })
        };

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
        }

        public void WelcomeAction()
        {
            CountryListView clv = new CountryListView(CountryDb);
            Console.WriteLine("Hello, welcome to the country app.");

            while (true)
            {
                Console.WriteLine("Please select a country from the following list:");
                clv.Display();                
                int countryIndex;
                while(!int.TryParse(Console.ReadLine(),out countryIndex))
                {
                    Console.WriteLine("Invalid Input. Try again!");
                }

                CountryAction(CountryDb[countryIndex - 1]);

                Console.WriteLine("\nWould you like to learn about another country? y/n");
                try
                {
                    if (Console.ReadLine().ToLower()[0] != 'y')
                    {
                        break;
                    }
                }                
                catch
                {
                    Console.WriteLine("Invalid Input! Press any key to try again!");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }
    }
}
