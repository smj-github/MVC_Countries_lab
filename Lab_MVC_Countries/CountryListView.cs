using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_MVC_Countries
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public void Display()
        {
            for (int i=0; i<Countries.Count;i++)
            {
                Console.WriteLine($"{i+1}: {Countries[i].Name}");
            }
        }
    }
}
