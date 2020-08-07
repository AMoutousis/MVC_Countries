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
            //for (int i = 0; i < countries.Count; i++)
            //{
            //    Console.WriteLine($"{i}. {countries.}");
            //}
            foreach (Country count in countries)
            {
                Console.WriteLine($"{temp}. {count.Name}");
                temp++;
            }
        }
    }
}
