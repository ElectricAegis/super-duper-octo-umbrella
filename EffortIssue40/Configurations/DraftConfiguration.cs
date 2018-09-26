namespace EffortIssue40.Configurations
{
    using System.Data.Entity.ModelConfiguration;

    using EffortIssue40.DataModels;

    public class DraftConfiguration : EntityTypeConfiguration<DraftDataModel>
    {
        public DraftConfiguration()
        {
            this.HasKey(x => x.DraftId);
            this.ToTable("client.Draft");
            this.HasRequired(x => x.Information)
                .WithRequiredPrincipal()
                .Map(x => x.MapKey(nameof(DraftDataModel.DraftId)));
            this.HasRequired(x => x.Ratings)
                .WithRequiredPrincipal()
                .Map(x => x.MapKey(nameof(DraftDataModel.DraftId)));
            this.HasOptional(x => x.Deal)
                .WithRequired()
                .Map(x => x.MapKey(nameof(DraftDataModel.DraftId)));

            this.HasMany(x => x.DraftUsers)
                .WithMany()
                .Map(cs =>
                {
                    cs.MapLeftKey(nameof(DraftDataModel.DraftId));
                    cs.MapRightKey(nameof(UserDataModel.UserId));
                    cs.ToTable("DraftUser", "client");
                });
        }
    }
}
