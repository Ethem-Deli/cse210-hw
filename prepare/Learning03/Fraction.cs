public class Fraction
{    // As i took a math class i would like to use numerator & denominatior instead top& bottom i hope it doen't effect the grade.
    //Attributes of numerator and denominator 
    private int _numerator;
    private int _denominator;

    // Constructor with no parameters (1/1)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    // Constructor with one parameter for numerator only (denominator 1)
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    // Constructor with two parameters for numerator and denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters and setters for numerator
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    // Getters and setters for denominator
    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }

    // Return fraction as a string in form as "numerator/denominator"
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    // Return decimal value of fraction
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}
