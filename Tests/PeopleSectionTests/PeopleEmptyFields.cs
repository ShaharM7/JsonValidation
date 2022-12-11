using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests.PeopleSectionTests
{
    public class PeopleEmptyFields : BaseTest
    {
        [Test]
        public void WhenPersonNameEmpty_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(PersonNameEmptyPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonSurnameEmpty_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(PersonSurnameEmptyPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonAgeEmpty_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(PersonAgeEmptyPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonFamilyMemberEmpty_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(PersonFamilyMemberEmptyPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}