using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie_Database
{
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public static int count = 0;
        //Constructor
        public Movie(string _title, string _category)
        {
            Title = _title;
            Category = _category;
            
        }
        public Movie()
        { 
            Title = string.Empty;
            Category = string.Empty;
        }

        //Method
        public string GetDetails()
        {

            return String.Format("{0,-25} {1, -25}", $"{Title}", $"{Category}");


        }
        public static int GetCount()
        {
            return count;
        }
    }
}
