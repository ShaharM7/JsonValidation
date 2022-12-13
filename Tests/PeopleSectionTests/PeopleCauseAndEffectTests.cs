using System;
using System.Collections.Generic;
using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Loading.LoadingFiles;
using static CYeAutomation.Tests.Data.JsonFilesPath;

namespace CYeAutomation.Tests.PeopleSectionTests
{
    public class PeopleCauseAndEffectTests : BaseTest
    {

        [Test]
        public void WhenFamilyMemberIsKidSoHisMaximumAgeIsSeventeen_ElseJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IfFamilyMemberIsKidSoHisMaximumAgeIsSeventeenPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonAgeIsGraterThenEighteenHisFamilyMemberIsParent_ElseJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IfPersonAgeIsGraterThenEighteenHisFamilyMemberIsParentPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
        
    }
}