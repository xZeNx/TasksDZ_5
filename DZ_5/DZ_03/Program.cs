// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

double[] RealNumbers = new double[10];
  
  for (int i = 0; i < RealNumbers.Length; i++ )
  {
    RealNumbers[i] = new Random().Next(1, 100);
    Console.Write(RealNumbers[i] + " ");
  }

double maxNumber = RealNumbers[0];
double minNumber = RealNumbers[0];

  for (int i = 1; i < RealNumbers.Length; i++)
  {
    if (maxNumber < RealNumbers[i])
    {
      maxNumber = RealNumbers[i];
    }
        if (minNumber > RealNumbers[i])
    {
      minNumber = RealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nРазница между максимальным ({maxNumber}) " +
                    $"и минимальным({minNumber}) элементами: {decision}");
