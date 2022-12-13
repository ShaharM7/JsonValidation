using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests.PeopleSectionTests
{
    public class PeopleCauseAndEffectTests : BaseTest
    {
        [Test]
        public void WhenFamilyMemberIsKidSoHisMaximumAgeIsSeventeen_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(FamilyMemberKidAgeGreaterThanMaximumAgePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonAgeIsGraterThenEighteenHisFamilyMemberIsParent_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(FamilyMemberParentAgeLessThanMinimumAgePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}