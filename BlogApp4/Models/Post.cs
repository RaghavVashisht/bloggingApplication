using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp4.Models
{
    public class Post
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Body")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }
    }
}