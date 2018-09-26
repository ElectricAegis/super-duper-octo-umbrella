using System.Data.Entity.ModelConfiguration;

using EffortIssue40.DataModels;

namespace EffortIssue40.Configurations
{
    public class Info1Configuration : 
        EntityTypeConfiguration<Info1DataModel>
    {
        public Info1Configuration()
        {
            this.HasKey(x => x.Info1Id);
            this.ToTable("client.Info1");
        }        
    }
}
