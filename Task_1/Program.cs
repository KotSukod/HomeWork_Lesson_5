//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
Random rnd =  new Random();
int [] array = new int [6];
int i = 0;
int index = 0;
int result = 0;
Console.Write("Массив: ");
while (i < array.Length)
{
    array[i] = rnd.Next(100,1000);
    Console.Write(array[i] + " ");
    i++;
}
int Metod(int number)
{
    if (number % 2 == 0) return 1;
    return 0;
}
while(index < array.Length)
{
    result = result + Metod(array[index]);
    index++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве: {result}");
