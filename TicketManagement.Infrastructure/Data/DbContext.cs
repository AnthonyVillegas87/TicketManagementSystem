using Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DbContext : IdentityDbContext<User>
{
    public DbContext(DbContextOptions<IdentityDbContext> options) : base(options)
    {
        
    }
}