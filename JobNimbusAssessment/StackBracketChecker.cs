/// <summary>
/// More complicated checker that uses a stack instead of a simple counter.
/// This is useful for validating when there are multiple types of brackets that
/// need to be well formed. For example `<html{>name}` might be invalid where 
/// `<html>{name}` or `<html {name}>` would be valid. 
/// Just included this for fun.
/// </summary>
public class StackBracketChecker : IBracketChecker
{
    public bool CheckBracket(string input)
    {
        if (string.IsNullOrEmpty(input)) return true;

        var stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '<')
                stack.Push(c);
            else if (c == '>')
            {
                if (stack.Count == 0) return false;
                stack.Pop();
            }
        }
        return stack.Count == 0;
    }
}

