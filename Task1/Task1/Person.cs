using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Person : IPerson
    {
        public string Name { get; set; }
        public int Year { get; set; } //rok urrodzenia
        public int GetAge(int Year)
        {
            DateTime n = DateTime.Now; //aktualny rok
            int Age = n.Year - Year;

            return Age; //zwraca wiek
        }
    }
}