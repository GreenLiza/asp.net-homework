﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace GoodNewsAggregator.MVC.Models
{
    public class NewsCreateModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string FullText { get; set; }
        //[Required]
        //public string SourceName { get; set; }
        //public List<SelectListItem>? AvailableSources { get; set; }
    }
}
