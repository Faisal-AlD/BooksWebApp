using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksWebApp.Models
{
    public class Book
    {
        // Properties 
        public int Id { get; set; }   
        public string Books { get; set; }

        public string Summaries { get; set; }

        public Book() //Constructor 
        {
                
        }
    }
}
