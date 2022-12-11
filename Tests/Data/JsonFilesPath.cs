using NUnit.Framework;

namespace CYeAutomation.Tests.Data
{
    public static class JsonFilesPath
    {
        // Base data
        public static string JsonSchemaFilePath = "Tests/Data/jsonSchema.json";
        public static string JsonValidValuesPath = "Tests/Data/jsonValidValues.json";

        // "People section":
        public static string MissingPersonSectionPath = "Tests/Data/People/MissingFields/missingPeopleField.json";
        
        // Missing fields
        public static string MissingPersonDigitIdPath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonDigitId.json";
        public static string MissingPersonNamePath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonName.json";
        public static string MissingPersonSurnamePath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonSurname.json";
        public static string MissingPersonAgePath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonAge.json";
        public static string MissingPersonFamilyMemberPath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonFamilyMember.json";

        // Incorrect fields
        // Digit id
        public static string IncorrectPersonQuantityDigitIdPath = "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonQuantityDigitId.json";
        public static string IncorrectPersonLettersInDigitIdPath = "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonLettersInDigitId.json";
        public static string IncorrectPersonCharactersInDigitIdPath = "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonCharactersInDigitId.json";

        // Name
        public static string IncorrectPersonNameWithNumbersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonName/personNameWithNumbers.json";
        public static string IncorrectPersonNameWithCharactersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonName/personNameWithCharacters.json";

        // Surname
        public static string IncorrectPersonSurnameWithNumbersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonSurname/personSurnameWithNumbers.json";
        public static string IncorrectPersonSurnameWithCharactersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonSurname/personSurnameWithCharacters.json";

        // Age
        public static string IncorrectPersonAgeWithLettersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithLetters.json";
        public static string IncorrectPersonAgeWithCharactersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithCharacters.json";

        // Family member
        public static string IncorrectPersonFamilyMemberCanNotBePath = "Tests/Data/People/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberCanNotBe.json";
        
        
        
        // "Families section":
        public static string MissingFamiliesSectionPath = "Tests/Data/Families/MissingFields/missingFamiliesField.json";
        
        // Missing fields
        public static string MissingFamilyDigitNumberPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyDigitNumber.json";
        public static string MissingFamilySurnamePath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilySurname.json";
        public static string MissingFamilyParentsListPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyParentsList.json";
        public static string MissingFamilyKidsNamesListPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyKidsNamesList.json";
        public static string MissingKidsNumberPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyKidsNumber.json";
        
        // Incorrect fields
        // Digit id
        public static string IncorrectFamilyQuantityDigitIdPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyQuantityDigitId.json";
        public static string IncorrectFamilyDigitIdNotStartWithExpectedPrefixPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdNotStartWithExpectedPrefix.json";
        public static string IncorrectFamilyDigitIdNotContainsHyphenPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdNotContainsHyphen.json";
        public static string IncorrectFamilyDigitIdContainsLettersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdContainsLetters.json";
        public static string IncorrectFamilyDigitIdContainsCharactersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdContainsCharacters.json";

        // Surname
        public static string IncorrectFamilySurnameContainsNumbersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilySurname/incorrectFamilySurnameContainsNumbers.json";
        public static string IncorrectFamilySurnameContainsCharactersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilySurname/incorrectFamilySurnameContainsCharacters.json";
        
        // Parents list
        public static string IncorrectFamilyParentsNoContainsParentsPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyParentsList/incorrectFamilyParentsNoContainsParents.json";
        public static string IncorrectFamilyParentsContainsNumbersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyParentsList/incorrectFamilyParentsContainsNumbers.json";
        public static string IncorrectFamilyParentsContainsCharactersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyParentsList/incorrectFamilyParentsContainsCharacters.json";

        
        
        
        public static string PersonNameEmptyPath = "Tests/Data/People/EmptyFields/personNameEmpty.json";



    }
}