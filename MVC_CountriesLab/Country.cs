using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_CountriesLab
{
    //supplies country data to other classes
    enum Continent
    { 
        NorthAmerica,
        SouthAmerica,
        Europe,
        Asia,
        Africa,
        Australia,
        Antarctica
    }
    class Country
    {
        public string Name { get; set; }
        public List<string> Colors { get; set; }
        public Continent Continent { get; set; }

        public Country() { }
        public Country(string Name, List<string> Colors, Continent Continent)
        {
            this.Name = Name;
            this.Colors = Colors;
            this.Continent = Continent;
        }

    }
}
