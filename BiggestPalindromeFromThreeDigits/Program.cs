
List<int> intList = new List<int>();



for (int i = 100; i < 1000; i++)
{
    int result = 0;
    for (int k = 100; k < 1000; k++)
    {
        result = i * k;
        string expression = result.ToString();
        string reverse = string.Empty;
        for (int j = expression.ToCharArray().Length - 1; j >= 0; j--)
        {
            reverse += expression[j].ToString();
        }
        if (expression == reverse)
        {
            intList.Add(int.Parse(expression));
        }

    }

}

Console.WriteLine(intList.Max(x => x));

//Console.WriteLine(String.Join("\n", intList));
//Console.WriteLine(expression);
//Console.WriteLine(reverse);

