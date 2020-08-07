using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Xml;

namespace MVC_CountriesLab
{
    class CountryController
    {
        //big boss 
        //this is where most, if not all, of the program logic will be

        public List<Country> countrydb { get; set; }

        public CountryController()
        {
            //List<Country> countrydb = new List<Country>()
            //{
            //    new Country() { Name = "United States of America", Colors = new List<string>() { "Red", "White", "Blue" }, Continent = Continent.Africa },
            //    new Country() { Name = "Greece", Colors = new List<string> { "Blue", "White" }, Continent = Continent.Europe },
            //    new Country() { Name = "Australia", Colors = new List<string> { "Green", "Gold" }, Continent = Continent.Australia },
            //    new Country() { Name = "Canada", Colors = new List<string> { "Red", "White" }, Continent = Continent.NorthAmerica },
            //    new Country() { Name = "Japan", Colors = new List<string> { "Red", "White" }, Continent = Continent.Asia },
            //    new Country() { Name = "Morocco", Colors = new List<string> { "Red", "Green" }, Continent = Continent.Africa },
            //    new Country("France",  new List<string>(){"Red White & Blue" }, Continent.Europe)

            //};

            //countrydb.Add(new Country() { Name = "Test", Colors = new List<string>() { "Red", "White", "Blue" }, Continent = Continent.Africa });
            

        }
        public void CountryAction(Country c)
        {
            CountryView v = new CountryView(c);
            v.Display();

        }
        public void WelcomeAction()
        {
            List<Country> countrydb = new List<Country>()
            {
                new Country() { Name = "United States of America", Colors = new List<string>() { "Red", "White", "Blue" }, Continent = Continent.NorthAmerica },
                new Country() { Name = "Greece", Colors = new List<string> { "Blue", "White" }, Continent = Continent.Europe },
                new Country() { Name = "Australia", Colors = new List<string> { "Green", "Gold" }, Continent = Continent.Australia },
                new Country() { Name = "Canada", Colors = new List<string> { "Red", "White" }, Continent = Continent.NorthAmerica },
                new Country() { Name = "Japan", Colors = new List<string> { "Red", "White" }, Continent = Continent.Asia },
                new Country() { Name = "Morocco", Colors = new List<string> { "Red", "Green" }, Continent = Continent.Africa },
            };


            CountryListView cv = new CountryListView(countrydb);
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
            cv.Display();

            int selection = int.Parse(Console.ReadLine());

            for (int i = 0; i < countrydb.Count; i++)
            {
                if ((selection-1) == i)
                {
                    CountryAction(countrydb[i]);
                }
            }

        }
    }
}
