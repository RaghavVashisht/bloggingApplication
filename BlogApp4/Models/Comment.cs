using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogApp4.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public string UserName { get; set; }
        [Required]
        public string Body { get; set; }

        public Post Post { get; set; }
    }
}