
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] numbers = new int[4];

FillArray(numbers, 100, 1000);
WriteArray(numbers);

void FillArray(int[] array, int min, int max)
{
  for (int i = 0; i<array.Length; i++ )
  {
    array[i] = new Random().Next(min, max);
  }
}

void WriteArray(int[] array)
{
    for (int i = 0; i<array.Length; i++ )
    {
    Console.Write(array[i] + " ");
    }
  Console.WriteLine();
}

int Quantity(int[] array)
{
    int quantity = 0;
    for (int i = 0; i<array.Length; i++)
    {
    if (array[i] % 2 == 1)
    {
      quantity++;
    }
  }
  return quantity;
}
Console.WriteLine();

int quantity = Quantity(numbers);
Console.WriteLine($"Количество чётных чисел: {quantity}");

