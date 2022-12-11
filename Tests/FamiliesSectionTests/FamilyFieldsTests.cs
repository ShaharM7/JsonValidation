using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Tests.Data.JsonFilesPath;
using static CYeAutomation.Loading.LoadingFiles;

namespace CYeAutomation.Tests.FamiliesSectionTests
{
    public class FamilyFieldsTests : BaseTest
    {
        // Incorrect fields
        // Digit id
        [Test]
        public void WhenIncorrectFamilyQuantityDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyQuantityDigitIdPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectDigitIdNotStartWithExpectedPrefix_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyDigitIdNotStartWithExpectedPrefixPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyDigitIdNotContainsHyphen_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyDigitIdNotContainsHyphenPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyDigitIdContainsLetters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyDigitIdContainsLettersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyDigitIdContainsCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyDigitIdContainsCharactersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Surname
        [Test]
        public void WhenIncorrectFamilySurnameContainsNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilySurnameContainsNumbersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilySurnameContainsCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilySurnameContainsCharactersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Parents list
        [Test]
        public void WhenIncorrectFamilyParentsNoContainsParents_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyParentsNoContainsParentsPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyParentsContainsNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyParentsContainsNumbersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyParentsContainsCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyParentsContainsCharactersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}