using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using learn.Models;

namespace learn.Data
{
    public class learnContext : DbContext
    {
        public learnContext(DbContextOptions<learnContext> options)
            : base(options)
        {
        }

        public DbSet<learn.Models.user>? user { get; set; } = default!;
        public DbSet<learn.Models.never>? never { get; set; }
        public DbSet<learn.Models.v_nbt_sms2>? v_nbt_sms2 { get; set; }
        public DbSet<learn.Models.v_nbt_sms1>? v_nbt_sms1 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<v_nbt_sms3>()
            //.ToView(nameof(v_nbt_sms2))
            //.HasNoKey();

           // modelBuilder.Entity<v_nbt_sms2>()
           //.ToView(nameof(v_nbt_sms2))
           //.HasNoKey();

        }

    }
}
