using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Tests.Data.JsonFilesPath;
using static CYeAutomation.Loading.LoadingFiles;

namespace CYeAutomation.Tests.FamiliesSectionTests
{
    public class FamilyEmptyFieldsTests : BaseTest
    {
        [Test]
        public void WhenFamilySurnameFieldEmpty_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(FamilySurnameFieldEmptyPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
        
        [Test]
        public void WhenFamilyParentsFieldEmpty_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(FamilyParentsFieldEmptyPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}