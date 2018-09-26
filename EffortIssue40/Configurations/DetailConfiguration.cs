using System.Data.Entity.ModelConfiguration;
using EffortIssue40.DataModels;

namespace EffortIssue40.Configurations
{
    public class DetailConfiguration : EntityTypeConfiguration<DetailDataModel>
    {
        public DetailConfiguration()
        {
            this.HasKey(x => x.DetailId);

            this.ToTable("Detail", Schemas.Debt)
                .HasOptional(x => x.Capital)
                .WithOptionalPrincipal()
                .Map(x => x.MapKey(nameof(DetailDataModel.DetailId)))
                .WillCascadeOnDelete(true);

            this.HasOptional(x => x.CustomisationOptions)
                .WithOptionalPrincipal()
                .Map(x => x.MapKey(nameof(DetailDataModel.DetailId)))
                .WillCascadeOnDelete(true);

            this.HasMany(x => x.Customisations)
                .WithOptional()
                .Map(x => x.MapKey(nameof(DetailDataModel.DetailId)))
                .WillCascadeOnDelete(true);

            this.HasOptional(x => x.Swap)
                .WithOptionalPrincipal()
                .Map(x => x.MapKey(nameof(DetailDataModel.DetailId)))
                .WillCascadeOnDelete(true);

            this.HasOptional(x => x.DetailOutput)
                .WithRequired()
                .Map(x => x.MapKey("LoanInputId"))
                .WillCascadeOnDelete(true);


            this.Ignore(x => x.DealName);
        }
    }
}