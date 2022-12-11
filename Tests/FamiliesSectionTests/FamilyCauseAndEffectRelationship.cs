using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Tests.Data.JsonFilesPath;
using static CYeAutomation.Loading.LoadingFiles;

namespace CYeAutomation.Tests.FamiliesSectionTests
{
    public class FamilyCauseAndEffectRelationship : BaseTest
    {
        // Cause and effect
        public void WhenKidsListIsEmpty_ThenKidsNumIsEqualToZero()
        {
            var jsonValue = LoadingJsonAsJobject(KidsListIsEmptyThenKidsNumIsEqualToZeroPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}