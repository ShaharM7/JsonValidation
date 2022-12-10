using CYeAutomation.Tests.Data;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingJsons;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests
{
    public class PersonTests : BaseTest
    {
        // Sanity
        [Test]
        public void WhenAllFieldsAreCorrects_AndFitTheRules_ThenTheJsonIsValid()
        {
            var jsonValue = LoadingJsonAsJobject(JsonValidValuesPath);
            Assert.IsTrue(jsonValue.IsValid(JsonSchema!));
        }

        // Missing person fields
        [Test]
        public void WhenPersonDigitIdIsMissing_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonDigitIdPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonNameIsMissing_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonNamePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonSurnameIsMissing_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonSurnamePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonAgeIsMissing_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonAgePath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenFamilyMemberIsMissing_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(MissingPersonFamilyMember);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        // Incorrect fields
        // Person digit id
        [Test]
        public void WhenIncorrectPersonQuantityDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonQuantityDigitId);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonLettersInDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonLettersInDigitId);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonCharactersInDigitId_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonCharactersInDigitId);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
        
        // Person name
        [Test]
        public void WhenIncorrectPersonNameWithNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonNameWithNumbers);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonNameWithCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonNameWithCharacters);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
        
        // Person surname
        [Test]
        public void WhenIncorrectPersonSurnameWithNumbers_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonSurnameWithNumbers);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonSurnameWithCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonSurnameWithCharacters);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
        
        // Person age
        [Test]
        public void WhenIncorrectPersonAgeWithLetters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonAgeWithLetters);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonAgeWithCharacters_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonAgeWithCharacters);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
        
        // Family member
        [Test]
        public void WhenIncorrectPersonFamilyMemberWithNumber_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonFamilyMemberWithNumber);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonFamilyMemberWithCharacter_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonFamilyMemberWithCharacter);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenIncorrectPersonFamilyMemberCanNotBe_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IncorrectPersonFamilyMemberCanNotBe);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
        
    }
}