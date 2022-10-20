// Программа, которая покажет количество чётных чисел в массиве.

int[] CreateArrayRndInt(int min, int max)
{
  Random rnd = new Random();
  int[] array = new int[rnd.Next(4, 4)];
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(min, max + 1);
  }

  return array;
}
void PrintArray(int[] array)
{
  Console.Write($"[ ");
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.Write($"] -> ");
}
int CountElement(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) count++;
  }
  return count;

}
int[] arr = CreateArrayRndInt(100, 1000);
PrintArray(arr);
int counts = CountElement(arr);
Console.WriteLine(counts);