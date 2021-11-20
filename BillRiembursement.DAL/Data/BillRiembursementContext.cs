using BillRiembursement.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillRiembursement.DAL.Data
{
    public class BillRiembursementContext : DbContext
    {
        public BillRiembursementContext(DbContextOptions<BillRiembursementContext> options) : base(options) { }

        public DbSet<BillRiembursementModel> BillRiembursementModels { get; set; }
    }
}
