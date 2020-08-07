using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_CountriesLab
{
    class CountryListView
    {
        List<Country> countries = new List<Country>();
        public CountryListView(List<Country> countries)
        {
            this.countries = countries;
        }
        public void Display()
        {
            int temp = 0;

            foreach (Country count in countries)
            {
                Console.WriteLine($"{temp+1}. {count.Name}");
                temp++;
            }
        }
    }
}
