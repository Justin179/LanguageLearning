using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VocabExpander.Models
{
    public class Vocab
    {
        [Key]
        public int id { get; set; }
        public string word { get; set; }

    }
}