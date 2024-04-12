namespace RomanNumerals;

public class RomanNumeralConverter
{
    public static string Convert(int number)
    {
        if (number <= 0) return null;

        if (number == 1)
        {
            return "I";
        }

        return "II";
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