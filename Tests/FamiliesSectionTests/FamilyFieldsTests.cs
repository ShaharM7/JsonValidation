using System.Collections.Generic;
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
            var isValid = jsonValue.IsValid(JsonSchema!, out IList<ValidationError> _);
            Assert.IsTrue(isValid);
        }

        // Parents list
        [Test]
        public void WhenIncorrectFamilyParentsContainsNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyParentsContainsNumbersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyParentsContainsCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyParentsNoContainsParentsPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Kids list
        [Test]
        public void WhenIncorrectFamilyKidsNamesContainsNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyKidsNamesContainsNumbersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyKidsNamesContainsCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyKidsNamesContainsCharactersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Kids number
        [Test]
        public void WhenIncorrectFamilyKidsNumbersContainsLetters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyKidsNumbersContainsLettersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyKidsNumbersContainsCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyKidsNumbersContainsCharactersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectFamilyKidsNumbersContainsNegativeNumberPath__ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectFamilyKidsNumbersContainsNegativeNumberPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}