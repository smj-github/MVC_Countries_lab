using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_MVC_Countries
{
    public enum Continent
    {
        Asia,
        Europe,
        Africa,
        NorthAmerica,
        SouthAmerica,
        Australia,
        Antartica
    }
    class Country
    {
        public string Name { get; set; }
        public Continent Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string name, Continent continent, List<string> colors)
        {
            Name = name;
            Continent = continent;
            Colors = colors;
        }
    }
}
