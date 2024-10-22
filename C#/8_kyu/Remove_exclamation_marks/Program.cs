static string RemoveExclamationMarks(string s)
{
    return s.Replace("!", "");
}

Console.WriteLine(RemoveExclamationMarks("Hello World!")); // Hello World