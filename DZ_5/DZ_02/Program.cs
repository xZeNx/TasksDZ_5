// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Write($"Введи количество массива: ");
int number = Convert.ToInt32(Console.ReadLine());

int randomNumbers =  RandomNumbers(number, 1, 10);
int RandomNumbers(int number, int min, int max)
  {
  int[] randomNumbers = new int[number];
  int sum = 0;
  Console.Write("Получившийся массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ )
    {
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sum = sum + randomNumbers[i];
      }
    }
  return sum;
  }

Console.WriteLine($"\nСумма элементов на нечётных позициях: {randomNumbers}");
