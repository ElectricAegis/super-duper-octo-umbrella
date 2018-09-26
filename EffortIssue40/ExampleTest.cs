using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

using EffortIssue40.DataModels;

using NUnit.Framework;

namespace EffortIssue40
{
    [TestFixture]
    public class ExampleTest
    {
        private OberonContext oberonContext;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var effortConnection = Effort.DbConnectionFactory.CreateTransient();
            var context = new OberonContext(effortConnection);
            context.Database.CreateIfNotExists();

            this.oberonContext = context;
        }

        [Test]
        public void WithOutIncludes()
        {
            this.AddDraftToContext();

            var firstResult = this.oberonContext.Drafts.Include(m => m.Ratings).FirstOrDefault();

            Assert.NotNull(firstResult?.Deal.Details.FirstOrDefault()?.DetailOutput.PeriodOutputs.First());
        }

        [Test]
        public void WithIncludes()
        {
            this.AddDraftToContext();

            var firstResult = this.oberonContext.Drafts.Include(m => m.Ratings)
                .Include(m => m.Information)
                .Include(m => m.Information.Info3DataModels)
                .Include(m => m.Information.Info1Data)
                .Include(m => m.Deal)
                .Include(m => m.Deal.Details2)
                .Include(m => m.Deal.Details2.Select(x => x.Detail2Output))
                .Include(m => m.Deal.Details)
                .Include(m => m.Deal.Details.Select(x => x.Capital))
                .Include(m => m.Deal.Details.Select(x => x.CustomisationOptions))
                .Include(m => m.Deal.Details.Select(x => x.Customisations))
                .Include(m => m.Deal.Details.Select(x => x.Swap))
                .Include(m => m.Deal.Details.Select(x => x.Swap.RightSwapDataModel))
                .Include(m => m.Deal.Details.Select(x => x.Swap.LeftSwapDataModel))
                .Include(m => m.Deal.Details.Select(x => x.DetailOutput))
                .Include(m => m.Deal.OutputDetail)
                .Include(m => m.DraftUsers).First();

            Assert.NotNull(firstResult?.Deal.Details.FirstOrDefault()?.DetailOutput.PeriodOutputs.First());
        }

        private void AddDraftToContext()
        {
            this.oberonContext.Drafts.Add(
                new DraftDataModel
                {
                    Deal = new DealDataModel
                    {
                        Details2 =
                            new List<Detail2DataModel>
                            {
                                new Detail2DataModel { Detail2Output = new Detail2OutputDataModel() }
                            },
                        Details = new List<DetailDataModel>
                        {
                            new DetailDataModel
                            {
                                Capital = new CapitalDataModel(),
                                CustomisationOptions = new CustomisationOptionsDataModel(),
                                Customisations =
                                    new List<CustomisationPeriodInputDataModel>
                                    {
                                        new CustomisationPeriodInputDataModel()
                                    },
                                Swap =
                                    new SwapDataModel
                                    {
                                        RightSwapDataModel = new RightSwapDataModel(),
                                        LeftSwapDataModel = new LeftSwapDataModel()
                                    },
                                DetailOutput = new DetailOutputDataModel
                                {
                                    PeriodOutputs =
                                        new List<DetailPeriodOutputDataModel> { new DetailPeriodOutputDataModel() },
                                }
                            }
                        },
                        OutputDetail = new OutputDetailDataModel()
                    },
                    DraftUsers = new List<UserDataModel> { new UserDataModel() },
                    Information = new InformationDataModel
                    {
                        Info1Data = new Info1DataModel(),
                        Info3DataModels = new List<Info3DataModel> { new Info3DataModel() }
                    },
                    Ratings = new RatingsDataModel()
                });

            this.oberonContext.SaveChanges();
        }
    }
}
