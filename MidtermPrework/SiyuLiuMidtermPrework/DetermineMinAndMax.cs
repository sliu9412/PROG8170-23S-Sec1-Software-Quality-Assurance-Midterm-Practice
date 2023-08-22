namespace SiyuLiuMidtermPrework;

public class DetermineMinAndMax
{
    public double valueOne;
    public double valueTwo;
    public double valueThree;

    public string MaxValue()
    {
        var maxValue = Math.Max(Math.Max(valueOne, valueTwo), valueThree);
        return $"The maximum value is {maxValue}";
    }

    public string MinValue()
    {
        var minValue = Math.Min(Math.Min(valueOne, valueTwo), valueThree);
        return $"The minimum value is {minValue}";
    }

    // Generate Menu
    public static bool Menu()
    {
        Console.WriteLine("### Input Three Values to Get the Maximum and Minimum ###");
        var firstValue = NumberValidator("1. The First Value:");
        if (!firstValue.isValid)
        {
            return false;
        }
        var secondValue = NumberValidator("2. The Second Value:");
        if (!secondValue.isValid)
        {
            return false;
        }
        var thirdValue = NumberValidator("3. The Third Value:");
        if (!thirdValue.isValid)
        {
            return false;
        }
        var determineMinAndMax = new DetermineMinAndMax()
        {
            valueOne = firstValue.validNumber,
            valueTwo = secondValue.validNumber,
            valueThree = thirdValue.validNumber
        };
        Console.WriteLine("### Result: ###");
        Console.WriteLine(determineMinAndMax.MaxValue());
        Console.WriteLine(determineMinAndMax.MinValue());
        return true;
    }

    // Check whether user input is number
    public static (bool isValid, double validNumber) NumberValidator(string OutputMessage)
    {
        Console.WriteLine(OutputMessage);
        var inputValue = Console.ReadLine();
        double validNumber;
        bool isValid = Double.TryParse(inputValue, out validNumber);
        if (isValid)
        {
            return (true, validNumber);
        }
        Console.WriteLine("The input value is not a valid number!");
        return (false, 0);
    }
}