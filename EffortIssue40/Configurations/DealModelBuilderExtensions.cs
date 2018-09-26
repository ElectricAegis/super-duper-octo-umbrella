namespace EffortIssue40.Configurations
{
    using System.Data.Entity;

    using EffortIssue40.DataModels;

    public static class DealModelBuilderExtensions
    {
        public static void ConfigureDeal(this DbModelBuilder builder)
        {

            builder.Entity<Detail2DataModel>()
                .ToTable("deal.Ancillary")
                .HasKey(x => x.Detail2Id)
                .HasOptional(x => x.Detail2Output)
                .WithRequired()
                .Map(x => x.MapKey("AncillaryInputId"))
                .WillCascadeOnDelete(true);

            builder.Configurations.Add(new DealConfiguration());
            builder.Configurations.Add(new OutputDetailConfiguration());
            builder.Configurations.Add(new Detail2OutputConfiguration());
        }
    }
}
