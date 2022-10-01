//   Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Random rnd =  new Random();
int [] array = new int [5];
int i = 0;
Console.Write("Массив: ");
while (i < array.Length)
{
    array[i] = rnd.Next(-100,101);
    Console.Write(array[i] + " ");
    i++;
}
int Metod(int[] arr)
{
   int result = 0;
   int index = arr.Length -1;
    while (index >= 0)
   {
     if (index % 2 != 0) result = result + arr[index];
     index--; 
   }
   return result;
   
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел на нечетных позициях равна {Metod(array)}");