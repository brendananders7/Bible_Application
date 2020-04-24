using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bible_Application.Models
{
    public class BibleDataObject
    {
        public int BookSelection { get; set; }
        public int ChapterNumber { get; set; }
        public int VerseNumber { get; set; }
        public string VerseText { get; set; }
    }
}