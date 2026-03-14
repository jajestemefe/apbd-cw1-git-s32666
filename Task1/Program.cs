Console.WriteLine("Hello, World!");

int CalculateAreaRec(int a, int b)
{
    return a*b;
}

int CalculateAverage(int[] values)
{
    int average = 0;
    for (int i = 0; i < values.Length; i++)
    {
        average += values[i];
    }
    return average/values.Length;
}

int CalculateMax(int[] values)
{
    int max = values[0];
    for(int i = 0; i < values.Length; i++)
    {
        if (values[i] > max) max = values[i]; 
    }
    return max;
}

int CalculareMin(int[] values)
{
    int min = values[0];
    for(int i = 0; i < values.Length; i++)
    {
        if(min < values[i]) min = values[i];
    }
    return min;
}