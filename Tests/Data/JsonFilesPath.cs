﻿namespace CYeAutomation.Tests.Data
{
    public static class JsonFilesPath
    {
        // Base data
        public static string JsonSchemaFilePath = "Tests/Data/jsonSchema.json";
        public static string JsonValidValuesPath = "Tests/Data/jsonSchema.json";

        // "People section":
        // Missing fields
        public static string MissingPersonDigitIdPath =
            "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonDigitId.json";

        public static string MissingPersonNamePath =
            "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonName.json";

        public static string MissingPersonSurnamePath =
            "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonSurname.json";

        public static string MissingPersonAgePath =
            "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonAge.json";

        public static string MissingPersonFamilyMemberPath =
            "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonFamilyMember.json";

        // Incorrect fields
        // Digit id
        public static string IncorrectPersonQuantityDigitIdPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonQuantityDigitId.json";

        public static string IncorrectPersonLettersInDigitIdPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonLettersInDigitId.json";

        public static string IncorrectPersonCharactersInDigitIdPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonCharactersInDigitId.json";

        // Name
        public static string IncorrectPersonNameWithNumbersPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonName/personNameWithNumbers.json";

        public static string IncorrectPersonNameWithCharactersPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonName/personNameWithCharacters.json";

        // Surname
        public static string IncorrectPersonSurnameWithNumbersPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonSurname/personSurnameWithNumbers.json";

        public static string IncorrectPersonSurnameWithCharactersPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonSurname/personSurnameWithCharacters.json";

        // Age
        public static string IncorrectPersonAgeWithLettersPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithLetters.json";

        public static string IncorrectPersonAgeWithCharactersPath =
            "Tests/Data/People/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithCharacters.json";

        // Family member
        public static string IncorrectPersonFamilyMemberWithNumberPath =
            "Tests/Data/People/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberWithNumber.json";

        public static string IncorrectPersonFamilyMemberWithCharacterPath =
            "Tests/Data/People/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberWithCharacter.json";

        public static string IncorrectPersonFamilyMemberCanNotBePath =
            "Tests/Data/People/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberCanNotBe.json";
    }
}