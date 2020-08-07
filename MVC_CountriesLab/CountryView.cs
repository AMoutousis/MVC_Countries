using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_CountriesLab
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }
        //this class contains all of the front end code
        public CountryView() { }
        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Here's the read out on your country: ");
            Console.WriteLine($"Name: {DisplayCountry.Name}");


            foreach (string color in DisplayCountry.Colors)
            {
                Console.WriteLine($"The colors of your country are: {color}");
            }

            Console.WriteLine($"Your country is in continent: {DisplayCountry.Continent}");

        }
    }
}
