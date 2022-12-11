namespace CYeAutomation.Tests.Data
{
    public static class JsonFilesPath
    {
        // Base data
        public const string JsonSchemaFilePath = "Tests/Data/jsonSchema.json";
        public const string JsonValidValuesPath = "Tests/Data/jsonValidValues.json";

        // "People section":
        public const string MissingPersonSectionPath = "Tests/Data/People/MissingFields/missingPeopleField.json";
        
        // Missing fields
        public const string MissingPersonDigitIdPath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonDigitId.json";
        public const string MissingPersonNamePath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonName.json";
        public const string MissingPersonSurnamePath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonSurname.json";
        public const string MissingPersonAgePath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonAge.json";
        public const string MissingPersonFamilyMemberPath = "Tests/Data/People/MissingFields/MissingPersonFields/missingPersonFamilyMember.json";

        // Incorrect fields
        // Digit id
        public const string IncorrectPersonQuantityDigitIdPath = "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonQuantityDigitId.json";
        public const string IncorrectPersonLettersInDigitIdPath = "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonLettersInDigitId.json";
        public const string IncorrectPersonCharactersInDigitIdPath = "Tests/Data/People/IncorrectFields/IncorrectPersonDigitId/incorrectPersonCharactersInDigitId.json";

        // Name
        public const string IncorrectPersonNameWithNumbersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonName/personNameWithNumbers.json";
        public const string IncorrectPersonNameWithCharactersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonName/personNameWithCharacters.json";

        // Surname
        public const string IncorrectPersonSurnameWithNumbersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonSurname/personSurnameWithNumbers.json";
        public const string IncorrectPersonSurnameWithCharactersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonSurname/personSurnameWithCharacters.json";

        // Age
        public const string IncorrectPersonAgeWithLettersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithLetters.json";
        public const string IncorrectPersonAgeWithCharactersPath = "Tests/Data/People/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithCharacters.json";
        public const string IncorrectPersonAgeWithNegativeNumberPath = "Tests/Data/People/IncorrectFields/IncorrectPersonAge/incorrectPersonAgeWithNegativeNumber.json";
        
        // Family member
        public const string IncorrectPersonFamilyMemberCanNotBePath = "Tests/Data/People/IncorrectFields/IncorrectFamilyMember/incorrectPersonFamilyMemberCanNotBe.json";
        
        
        // Empty fields
        public const string PersonNameEmptyPath = "Tests/Data/People/EmptyFields/personNameEmpty.json";
        public const string PersonSurnameEmptyPath = "Tests/Data/People/EmptyFields/personSurnameEmpty.json";
        public const string PersonAgeEmptyPath = "Tests/Data/People/EmptyFields/PersonAgeEmpty.json";
        public const string PersonFamilyMemberEmptyPath = "Tests/Data/People/EmptyFields/PersonFamilyMemberEmpty.json";
        
        
        
        // "Families section":
        public const string MissingFamiliesSectionPath = "Tests/Data/Families/MissingFields/missingFamiliesField.json";
        
        // Missing fields
        public const string MissingFamilyDigitNumberPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyDigitNumber.json";
        public const string MissingFamilySurnamePath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilySurname.json";
        public const string MissingFamilyParentsListPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyParentsList.json";
        public const string MissingFamilyKidsNamesListPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyKidsNamesList.json";
        public const string MissingKidsNumberPath = "Tests/Data/Families/MissingFields/MissingFamilyFields/missingFamilyKidsNumber.json";
        
        // Incorrect fields
        // Digit id
        public const string IncorrectFamilyQuantityDigitIdPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyQuantityDigitId.json";
        public const string IncorrectFamilyDigitIdNotStartWithExpectedPrefixPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdNotStartWithExpectedPrefix.json";
        public const string IncorrectFamilyDigitIdNotContainsHyphenPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdNotContainsHyphen.json";
        public const string IncorrectFamilyDigitIdContainsLettersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdContainsLetters.json";
        public const string IncorrectFamilyDigitIdContainsCharactersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyDigitId/incorrectFamilyDigitIdContainsCharacters.json";

        // Surname
        public const string IncorrectFamilySurnameContainsNumbersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilySurname/incorrectFamilySurnameContainsNumbers.json";
        public const string IncorrectFamilySurnameContainsCharactersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilySurname/incorrectFamilySurnameContainsCharacters.json";
        
        // Parents list
        public const string IncorrectFamilyParentsContainsNumbersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyParentsList/incorrectFamilyParentsContainsNumbers.json";
        public const string IncorrectFamilyParentsNoContainsParentsPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyParentsList/incorrectFamilyParentsContainsCharacters.json";
        
        // Kids list
        public const string IncorrectFamilyKidsNamesContainsNumbersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyKidsNames/incorrectFamilyKidsNamesContainsNumbers.json";
        public const string IncorrectFamilyKidsNamesContainsCharactersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyKidsNames/incorrectFamilyKidsNamesContainsCharacters.json";
        
        // Kids number
        public const string IncorrectFamilyKidsNumbersContainsLettersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyKidsNumber/IncorrectFamilyKidsNumbersContainsLetters.json";
        public const string IncorrectFamilyKidsNumbersContainsCharactersPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyKidsNumber/IncorrectFamilyKidsNumbersContainsCharacters.json";
        public const string IncorrectFamilyKidsNumbersContainsNegativeNumberPath = "Tests/Data/Families/IncorrectFields/IncorrectFamilyKidsNumber/IncorrectFamilyKidsNumbersContainsNegativeNumber.json";
        
        
        // Empty
        public const string FamilySurnameFieldEmptyPath = "Tests/Data/Families/EmptyFields/familySurnameFieldEmpty.json";
        public const string FamilyParentsFieldEmptyPath = "Tests/Data/Families/EmptyFields/familyParentsFieldEmpty.json";
        
        
        // Cause and Effect
        public const string KidsListIsEmptyThenKidsNumIsEqualToZeroPath = "Tests/Data/Families/CauseAndEffect/KidsListIsEmptyThenKidsNumIsEqualToZero.json";
        
        
       
    }
}