using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssetManagement
{
    public class BookInformation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public BookInformation(int id, string Name, string Author, int year)
        {
            this.Id = id;
            this.Name = Name;
            this.Author = Author;
            this.Year = year;
        }

    }

}