using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace GestionDeCV.Models
{
    public class CandidateDBContext : DbContext
    {
        public CandidateDBContext() : base ("DefaultConnectionString")
        {

        }
        public DbSet<CandidateGeneralnfo> dboCandidateGeneralnfo { get; set; }

        
    }
}