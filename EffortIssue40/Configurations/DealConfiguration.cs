namespace EffortIssue40.Configurations
{
    using System.Data.Entity.ModelConfiguration;

    using EffortIssue40.DataModels;

    internal class DealConfiguration : EntityTypeConfiguration<DealDataModel>
    {
        public DealConfiguration()
        {
            this.HasKey(x => x.DealId);

            this.ToTable("deal.Deal")
                .HasMany(x => x.Details)
                .WithRequired()
                .Map(x => x.MapKey(nameof(DealDataModel.DealId)))
                .WillCascadeOnDelete(true);

            this.HasMany(x => x.Details2)
                .WithRequired()
                .Map(x => x.MapKey(nameof(DealDataModel.DealId)));

            this.HasOptional(d => d.OutputDetail)
                .WithRequired()
                .Map(x => x.MapKey(nameof(DealDataModel.DealId)));
        }
    }
}