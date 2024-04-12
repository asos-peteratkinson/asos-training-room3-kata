namespace RomanNumerals;

public class RomanNumeralConverter
{
    private static string[] numerals = new[] { "I", "II", "III", "IIII" };

    public static string Convert(int number)
    {
        if (number <= 0) return null;

		return numerals[number -1] ;
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