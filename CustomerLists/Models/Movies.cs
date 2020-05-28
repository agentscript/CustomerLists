using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace CustomerLists.Models
{
    public class Movies
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public String MovieName { get; set; }

        [Required]
        public String Synopsis { get; set; }

        [Required]
        public string Rating { get; set; }

        
        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int GenreId{ get; set; }


        [Required]
        [Display(Name = "Date of Release")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d/mmm/yyyy}")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d/mmm/yyyy}")]
        public DateTime DateAdded { get; set; }

        [Required]
        public byte InStock { get; set; }


    }

    
}