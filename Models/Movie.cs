using System;
using System.ComponentModel.DataAnnotations;

public class Movie
{
        public int ID { get; set; }   //Primary key
        public string Title { get; set; }

        [DataType(DataType.Date)] // Specify the type of data 
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
}