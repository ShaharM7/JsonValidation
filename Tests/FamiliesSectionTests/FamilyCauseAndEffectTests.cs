using Newtonsoft.Json.Schema;
using NUnit.Framework;
using static CYeAutomation.Tests.Data.JsonFilesPath;
using static CYeAutomation.Loading.LoadingFiles;

namespace CYeAutomation.Tests.FamiliesSectionTests
{
    public class FamilyCauseAndEffectTests : BaseTest
    {
        [Test]
        public void WhenFamilyKidsNumberNoZero_AndKidsListIsEmpty_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IfFamilyKidsNumberIsZeroThenKidsListIsEmptyPath);
            
            var isValid = jsonValue.IsValid(JsonSchema!);
            Assert.IsFalse(isValid);
        }

        [Test]
        public void WhenKidsListEmpty_AndNumberOfTheFamilyKidsNumZero_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(IfKidsListIsEmptyThenTheNumberOfTheFamilyKidsNumIsZeroPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenEachPersonNotBelongToFamily_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(EachPersonMustBelongToFamilyPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenEachFamilyMemberNotExistAsPerson_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(EachFamilyMemberMustExistAsPersonPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }
    }
}