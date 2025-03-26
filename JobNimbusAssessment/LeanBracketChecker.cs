/// <summary>
/// Basic, optimal, linear checker for the problem as described.
/// </summary>
public class LeanBracketChecker : IBracketChecker
{
    public bool CheckBracket(string input)
    {
        if (string.IsNullOrEmpty(input)) return true;

        int openBrackets = 0;

        foreach (char c in input)
        {
            if (c == '<')
                openBrackets++;
            else if (c == '>')
            {
                if (openBrackets == 0) return false;
                openBrackets--;
            }
        }
        return openBrackets == 0;
    }   
}

