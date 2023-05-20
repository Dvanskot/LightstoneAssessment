using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

//class only responsible for user inputs
internal class Inputs
{
    public string InputString { get; set; } = string.Empty;
}

//Class only responsible for transforming strings
internal class StringManager
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