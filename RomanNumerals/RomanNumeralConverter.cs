namespace RomanNumerals;

public class RomanNumeralConverter
{
    public static string Convert(int number)
    {
        return null;
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