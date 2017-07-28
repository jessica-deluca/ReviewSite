using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string ReviewTitle { get; set; }
        public string ReviewContent { get; set; }
        public DateTime PublishedDate { get; set; }
        public string ReviewAuthor { get; set; }
        public decimal ReviewScore { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}