/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.Clear();

string[] firstArray = FillArray();
string[] secondArray = resultArray(firstArray, 3);
Console.WriteLine($"[{string.Join(", ",firstArray)}] -> [{string.Join(", ",secondArray)}]");

string[] resultArray(string[] inputArray, int len)
{
  string[] outputArray = new string[CountElements(inputArray, len)];
  int k = 0;
  for (int i = 0; i < inputArray.Length; i++)
    {
    if(inputArray[i].Length <= len)
        {
        outputArray[k] = inputArray[i];
        k++;
        }
    }
  return outputArray;
}

int CountElements(string[] inputArray, int len)
{
  int count = 0;
  for (int i = 0; i < inputArray.Length; i++)
    {
    if(inputArray[i].Length <= len)
    {
    count++;
    }
  }
  return count;
}

string[] FillArray() 
{
    Console.Write("Введите элементы массива через пробел: ");
    return Console.ReadLine()!.Split(" ");
}