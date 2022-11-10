/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.Clear();

string[] firstArray = FillArray();
string[] secondArray = new string[firstArray.Length];
resultArray(firstArray, secondArray);
Console.WriteLine($"[{string.Join(", ",firstArray)}] -> [{string.Join(", ",secondArray)}]");

void resultArray(string[] inputArray, string[] outputArray)
{
  int count = 0;
  int len = 3;
    for (int i = 0; i < inputArray.Length; i++)
    {
    if(inputArray[i].Length <= len)
        {
        outputArray[count] = inputArray[i];
        count++;
        }
    }
}

string[] FillArray() 
{
    Console.Write("Введите элементы массива через пробел: ");
    return Console.ReadLine().Split(" ");
}