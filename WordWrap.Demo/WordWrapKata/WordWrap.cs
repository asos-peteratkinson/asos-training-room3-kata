using System;

namespace WordWrapKata;

public class WordWrap
{
    public static string Wrap(string input, int limit)
    {
        if (string.IsNullOrEmpty(input)) 
        {
            return "";
        }

        if (input.Length <= limit)
        {
            return input;
        }
        
        var spacePosition = input.Substring(0, limit).LastIndexOf(" ");

        if (spacePosition >= 0) 
        {
            return input.Substring(0, spacePosition) + "\n" + Wrap(input.Substring(spacePosition + 1), limit);
        }

        return input.Substring(0, limit) + "\n" + Wrap(input.Substring(limit), limit);
    }
}

/* The TPP

1. {}->nil
2. nil->constant
3. constant->constant+
4. constant->scalar
5. statement->statements
6. unconditional->if
7. scalar->array
8. array->container
9. statement->recursion
10. if->while
11. expression->function
12.  variable->assignment

*/