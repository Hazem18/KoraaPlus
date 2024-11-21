﻿using KoraaPlus.Models;
using Microsoft.EntityFrameworkCore;

namespace KoraaPlus.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
        public DbSet<Match> Matches { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketCategory> TicketCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Match>()
                    .HasOne(m => m.TeamA)
                    .WithMany()
                    .HasForeignKey(m => m.TeamAId)
                    .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Match>()
                    .HasOne(m => m.TeamB)
                    .WithMany()
                    .HasForeignKey(m => m.TeamBId)
                    .OnDelete(DeleteBehavior.Restrict);

             modelBuilder.Entity<Ticket>()
               .HasIndex(t => new { t.SeatNumber, t.MatchId })
               .IsUnique();

            modelBuilder.Entity<TicketCategory>()
               .Property(t => t.Price)
               .HasColumnType("decimal(10,2)");
        }
    }
}
