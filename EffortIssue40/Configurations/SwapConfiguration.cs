using System.Data.Entity.ModelConfiguration;
using EffortIssue40.DataModels;

namespace EffortIssue40.Configurations
{
    public class SwapConfiguration : EntityTypeConfiguration<SwapDataModel>
    {
        public SwapConfiguration()
        {
            this.HasKey(x => x.SwapId);

            this.ToTable("Swap", Schemas.Debt);

            this.HasOptional(x => x.RightSwapDataModel)
                .WithOptionalPrincipal()
                .Map(x => x.MapKey(nameof(SwapDataModel.SwapId)))
                .WillCascadeOnDelete(true);

            this.HasOptional(x => x.LeftSwapDataModel)
                .WithOptionalPrincipal()
                .Map(x => x.MapKey(nameof(SwapDataModel.SwapId)))
                .WillCascadeOnDelete(true);
        }
    }
}