Console.Clear();
Console.WriteLine("Введите строки через запятую: ");
string collection = Console.ReadLine()!;
string[] array = collection.Split(", ");


string[] GetSortArray(string[] array)
{
    string sort = String.Empty;
    foreach (var item in array)
    {
        if (item.Length <= 3)
        {
            sort += item + " ";
        }
    }
    string[] sortArray = sort.TrimEnd().Split(" ");
    return sortArray;
}

Console.WriteLine($"[{String.Join(", ", GetSortArray(array))}]");
