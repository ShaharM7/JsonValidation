using System.ComponentModel.DataAnnotations;

namespace CYeAutomation.Rules
{
    public class MustBeSevenDigitsNumber : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return false;
            }

            var strValue = (string) value;
            return (strValue == "Bob" || strValue == "Bill");
        }
    }
}