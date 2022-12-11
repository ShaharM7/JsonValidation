using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests.PeopleSectionTests
{
    public class PeopleFieldsTests : BaseTest
    {
        // Incorrect fields
        // Person digit id
        [Test]
        public void WhenIncorrectPersonQuantityDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonQuantityDigitIdPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonLettersInDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonLettersInDigitIdPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonCharactersInDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonCharactersInDigitIdPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Person name
        [Test]
        public void WhenIncorrectPersonNameWithNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonNameWithNumbersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonNameWithCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonNameWithCharactersPath);
            var isValid = jsonValue.IsValid(JsonSchema!, out IList<ValidationError> _);

            Assert.IsTrue(isValid);
        }

        [Test]
        public void WhenIncorrectPersonAgeWithNegativeNumber_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonAgeWithNegativeNumberPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Person surname
        [Test]
        public void WhenIncorrectPersonSurnameWithNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonSurnameWithNumbersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonSurnameWithCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonSurnameWithCharactersPath);

            var isValid = jsonValue.IsValid(JsonSchema!, out IList<ValidationError> _);
            Assert.IsTrue(isValid);
        }

        // Person age
        [Test]
        public void WhenIncorrectPersonAgeWithLetters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonAgeWithLettersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonAgeWithCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonAgeWithCharactersPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Family member
        [Test]
        public void WhenIncorrectPersonFamilyMemberCanNotBe_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonFamilyMemberCanNotBePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}