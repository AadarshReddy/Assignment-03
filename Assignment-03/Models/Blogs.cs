using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_03.Models
{
    [Table("Blog")]
    public class Blogs
    {
        [Key]
        public int BId { get; set; }
        public string BTitle { get; set; }
        public int BContent { get; set; }

        public DateTime PDate { get; set; }
        public string BAuthor { get; set; }
    }
}