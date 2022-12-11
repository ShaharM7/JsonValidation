using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Tests.Data.JsonFilesPath;
using static CYeAutomation.Loading.LoadingFiles;

namespace CYeAutomation.Tests
{
    public class FamiliesTests : BaseTest
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