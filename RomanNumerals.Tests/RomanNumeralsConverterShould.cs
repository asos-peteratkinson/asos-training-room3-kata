using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RomanNumerals.Tests;

public class RomanNumeralsConverterShould
{
	[Test]
	public void ReturnNull_WhenNumberIsZero()
	{
		var result = RomanNumeralConverter.Convert(0);
		Assert.That(result, Is.Null);
	}

	[TestCase(1, "I")]
	[TestCase(2, "II")]
	[TestCase(3, "III")]
	public void ReturnINumerals_WhenNumberIsLessThan4(int number, string numeral)
	{
		
		var result = RomanNumeralConverter.Convert(number);
		Assert.That(result, Is.EqualTo(numeral));
	}


    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(6, "VI")]
    [TestCase(7, "VII")]
	public void ReturnNumeral_WhenNumberLessThan8GreaterThan3(int number, string numeral)
	{
        var result = RomanNumeralConverter.Convert(number);
        Assert.That(result, Is.EqualTo(numeral));
    }

	[Test]
    public void ReturnNumeral_WhenNumberIs9()
	{
        var result = RomanNumeralConverter.Convert(9);
        Assert.That(result, Is.EqualTo("X"));
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

