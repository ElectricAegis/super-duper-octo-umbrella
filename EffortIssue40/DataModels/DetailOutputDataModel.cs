namespace EffortIssue40.DataModels
{
    using System.Collections.Generic;

    public class DetailOutputDataModel
    {
        public int DetailOutputId { get; set; }
        public virtual ICollection<DetailPeriodOutputDataModel> PeriodOutputs { get; set; }
    }
}
