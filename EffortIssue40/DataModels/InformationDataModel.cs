namespace EffortIssue40.DataModels
{
    using System.Collections.Generic;

    public class InformationDataModel
    {
        public int InformationId { get; set; }
        public virtual ICollection<Info3DataModel> Info3DataModels { get; set; }
        public Info1DataModel Info1Data { get; set; }
    }
}
