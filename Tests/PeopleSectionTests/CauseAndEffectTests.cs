using System;
using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests.PeopleSectionTests
{
    public class CauseAndEffectTests : BaseTest
    {

        [Test]
        public void IfFamilyMemberIsKidSoHisMaximumAgeIsSeventeen_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IfFamilyMemberIsKidSoHisMaximumAgeIsSeventeen);

            var isValid = jsonValue.IsValid(JsonSchema!, out IList<ValidationError> meErrors);
            Console.WriteLine(meErrors[0].Message);
            Assert.IsFalse(isValid);
        }
        
    }
}