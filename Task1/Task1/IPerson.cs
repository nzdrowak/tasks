using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    interface IPerson
    {
        string Name { get; set; }
        int Year { get; set; }
        int GetAge(int Year); 
    }
}