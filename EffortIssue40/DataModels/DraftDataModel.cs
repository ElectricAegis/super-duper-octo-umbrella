namespace EffortIssue40.DataModels
{
    using System.Collections.Generic;

    public class DraftDataModel
    {
        public int DraftId { get; set; }
        public virtual RatingsDataModel Ratings { get; set; }
        public virtual InformationDataModel Information { get; set; }
        public virtual ICollection<UserDataModel> DraftUsers { get; set; }
        public virtual DealDataModel Deal { get; set; }
    }
}
