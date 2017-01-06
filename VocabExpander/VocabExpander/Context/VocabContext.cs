using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VocabExpander.Models;

namespace VocabExpander.Context
{
    public class VocabContext : DbContext
    {

        public DbSet<Vocab> Vocabs { get; set; }



    }
}