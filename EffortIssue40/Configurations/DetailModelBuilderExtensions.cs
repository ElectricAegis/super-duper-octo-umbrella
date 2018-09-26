using System.Data.Entity;

using EffortIssue40.DataModels;

namespace EffortIssue40.Configurations
{
    public static class DetailModelBuilderExtensions
    {
        public static void ConfigureDebt(this DbModelBuilder builder)
        {
            builder.Configurations.Add(new DetailConfiguration());
            builder.Configurations.Add(new SwapConfiguration());
            builder.Configurations.Add(new LoanOutputConfiguration());

            builder.Entity<CapitalDataModel>()
                .ToTable("Capital", Schemas.Debt)
                .HasKey(x => x.CapitalId);

            builder.Entity<CustomisationOptionsDataModel>()
                .ToTable("CustomisationOptions", Schemas.Debt)
                .HasKey(x => x.CustomisationOptionsId);

            builder.Entity<CustomisationPeriodInputDataModel>()
                .ToTable("CustomisationPeriod", Schemas.Debt)
                .HasKey(x => x.CustomisationPeriodId);

            builder.Entity<LeftSwapDataModel>()
                .ToTable("InterestRateSwapReceiveLeg", Schemas.Debt)
                .HasKey(x => x.LeftSwapId);

            builder.Entity<RightSwapDataModel>()
                .ToTable("InterestRateSwapPayLeg", Schemas.Debt)
                .HasKey(x => x.RightSwapId);

            builder.Entity<DetailPeriodOutputDataModel>()
                .ToTable("LoanPeriodOutput", Schemas.Debt)
                .HasKey(x => x.DetailPeriodOutputId);

        }
    }
}
