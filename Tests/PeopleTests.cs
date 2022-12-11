using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests
{
    public class PeopleTests : BaseTest
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
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
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