namespace EffortIssue40
{
    using System.Data.Common;
    using System.Data.Entity;

    using EffortIssue40.Configurations;
    using EffortIssue40.DataModels;

    public class OberonContext : DbContext
    {
        public OberonContext(DbConnection connection) : base(connection, true)
        {
            Database.SetInitializer<OberonContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<decimal>().Configure(p => p.HasPrecision(38, 10));

            modelBuilder.ConfigureClient();

            modelBuilder.ConfigureDeal();

            modelBuilder.ConfigureDebt();

            modelBuilder.Entity<Info3DataModel>()
                .ToTable("client.Product")
                .HasKey(x => x.ProductId);

            modelBuilder.Entity<UserDataModel>()
                .ToTable("user.OberonUser")
                .HasKey(x => x.UserId);
        }
        
        public DbSet<DraftDataModel> Drafts { get; set; }
        public DbSet<DealDataModel> Deals { get; set; }
        public DbSet<OutputDetailDataModel> OutputDetails { get; set; }
        public DbSet<DetailDataModel> LoanDetail { get; set; }
        public DbSet<CapitalDataModel> Capital { get; set; }
        public DbSet<SwapDataModel> InterestRateSwap { get; set; }
        public DbSet<CustomisationPeriodInputDataModel> CustomisationPeriod { get; set; }
        public DbSet<CustomisationOptionsDataModel> CustomisationOption { get; set; }
        public DbSet<LeftSwapDataModel> InterestRateSwapReceiveLeg { get; set; }
        public DbSet<RightSwapDataModel> InterestRateSwapPayLeg { get; set; }
        public DbSet<DetailOutputDataModel> LoanOutput { get; set; }
        public DbSet<Detail2OutputDataModel> AncillaryOutput { get; set; }
        public DbSet<Detail2DataModel> Ancillary { get; set; }
        public DbSet<Info3DataModel> Products { get; set; }
        public DbSet<RatingsDataModel> Ratings { get; set; }
        public DbSet<UserDataModel> Users { get; set; }
        
    }

}

