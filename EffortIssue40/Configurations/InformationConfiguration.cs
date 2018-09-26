using System.Data.Entity.ModelConfiguration;

using EffortIssue40.DataModels;

namespace EffortIssue40.Configurations
{
    public class InformationConfiguration : 
        EntityTypeConfiguration<InformationDataModel>
    {
        public InformationConfiguration()
        {
            this.HasKey(x => x.InformationId);
            this.ToTable("client.Information")
                .HasMany(x => x.Info3DataModels)
                .WithRequired()
                .Map(x => x.MapKey(nameof(InformationDataModel.InformationId)));
            this.HasOptional(x => x.Info1Data).WithRequired().Map(x => x.MapKey(nameof(InformationDataModel.InformationId)));
        }        
    }
}
