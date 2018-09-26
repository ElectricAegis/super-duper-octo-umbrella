namespace EffortIssue40.DataModels
{
    public class SwapDataModel
    {
        public virtual LeftSwapDataModel LeftSwapDataModel { get; set; }
        public virtual RightSwapDataModel RightSwapDataModel { get; set; }
        public int SwapId { get; set; }
    }
}
