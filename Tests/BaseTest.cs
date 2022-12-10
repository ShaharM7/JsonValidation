using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingJsons;
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
    }
}