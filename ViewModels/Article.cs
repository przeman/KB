using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace KB.ViewModels
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } // No more than 140 chars
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime PublishDate { get; set; }
        public string Body { get; set; }
        public string Authors { get; set; }
        public string KeyWords { get; set; }
        public string Thumbnail { get; set; }
    }
}