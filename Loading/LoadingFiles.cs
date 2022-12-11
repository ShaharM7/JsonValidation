using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace CYeAutomation.Loading
{
    public static class LoadingFiles
    {
        public static JObject LoadingJsonAsJobject(string jsonPath)
        {
            return (JObject) JToken.ReadFrom(new JsonTextReader(File.OpenText(jsonPath)));
        }

        public static JSchema LoadingJsonAsJSchema(string jsonPath)
        {
            return JSchema.Load(new JsonTextReader(File.OpenText(jsonPath)));
        }
    }
}