namespace CYeAutomation.Tests.Data
{
    public static class JsonFilesPath
    {
        public static string JsonSchemaFilePath = "Tests/Data/Jsons/jsonSchema.json";
        public static string JsonValidValuesPath = "Tests/Data/Jsons/jsonSchema.json";
        
        // Missing fields - Person
        public static string MissingPersonDigitIdPath = "Tests/Data/Jsons/MissingFields/MissingPersonFields/missingPersonDigitId.json";
        public static string MissingPersonNamePath = "Tests/Data/Jsons/MissingFields/MissingPersonFields/missingPersonName.json";
        public static string MissingPersonSurnamePath = "Tests/Data/Jsons/MissingFields/MissingPersonFields/missingPersonSurname.json";
        public static string MissingPersonAgePath = "Tests/Data/Jsons/MissingFields/MissingPersonFields/missingPersonAge.json";
        public static string MissingPersonFamilyMember = "Tests/Data/Jsons/MissingFields/MissingPersonFields/missingPersonFamilyMember.json";
        
        
        // Incorrect fields
        // Digit id
        public static string IncorrectPersonQuantityDigitId = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonDigitId/incorrectPersonQuantityDigitId.json";
        public static string IncorrectPersonLettersInDigitId = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonDigitId/incorrectPersonLettersInDigitId.json";
        public static string IncorrectPersonCharactersInDigitId = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonDigitId/incorrectPersonCharactersInDigitId.json";
        
        // Name
        public static string IncorrectPersonNameWithNumbers = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonDigitId/IncorrectPersonNameWithNumbers.json";
        public static string IncorrectPersonNameWithCharacters = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonName/personNameWithCharacters.json";
        
        // Surname
        public static string IncorrectPersonSurnameWithNumbers = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonSurname/personSurnameWithNumbers.json";
        public static string IncorrectPersonSurnameWithCharacters = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonSurname/personSurnameWithCharacters.json";
        
        // Age
        public static string IncorrectPersonAgeWithLetters = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithLetters.json";
        public static string IncorrectPersonAgeWithCharacters = "Tests/Data/Jsons/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithCharacters.json";
        
        // Family member
        public static string IncorrectPersonFamilyMemberWithNumber = "Tests/Data/Jsons/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberWithNumber.json";
        public static string IncorrectPersonFamilyMemberWithCharacter = "Tests/Data/Jsons/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberWithCharacter.json";
        public static string IncorrectPersonFamilyMemberCanNotBe = "Tests/Data/Jsons/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberCanNotBe.json";

    }
}