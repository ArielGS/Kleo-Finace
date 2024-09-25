using Kleo_Finaces.Models;
using Microsoft.EntityFrameworkCore;

namespace Kleo_Finaces.Data;

public class ModelsDbContext : DbContext
{
    public DbSet<OutcomeCategoryModel> OutcomeCategories { get; set; }
    public DbSet<IncomeCategoryModel> IncomeCategories { get; set; }
    public DbSet<TransferModel> Transfers { get; set; }
    public DbSet<OutcomeModel> Outcomes { get; set; }
    public DbSet<BudgetModel> Budgets { get; set; }
    public DbSet<IncomeModel> Incomes { get; set; }
    public DbSet<SourceModel> Sources { get; set; }
    public DbSet<UserModel> Users { get; set; }

    public ModelsDbContext(DbContextOptions<ModelsDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure TPC for CategoryModel
        modelBuilder.Entity<CategoryBase>().UseTpcMappingStrategy();
        modelBuilder.Entity<IncomeCategoryModel>().ToTable("IncomeCategories");
        modelBuilder.Entity<OutcomeCategoryModel>().ToTable("OutcomeCategories");

        // Configure TPC for ResourceModel
        modelBuilder.Entity<ResourceBase>().UseTpcMappingStrategy();
        modelBuilder.Entity<SourceModel>().ToTable("Sources");
        modelBuilder.Entity<BudgetModel>().ToTable("Budgets");

        // Configure TPC for MovementModel
        modelBuilder.Entity<MovementBase>().UseTpcMappingStrategy();
        modelBuilder.Entity<IncomeModel>().ToTable("Incomes");
        modelBuilder.Entity<OutcomeModel>().ToTable("Outcomes");
        modelBuilder.Entity<TransferModel>().ToTable("Transfers");
    }

}
