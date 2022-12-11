"# JsonValidation" 

Starting points:
* String can be upper case and then we can ignore case sensitive tests
* Family can be without kids - New parents :)
* Person can't be without parents (Except Adam and Eve ;)
* Parent's list can be also as one parent (Hero parent!)
* Family digit number has to have a hyphen else the json is invalid
* If the digit id is has to be five digit length so no need to check
  below or above that, but only that the number will be different from 5
* Age can not be negative - can be zero (if we assumption that the number represent the years)
* No needs to test the family 7 digit number for empty because the test that test the regex of the digit covers that


* The tests are divided "People" section and "Families" section and as some parts:
    * What is happens when field doesn't exist - missing ?
      (Handle with that by required key in json schema)
    * What is happens when field can't fill a number, 
      letter or character ?
      (Handle with that by regex expression in json schema)
    * What is happens when field is empty ?
      (Handle with that by definition of: "nonEmptyString")
      