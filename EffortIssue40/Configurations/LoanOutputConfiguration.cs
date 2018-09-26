using System.Data.Entity.ModelConfiguration;
using EffortIssue40.DataModels;

namespace EffortIssue40.Configurations
{
    public class LoanOutputConfiguration: EntityTypeConfiguration<DetailOutputDataModel>
    {
        public LoanOutputConfiguration()
        {
            this.HasKey(lo => lo.DetailOutputId);

            this.ToTable("LoanOutputDetail", Schemas.Debt);

            this.HasMany(x => x.PeriodOutputs)
                .WithRequired()
                .Map(x => x.MapKey(nameof(DetailOutputDataModel.DetailOutputId)));
        }
    }
}
