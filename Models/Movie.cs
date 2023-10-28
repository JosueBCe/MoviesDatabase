using Microsoft.EntityFrameworkCore.Migrations;
using MoviesDatabase.Migrations;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace MoviesDatabase.Models
    
{
    public class Scriptured
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Scripture { get; set; }

        [Display(Name = "Creation Date")]
        [DataType(DataType.Date)]
        public DateTime CreationDate { get; set; }

        [RegularExpression(@"^[A-Z0-9]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]

        public string? Book { get; set; }

        //[Column(TypeName = "decimal(18, 2)")]
        //[DataType(DataType.Currency)]
        //public decimal Price { get; set; }



        //[RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        //[StringLength(5)]
        //[Required]
        //public string? Rating { get; set; }
    }
}


//Add - Migration InitialCreate
//Update-Database