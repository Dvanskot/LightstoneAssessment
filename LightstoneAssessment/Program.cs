using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Inputs inputs = new Inputs();

        //prompting user to input the number of strings to test

        Console.WriteLine("Please enter the number (between 1 and 25) of string you would like to test");
        inputs.NumberOfCases = Convert.ToInt32(Console.ReadLine().ToString());

        bool isValid = inputs.ValidateNumberOfCases;

        if (isValid)
        {
            DisplayOutput(inputs.NumberOfCases);
        }
        else
        {
            Console.WriteLine("You have entered an invalid number, please try again.");
        }


    }


    public static void DisplayOutput(int numberOfCases)
    {
        //Creating a List of inputs to store the captured string

        List<Inputs> _input = new List<Inputs>();

        for (int x = 0; x < numberOfCases; x++)
        {
            Console.WriteLine($"Enter string number {x + 1}");

            _input.Add(new Inputs
            {
                InputString = Console.ReadLine().ToString(),
            });
        }


        //Creating a stringManager object to transform strings

        StringManager _stringManager = new StringManager();

        //Displaying results

        int caseNumber = 1;
        foreach (Inputs input in _input)
        {
            Console.WriteLine($"Case {caseNumber}: {_stringManager.TransformWords(input.InputString.Trim())}");

            caseNumber++;
        }
    }

    
}

//class only responsible for user inputs
public class Inputs
{
    public int NumberOfCases { get; set; }
    public string InputString { get; set; } = string.Empty;

    public bool ValidateNumberOfCases
    {
        get { return NumberOfCases > 0 && NumberOfCases <= 25; }
    }
    public bool ValidateInputString
    {
        get { 

            return InputString.Trim() == InputString; 
        }
    }
}

//Class only responsible for transforming strings
public class StringManager
{
    //Function to reverse string to the desired output
    public string TransformWords(string input)
    {

        var transformedString = new StringBuilder();
        bool whiteSpace = false;

        int x = input.Length - 1;
        int e = input.Length - 1;

        while (e <= x && e >= 0)
        {
            if (input[e] == ' ')
            {
                if (x - e > 0)
                {
                    if (whiteSpace)
                    {
                        transformedString.Append(" ");
                    }
                    transformedString.Append(input.Substring(e + 1, x - e));
                    whiteSpace = true;
                }
                x = e - 1;
            }
            e--;
        }
        if (x - e > 0)
        {
            if (whiteSpace)
            {
                transformedString.Append(" ");
            }
            transformedString.Append(input.Substring(e + 1, x - e));
        }
        return transformedString.ToString();
    }
}