using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingJsons;

namespace CYeAutomation.Tests
{
    public class FamiliesTests : BaseTest
    {
        // Missing section 
        [Test]
        public void WhenJsonHasNotHaveFamiliesSection_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject("");
            var isValid = jsonValue.IsValid(JsonSchema!, out IList<ValidationError> errors);
            Assert.IsFalse(isValid, errors[0].Message);
        }

        [Test]
        public void WhenJsonHasNotHavePeopleSection_ThenTheJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject("");
            var isValid = jsonValue.IsValid(JsonSchema!, out IList<ValidationError> errors);
            Assert.IsFalse(isValid, errors[0].Message);
        }
    }
}