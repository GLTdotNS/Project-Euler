

List<int> naturals = new List<int>();
int totalSum = 0;
for (int i = 1; i < 1000; i++)
{
    if (i % 3 == 0 && i / i == 1)
    {
        naturals.Add(i);
        totalSum += i;
    }
    else if (i % 5 == 0 && i / i == 1)
    {

        naturals.Add(i);
        totalSum += i;
    }
}

Console.WriteLine(totalSum); //naturals.Sum();