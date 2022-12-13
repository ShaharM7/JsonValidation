using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests.PeopleSectionTests
{
    public class PeopleMissingFieldsTests : BaseTest
    {
        // Missing Person section
        [Test]
        public void WhenJsonHasNotHavePeopleSection_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonSectionPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Missing person fields
        [Test]
        public void WhenMissingPersonDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonDigitIdPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingPersonName_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonNamePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingPersonSurname_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonSurnamePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingPersonAge_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonAgePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenMissingPersonFamilyMember_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonFamilyMemberPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}