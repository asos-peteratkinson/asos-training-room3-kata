namespace RomanNumerals.Tests;

public class RomanNumeralsConverterShould
{
	[Test]
	public void ReturnEmpty_WhenInputIsZero()
	{
		var result = RomanNumeralConverter.Convert(0);
		Assert.That(result, null);
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