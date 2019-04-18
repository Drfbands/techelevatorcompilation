using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GETForms.Web.Models
{
    public class Film
    {
        /// <summary>
        /// The film's title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The film's description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The film's release year.
        /// </summary>
        public int ReleaseYear { get; set; }

        /// <summary>
        /// The film's length.
        /// </summary>
        public int Length { get; set; }

        /// <summary>
        /// The film's rating.
        /// </summary>
        public string Rating { get; set; }

        [Display(Name = "Minimun Length")]
        public int minLength { get; set; }

        [Display(Name = "Maximun Length")]
        public int maxLength { get; set; } = 1000;
        [Display(Name = "Genre")]
        public string genre { get; set; }

        public IList<Film> Results { get; set; }
        public static List<SelectListItem> Genres = new List<SelectListItem>() // Asp pushes it into this list from the view
        {
        new SelectListItem() { Text = "Action"},
        new SelectListItem() { Text = "Animation"},
        new SelectListItem() { Text = "Children"},
        new SelectListItem() { Text = "Classics"},
        new SelectListItem() { Text = "Comedy"},
        new SelectListItem() { Text = "Documentary"},
        new SelectListItem() { Text = "Drama"},
        new SelectListItem() { Text = "Family"},
        new SelectListItem() { Text = "Foreign"},
        new SelectListItem() { Text = "Horror"},
        new SelectListItem() { Text = "Music"},
        new SelectListItem() { Text = "New"},
        new SelectListItem() { Text = "Sci-Fi"},
        new SelectListItem() { Text = "Sports"},
        new SelectListItem() { Text = "Travel"},

        };


    }



}
