using System.Data.Entity.ModelConfiguration;
using EffortIssue40.DataModels;

namespace EffortIssue40.Configurations
{
    public class OutputDetailConfiguration : EntityTypeConfiguration<OutputDetailDataModel>
    {
        public OutputDetailConfiguration()
        {
            this.ToTable("deal.OutputDetail");

            this.HasKey(x => x.OutputDetailId);            
        }
    }
}
