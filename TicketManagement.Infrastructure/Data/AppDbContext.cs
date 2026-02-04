using Domain.Entities;
using Infrastructure.Extensions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Priority> Priorities { get; set; }
    public DbSet<Attachment> Attachments { get; set; }
    public DbSet<Discussion> Discussions { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.SeedData();

        modelBuilder.Entity<Ticket>()
            .HasOne(x => x.User)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);
        
        modelBuilder.Entity<Discussion>()
            .HasOne(x => x.Ticket)
            .WithMany()
            .OnDelete(DeleteBehavior.NoAction);

    }
}