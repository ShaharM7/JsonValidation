using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
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
            var jsonValue = LoadingJsonAsJobject(FamilyKidsNumberZeroAndKidsListNotEmptyPath);

            var isValid = jsonValue.IsValid(JsonSchema!);
            Assert.IsFalse(isValid);
        }

        [Test]
        public void WhenKidsListEmpty_AndNumberOfTheFamilyKidsNumZero_ThenJsonIsInvalid()
        {
            var jsonValue = LoadingJsonAsJobject(FamilyKidsListEmptyAndKidsNumNotZeroPath);
            Assert.IsFalse(jsonValue.IsValid(JsonSchema!));
        }

        [Test]
        public void WhenPersonNameNotPartOfFamilyMember_ThenJsonIsInvalid()
        {
            var familiesStatus = LoadingJsonAsJobject(EachPersonMustBelongToFamilyPath);

            var peopleList = familiesStatus.SelectToken("people") as JArray;
            var people = peopleList!.First! .ToArray();

            var familiesList = familiesStatus.SelectToken("families") as JArray;
            var families = familiesList!.First!.ToArray();


            IList<string> familySurnames = families.Select(family => family.First()
                .SelectToken("surname") as JValue)
                .Select(familySurname => familySurname!.Value!.ToString()!).ToList();

            IList<string> personSurnames = new List<string>();
            foreach (var person in people)
            {
                var personSurname = person.First().SelectToken("surname") as JValue;
                personSurnames.Add(personSurname!.Value!.ToString()!);

                Assert.IsFalse(familySurnames.Except(personSurnames).Any());
            }
        }

        [Test]
        public void WhenPersonNameNotPartOfParents_OrPartOfKids_ThenJsonIsInvalid()
        {
            var familiesStatus = LoadingJsonAsJobject(EachFamilyMemberMustExistAsPersonPath);
            
            var peopleList = familiesStatus.SelectToken("people") as JArray;
            var people = peopleList!.First!.ToArray();
            
            var familiesList = familiesStatus.SelectToken("families") as JArray;
            var families = familiesList!.First!.ToArray();


            IList<string> personNames = people.Select(person => person.First()
                    .SelectToken("surname") as JValue)
                .Select(personName => personName!.Value!.ToString()!).ToList();

            foreach (var family in families)
            {
                var familyParentsList = family.First().SelectToken("parents") as JArray;
                var familyKidsList = family.First().SelectToken("kids") as JArray;
                
                foreach (var personName in personNames)
                {
                    bool isPersonNameInParentList = familyParentsList!.Contains(personName);
                    bool isPersonNameInKidsList = familyKidsList!.Contains(personName);
                    Assert.False(isPersonNameInParentList || isPersonNameInKidsList);
                }
            }
        }
        
        
        
    }
}