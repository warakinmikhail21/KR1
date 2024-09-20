/// <summary>
/// Создание массива str
/// </summary>
/// <param name="size"> Размер массива </param>
/// <returns></returns>
string[] CreateArrayString (int size){
    string [] array_str = new string[size];
    for (int i = 0; i < array_str.Length; i++)
    {
        array_str[i] = Console.ReadLine();
    }
    return array_str;
}

/// <summary>
/// Печать массива 
/// </summary>
/// <param name="array_str"> Получаем на вход массив str </param>
void PrintArray(string []array_str){
    for (int i = 0; i < array_str.Length; i++)
    {
        Console.Write($"[{array_str[i]}]\t");
    }
}

/// <summary>
/// Создание втрого массива для записи в него подходящих строк их массива 1
/// </summary>
/// <param name="array_str"></param>
void ScanArrayStr (string [] array_str_first, string[] array_str_second){
    int count = 0;
    for (int i = 0; i < array_str_first.Length; i++)
    {
    if(array_str_first[i].Length <= 3)
        {
        array_str_second[count] = array_str_first[i];
        count++;
        }
    }
}

Console.Write("Enter array size -> ");
int size_array = Convert.ToInt32(Console.ReadLine());
string[] array_str_first = CreateArrayString(size_array);
string[] array_str_second = new string [array_str_first.Length]; 
ScanArrayStr(array_str_first,array_str_second);
Console.Write("First array -> ");
PrintArray(array_str_first);
Console.WriteLine();
Console.Write("Final array -> ");
PrintArray(array_str_second);