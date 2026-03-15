using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalletApi.Entities;
// using TechTreeWebApp.Entities;

namespace WalletApi.Data
{
    public class ApplicationUser : IdentityUser<Guid>
    {
    public string? GoogleId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Picture { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Transaction> Transactions {get; set;}
        public DbSet<Wallet> Wallets {get; set;}
    }
}