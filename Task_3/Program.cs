// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArrayRndInt(int size, int min, int max)
{
  double[] array = new double[size];
  Random rnd = new Random();

  for (int i = 0; i < size; i++)
  {
    array[i] = rnd.NextDouble() * (max - min) + min;
  }
  return array;
}
void PrintArray(double[] array)
{
  Console.Write($"[");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($" {Math.Round(array[i], 2)} ");
  }
  Console.Write($"] -> ");
}
double DiffRen(double[] arr)
{
  double diff = 0;
  double min = arr[0];
  double max = arr[0];
  for (int i = 0; i < arr.Length; i++)

  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];
    diff = max - min;
  }
  diff = max - min;
  return diff;
}
double[] arr = CreateArrayRndInt(5, 1, 100);
PrintArray(arr);
double ren = DiffRen(arr);
Console.WriteLine(Math.Round(ren, 2));