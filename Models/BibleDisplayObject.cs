using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bible_Application.Models
{
    public class BibleDisplayObject
    {
        public string Testament { get; set; }

        [Required]
        public string Book { get; set; }

        [Required]
        [Range(0,1000)]
        public int Chapter { get; set; }

        [Required]
        [Range(0, 1000)]
        public int Verse { get; set; }

        [DisplayName("Text")]
        public string VerseText { get; set; }
    }
}