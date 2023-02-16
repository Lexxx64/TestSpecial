string[] ReadyArray = { "hello", "2", "world", ":-)" };
string[] NewArray = CreateNewArray(ReadyArray);
Console.WriteLine($"Заданный массив: {String.Join(", ", ReadyArray)}");
Console.Write($"Новый массив: {String.Join(" ", NewArray)}");

//Метод создания массива по условиям задачи
string[] CreateNewArray(string[] ReadyArray)
{
    string[] NewArray = new string[ReadyArray.Length];
    int count = 0;
    for (int i = 0; i < ReadyArray.Length; i++)
    {
        if (ReadyArray[i].Length <= 3)
        {
            NewArray[count] = ReadyArray[i];
            count++;
        }
    }
    return NewArray;
}
