bool IsEven(int x)
{
    return x % 2 == 0;
}

MyDelegate method = IsEven;
Console.WriteLine(method(2));

delegate bool MyDelegate(int value);