﻿using CoreTemplate.ViewModels.Base;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreTemplate.ViewModels.Movie
{
    public class MovieViewModel : EntityViewModel
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:%h}h {0:%m}m")]
        public TimeSpan Runtime { get; set; }

        [Url]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }

        [Url]
        [Display(Name = "Trailer URL")]
        public string TrailerUrl { get; set; }

        [Required]
        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        [Display(Name = "Purchase")]
        public decimal PurchaseCost { get; set; }

        [Required]
        [Range(0, 1000)]
        [DataType(DataType.Currency)]
        [Display(Name = "Rent")]
        public decimal RentCost { get; set; }

        public List<CastMemberViewModel> Cast { get; set; }

        public List<CrewMemberViewModel> Crew { get; set; }

        public int CrewCount { get; set; }

        [Display(Name = "Crew")]
        public string CrewTooltip { get; set; }

        [Display(Name = "Genres")]
        public List<int> GenreIds { get; set; }

        public MultiSelectList GenresSelectList { get; set; }

        public int GenresCount { get; set; }

        [Display(Name = "Genres")]
        public string GenresTooltip { get; set; }
    }
}
