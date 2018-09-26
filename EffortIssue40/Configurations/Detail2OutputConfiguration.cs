namespace EffortIssue40.Configurations
{
    using System.Data.Entity.ModelConfiguration;

    using EffortIssue40.DataModels;

    public class Detail2OutputConfiguration: EntityTypeConfiguration<Detail2OutputDataModel>
    {
        public Detail2OutputConfiguration()
        {
            this.HasKey(ao => ao.Detail2OutputId);

            this.ToTable("deal.Detail2OutputDetail");
        }
    }
}
