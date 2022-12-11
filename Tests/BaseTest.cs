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
        
        // Sanity - valid
        [Test]
        public void WhenAllFieldsAreCorrects_AndFitTheRules_ThenTheJsonIsValid()
        {
            var jsonValue = LoadingJsonAsJobject(JsonValidValuesPath);
            Assert.IsTrue(jsonValue.IsValid(JsonSchema!));
        }
    }
}