
using BeCoreApp.Data.Entities;
using Core.Data.EF.Configurations;
using Core.Data.EF.Extensions;
using Core.Data.Entities;
using Core.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace Core.Data.EF
{
    public class AppDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Language> Languages { set; get; }
        public DbSet<Function> Functions { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<MenuGroup> MenuGroups { set; get; }
        public DbSet<MenuItem> MenuItems { set; get; }
        public DbSet<BlogCategory> BlogCategories { set; get; }
        public DbSet<Blog> Blogs { set; get; }
        public DbSet<BlogTag> BlogTags { set; get; }
        public DbSet<Feedback> Feedbacks { set; get; }
        public DbSet<Tag> Tags { set; get; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<TicketTransaction> TicketTransactions { get; set; }
        public DbSet<Staking> Stakings { get; set; }
        public DbSet<StakingReward> StakingRewards { get; set; }
        public DbSet<StakingAffiliate> StakingAffiliates { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<Notify> Notifies { get; set; }
        public DbSet<WalletTransfer> WalletTransfers { get; set; }
        public DbSet<SystemTransaction> SystemTransactions { get; set; }
        public DbSet<Config> Configs { get; set; }
        public DbSet<InvestBotConfig> InvestBotConfigs { get; set; }
        public DbSet<InvestProfitHistory> InvestProfitHistories { get; set; }
        public DbSet<Airdrop> Airdrops { get; set; }

        public DbSet<DefiTransaction> DefiTransactions { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.AddConfiguration(new TagConfiguration());
            builder.AddConfiguration(new BlogTagConfiguration());
            builder.AddConfiguration(new FunctionConfiguration());
            builder.AddConfiguration(new BlogConfiguration());
            builder.AddConfiguration(new BlogCategoryConfiguration());
        }

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);

            foreach (EntityEntry item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem != null)
                {
                    if (item.State == EntityState.Added)
                        changedOrAddedItem.DateCreated = DateTime.UtcNow;

                    changedOrAddedItem.DateModified = DateTime.UtcNow;
                }
            }

            return base.SaveChanges();
        }
    }

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())

            var builder = new DbContextOptionsBuilder<AppDbContext>();
            builder.UseSqlServer(connectionString);

            return new AppDbContext(builder.Options);
        }
    }
}
