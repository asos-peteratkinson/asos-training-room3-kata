namespace RomanNumerals.Tests;

public class RomanNumeralsConverterShould
{
	[Test]
	public void ReturnNull_WhenInputIsZero()
	{
		var result = RomanNumeralConverter.Convert(0);
		Assert.That(result, Is.Null);
	}

	[TestCase(1, "I")]
	[TestCase(2, "II")]
	[TestCase(3, "III")]
	public void ReturnINumerals_WhenInputIsLessThan4(int number, string numeral)
	{
		
		var result = RomanNumeralConverter.Convert(number);
		Assert.That(result, Is.EqualTo(numeral));
	}

	[Test]
	public void ReturnVNumeral_WhenInputIs4()
	{
		var result = RomanNumeralConverter.Convert(4);
		Assert.That(result, Is.EqualTo("IV"));
	}

	//[Test]
	//public void ReturnVNumeral_WhenInputIs5()
	//{
	//	var result = RomanNumeralConverter.Convert(5);
	//	Assert.That(result, Is.EqualTo("V"));
	//}
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

