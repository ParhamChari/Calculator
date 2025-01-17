namespace Calculator;

public sealed class Helper
{
    private static Helper _instance;
    public static Helper Instance => 
        _instance ?? (_instance = new Helper());

    private Helper()
    {
    }

    public int GetValidIntegerInput(string prompt)
    {
        Console.WriteLine(prompt);
        var userInput = Console.ReadLine();

        if(int.TryParse(userInput, out int integerValue))
            return integerValue;
        else
            throw new FormatException(Constants.InvalidInput);
    }

    public void DisplayOptions()
    {
        Console.WriteLine(Constants.OptionQuestion);
        Console.WriteLine(Constants.AddNumbers);
        Console.WriteLine(Constants.SubtractNumbers);
        Console.WriteLine(Constants.MultiplyNumbers);
    }

    public void PerformCalculation(int firstNumber, int secondNumber, string @operation)
    {
        int result = 0;
        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;
                break;

            case "-":
                result = firstNumber - secondNumber;
                break;

            case "*":
                result = firstNumber * secondNumber;
                break;
        }

        var finalEquation = $"\n{firstNumber} {operation} {secondNumber} = {result}";

        Console.WriteLine(finalEquation);
    }

    /// <summary>
    /// Press any key to close
    /// </summary>
    public void CloseApp()
    {
        Console.WriteLine(Constants.PressAnyKey);
        Console.ReadKey();
    }
}
