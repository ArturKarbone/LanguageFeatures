static IEnumerable<string> FizzBuzz(this IEnumerable<int> range)
{
    return range.Select(x =>
    {
        if (x % 3 == 0 && x % 5 == 0)
        {
            return "FizzBuzz";
        }
        else if (x % 3 == 0)
        {
            return "Fizz";
        }
        else if (x % 5 == 0)
        {
            return "Buzz";
        }
        else
        {
            return x.ToString();
        }

    });
}