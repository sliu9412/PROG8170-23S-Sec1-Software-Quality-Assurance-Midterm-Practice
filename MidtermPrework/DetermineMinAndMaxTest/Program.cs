using NUnit.Framework;
using SiyuLiuMidtermPrework;

[TestFixture]
public class TestClass
{
    public DetermineMinAndMax? determineMinAndMax;
    
    [SetUp]
    public void Setup()
    {
        determineMinAndMax = new DetermineMinAndMax();
    }

    [Test]
    public void MaxValue_Input1and2and3_ExpectMaxIs3() {
        // Arrage
        double value1 = 1;
        double value2 = 2;
        double value3 = 3;
        string expected_outcome = "The maximum value is 3";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MaxValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MaxValue_Input0andMinus1and1_ExpectMaxIs1()
    {
        // Arrage
        double value1 = 0;
        double value2 = -1;
        double value3 = 1;
        string expected_outcome = "The maximum value is 1";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MaxValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MaxValue_InputPoint5and1and2_ExpectMaxIs2()
    {
        // Arrage
        double value1 = 0.5;
        double value2 = 1;
        double value3 = 2;
        string expected_outcome = "The maximum value is 2";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MaxValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MaxValue_Input0and0and1_ExpectMaxIs1()
    {
        // Arrage
        double value1 = 0;
        double value2 = 0;
        double value3 = 1;
        string expected_outcome = "The maximum value is 1";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MaxValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MaxValue_Input0and2Point5and1_ExpectMaxIs3()
    {
        // Arrage
        double value1 = 0;
        double value2 = 2.5;
        double value3 = 1;
        string expected_outcome = "The maximum value is 2.5";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MaxValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MaxValue_InputMinus1andMinus2andMinus4_ExpectMaxIsMinus1()
    {
        // Arrage
        double value1 = -1;
        double value2 = -2;
        double value3 = -4;
        string expected_outcome = "The maximum value is -1";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MaxValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MaxValue_Input1Point1and1Point2and1Point3_ExpectMaxIs1Point3()
    {
        // Arrage
        double value1 = 1.1;
        double value2 = 1.2;
        double value3 = 1.3;
        string expected_outcome = "The maximum value is 1.3";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MaxValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MinValue_Input1and2and3_ExpectMinIs1()
    {
        // Arrage
        double value1 = 1;
        double value2 = 2;
        double value3 = 3;
        string expected_outcome = "The minimum value is 1";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MinValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MinValue_InputMinus1and0and1_ExpectMinIsMinus1()
    {
        // Arrage
        double value1 = -1;
        double value2 = 0;
        double value3 = 1;
        string expected_outcome = "The minimum value is -1";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MinValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MinValue_Input0Point5and1and2_ExpectMinIs0Point5()
    {
        // Arrage
        double value1 = 0.5;
        double value2 = 1;
        double value3 = 2;
        string expected_outcome = "The minimum value is 0.5";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MinValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MinValue_Input0and0and1_ExpectMinIs0()
    {
        // Arrage
        double value1 = 0;
        double value2 = 0;
        double value3 = 1;
        string expected_outcome = "The minimum value is 0";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MinValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MinValue_Input1Point1and1Point2and1Point3_ExpectMinIs1Point1()
    {
        // Arrage
        double value1 = 1.1;
        double value2 = 1.2;
        double value3 = 1.3;
        string expected_outcome = "The minimum value is 1.1";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MinValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MinValue_Input7and8and11_ExpectMinIs7()
    {
        // Arrage
        double value1 = 7;
        double value2 = 8;
        double value3 = 11;
        string expected_outcome = "The minimum value is 7";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MinValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

    [Test]
    public void MinValue_Input1Point5and10andMinus1_ExpectMinIsMinus1()
    {
        // Arrage
        double value1 = 1.5;
        double value2 = 10;
        double value3 = -1;
        string expected_outcome = "The minimum value is -1";
        // Act
        var determineMinAndMax = new DetermineMinAndMax();
        determineMinAndMax.valueOne = value1;
        determineMinAndMax.valueTwo = value2;
        determineMinAndMax.valueThree = value3;
        var actual_outcome = determineMinAndMax.MinValue();
        // Assert
        Assert.AreEqual(expected_outcome, actual_outcome);
    }

}