using System.Collections.Generic;

namespace EffortIssue40.DataModels
{
    public class DetailDataModel
    {
        public string DealName { get; set; }
        public int DetailId { get; set; }

        public virtual CapitalDataModel Capital { get; set; }
        public virtual SwapDataModel Swap { get; set; }
        public virtual CustomisationOptionsDataModel CustomisationOptions { get; set; }
        public virtual ICollection<CustomisationPeriodInputDataModel> Customisations { get; set; }

        public virtual DetailOutputDataModel DetailOutput { get; set; }
    }
}