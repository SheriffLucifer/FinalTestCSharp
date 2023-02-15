string[] array = { "hello", "2", "world", ":-)", "guy" };
string[] newArray = ChangeArray(array);

Console.WriteLine($"[{String.Join(", ", array)}] -> [{String.Join(", ", newArray)}]");

string[] ChangeArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref newArray, count);
    return newArray;
}