Random rnd =  new Random();
double [] array = new double [5];
int i = 0;
Console.Write("Массив: ");
while (i < array.Length)
{
    array[i] = rnd.Next(1,101);
    Console.Write(array[i] + " ");
    i++;
}

double MaxNumber(double[] arr)
{
    double NumberMax = arr[0];
    foreach(double num in arr)
    {
        if (num > NumberMax) NumberMax = num;
    }
 return NumberMax; 
}
double MinNumber(double[] arr)
{
    double NumberMin = arr[0];
    foreach(double num in arr)
    {
        if (num < NumberMin) NumberMin = num;
    }
 return NumberMin; 
}
double ArrayMax = MaxNumber(array);
double ArrayMin = MinNumber(array);
double result = ArrayMax - ArrayMin;
Console.WriteLine();
Console.WriteLine($"Максимальное число в массиве {ArrayMax}");
Console.WriteLine($"Минимальное  число в массиве {ArrayMin}");
Console.WriteLine($"Разница между максимальным и минимальным числом {result}");