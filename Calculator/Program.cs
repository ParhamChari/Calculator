using Calculator;

Console.WriteLine("Hello!");

#region Get User Valid Input
int userFirstNumber = 0;
int userSecondNumber = 0;
var validInteger = false;

while (!validInteger)
{
    try
    {
        userFirstNumber = Helper.Instance.GetValidIntegerInput(Constants.FirstNumber);
        userSecondNumber = Helper.Instance.GetValidIntegerInput(Constants.SecondNumber);

        validInteger = true;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        continue;
    }
}
#endregion


#region Display Calculation Options
Helper.Instance.DisplayOptions();
#endregion


#region Perform Calculation Based on User Choice
var userChoice = char.ToLower(Console.ReadKey().KeyChar);

if (userChoice == 'a')
    Helper.Instance.PerformCalculation(userFirstNumber, userSecondNumber, "+");

else if (userChoice == 's')
    Helper.Instance.PerformCalculation(userFirstNumber, userSecondNumber, "-");

else if (userChoice == 'm')
    Helper.Instance.PerformCalculation(userFirstNumber, userSecondNumber, "*");

else
    Console.WriteLine(Constants.InvalidChoice);

#endregion


Helper.Instance.CloseApp();