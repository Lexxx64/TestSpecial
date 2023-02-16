string[] ReadyArray = {"hello", "2", "world", ":-)"};

//Метод создания массива по условиям задачи
string[] CreateNewArray(string[] ReadyArray)
{
    string[] NewArray = new string[ReadyArray.Length];
    int count = 0;
    for (int i = 0; i < ReadyArray.Length; i++)
    {
        if ( ReadyArray[i].Length <= 3)
        {
            NewArray[count] = ReadyArray[i];
            count++;
        }
    } return NewArray;
}
