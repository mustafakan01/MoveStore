using System;

namespace WebApi
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Date { get; set; }

        public int GenreId { get; set; } 

        public string Director { get; set; }

        public string Artist { get; set; }

        public decimal Price { get; set; }
    } 
    
}