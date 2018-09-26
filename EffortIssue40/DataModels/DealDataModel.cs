namespace EffortIssue40.DataModels
{
    using System.Collections.Generic;

    public class DealDataModel
    {
        public int DealId { get; set; }
        public virtual ICollection<DetailDataModel> Details { get; set; }
        public virtual ICollection<Detail2DataModel> Details2 { get; set; }
        public virtual OutputDetailDataModel OutputDetail { get; set; }
    }
}
