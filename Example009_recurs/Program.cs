// задача
// собрать строку с числами от a до b. a<=b.
Console.WriteLine(NumbersFor(1,10));
Console.WriteLine(NumbersRec(1,10));
Console.WriteLine(NumbersRecV2(1,10));

// итеративный метод
string NumbersFor(int a, int b)
{
    string result = string.Empty;
    for (int i = a; i <= b; i++)
    {
        result+=$"{i} ";
    }
    return result;
}

// метод рекурсии
string NumbersRec (int a, int b)
{
    if (a<=b) return $"{a} " + NumbersRec(a+1,b);
    else return string.Empty;
}
string NumbersRecV2 (int a, int b)
{
    if (a<b) return $"{a} " + NumbersRec(a+1,b);
    else return $"{a}";
}