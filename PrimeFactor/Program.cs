

PrimeFactor(600851475143);

static void PrimeFactor(long n)
{
    
    List<int> primeFactors = new List<int>();
    for (int i = 3; i <= n; i += 2)
    {
        while (n % i == 0)
        {
            primeFactors.Add(i);
            Console.Write($"{i} ");
            n /= i;
        }

    }
    int maxNum = primeFactors[primeFactors.Count - 1];

    Console.WriteLine();
    Console.WriteLine($"Biggest num: {maxNum}");

    //int biggestNum = primeFactors.Max(x => x);
    //int max = primeFactors.OrderByDescending(x => x).ElementAt(0);
    //Console.WriteLine($"Biggest num: {max}");
    //Console.WriteLine($"Biggest num: {primeFactors.OrderByDescending(x => x).Take(1).ToList()[0]}");
}