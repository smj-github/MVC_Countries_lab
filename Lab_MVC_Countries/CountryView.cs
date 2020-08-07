using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_MVC_Countries
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {DisplayCountry.Name}");
            Console.WriteLine($"Continent: {DisplayCountry.Continent}");
            Console.Write($"Colors: ");
            for(int i=0; i<DisplayCountry.Colors.Count; i++)
            {
                ConsoleColor color;
                if (!Enum.TryParse(DisplayCountry.Colors[i], true, out color))
                {
                    Console.WriteLine("Can't display color");
                }
                else
                {
                    Console.BackgroundColor = color;
                }

                if (i== DisplayCountry.Colors.Count-1)
                {
                    Console.Write(DisplayCountry.Colors[i]);
                }
                else
                {
                    Console.Write(DisplayCountry.Colors[i] + ",");
                }

                
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
            
        }
    }
}
