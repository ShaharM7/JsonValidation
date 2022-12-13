using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Tests.Data.JsonFilesPath;
using static CYeAutomation.Loading.LoadingFiles;

namespace CYeAutomation.Tests.FamiliesSectionTests
{
    public class FamilyMissingFieldsTests : BaseTest
    {
        // Missing Families section 
        [Test]
        public void WhenJsonHasNotHaveFamiliesSection_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingFamiliesSectionPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Missing fields
        [Test]
        public void WhenMissingFamilyDigitNumber_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingFamilyDigitNumberPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingFamilySurname_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingFamilySurnamePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingFamilyParentsList_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingFamilyParentsListPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingMissingFamilyKidsNamesList_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingFamilyKidsNamesListPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingFamilyKidsNumber_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingKidsNumberPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}