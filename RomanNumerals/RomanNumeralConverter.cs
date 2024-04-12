namespace RomanNumerals;

public class RomanNumeralConverter
{
    private static Dictionary<int, string> _numerals = new Dictionary<int, string>()
    {
        { 1, "I" }
        , { 4, "IV" }
        , { 5, "V" }
        , {9, "IX"}
    };
 

    public static string Convert(int number)
    {
        if (number <= 0) return null;

        if (_numerals.ContainsKey(number))
        {
            return _numerals[number];
        }

        if (number < 4)
        {
	        return _numerals[1] + Convert(number - 1);
        }

        if (number > 5)
        {
            return "V" + Convert(number - 5);
        }

        return _numerals[1] + Convert(number - 1);
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