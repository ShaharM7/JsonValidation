using System;
using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests
{
    public class BaseTest
    {
        protected JSchema? JsonSchema;

        [SetUp]
        public void LoadJsonJSchema()
        {
            JsonSchema = LoadingJsonAsJSchema(JsonSchemaFilePath);
        }
        
        [Test]
        [Category("Sanity")]
        public void WhenAllFieldsAreCorrects_AndFitTheRules_ThenTheJsonIsValid()
        {
            var jsonValue = LoadingJsonAsJobject(JsonValidValuesPath);

            var isValid = jsonValue.IsValid(JsonSchema!, out IList<ValidationError> _);
            Assert.IsTrue(isValid);
        }
    }
}