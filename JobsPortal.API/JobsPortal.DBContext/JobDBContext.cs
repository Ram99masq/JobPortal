using JobsPortal.DBContext.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobsPortal.DBContext
{
    public class JobDBContext : DbContext
    {
        public JobDBContext(DbContextOptions<JobDBContext> options)
        : base(options)
        {
                       
        }
        public DbSet<JobPosting> JobPostings { get; set; }

        private IDbContextTransaction _transaction;

        public void BeginTransaction()
        {
            _transaction = Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                SaveChanges();
                _transaction.Commit();
            }
            finally
            {
                _transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
    }
}
