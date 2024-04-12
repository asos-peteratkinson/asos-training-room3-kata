namespace RomanNumerals;

public class RomanNumeralConverter
{
    private static Dictionary<int, string> _numerals = new Dictionary<int, string>()
    {
        { 1, "I" }
    };
 

    public static string Convert(int number)
    {
        if (number <= 0) return null;

        var numeralStr = string.Empty;
        
        for(int i = 0; i < number; i++)
        {
            numeralStr += _numerals[1];
        }

        if (number == 4) return "IV";
        if (number == 5) return "V";

        return numeralStr;
    }
}

/*

- {}->nil
- nil->constant
- constant->constant+
- constant->scalar
- statement->statements
- unconditional->if
- scalar->array
- array->container
- statement->recursion
- if->while
- expression->function
- variable->assignment

*/   