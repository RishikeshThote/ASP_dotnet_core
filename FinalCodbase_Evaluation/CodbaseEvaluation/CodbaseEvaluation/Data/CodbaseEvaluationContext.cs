using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodbaseEvaluation.Model;

namespace CodbaseEvaluation.Data
{
    public class CodbaseEvaluationContext : DbContext
    {
        public CodbaseEvaluationContext (DbContextOptions<CodbaseEvaluationContext> options)
            : base(options)
        {
        }

        public DbSet<CodbaseEvaluation.Model.Employee> Employee { get; set; }
    }
}
