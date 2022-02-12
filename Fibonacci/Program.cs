
int result = Fibonacci(100);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    int Fn = 0;
    int Fn2 = 1;
    int Fnext = 0;
    int totalSum = 0;

    for (int i = 1; i <= n; i++)
    {
        Fnext = Fn + Fn2;
        Fn = Fn2;
        Fn2 = Fnext;

        if (totalSum + Fnext > 4000000)
        {
            totalSum += Fnext;
            break;
        }
        if (Fnext % 2 == 0)
        {
            totalSum += Fnext;
        }

    }
    return totalSum;
}
