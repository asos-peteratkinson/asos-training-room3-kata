namespace RomanNumerals.Tests;

public class RomanNumeralsConverterShould
{
	[Test]
	public void ReturnNull_WhenInputIsZero()
	{
		var result = RomanNumeralConverter.Convert(0);
		Assert.That(result, Is.Null);
	}

	[Test]
	public void ReturnI_WhenInputIs1()
	{
        var result = RomanNumeralConverter.Convert(1);
        Assert.That(result, Is.EqualTo("I"));
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

