namespace EffortIssue40.Configurations
{
    using System.Data.Entity;

    using EffortIssue40.DataModels;

    public static class ClientModelBuilderExtensions
    {
        public static void ConfigureClient(this DbModelBuilder builder)
        {
            builder.Configurations.Add(new DraftConfiguration());
            builder.Configurations.Add(new InformationConfiguration());
            builder.Configurations.Add(new Info1Configuration());
            builder.Entity<RatingsDataModel>()
                .ToTable("client.Ratings")
                .HasKey(x => x.RatingsId);

        }
    }
}
