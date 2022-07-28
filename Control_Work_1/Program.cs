string[] currentArray = {"Rus", "178", "Denark", "+)", "0", "1234"};
int countElements = 0;

for (int i = 0; i < currentArray.Length; i++)
{
    if (currentArray[i].Length <= 3)
    {
        countElements++;
    } 
}

if (countElements == 0)
{
    Console.WriteLine("[]");
}
else
{
    string[] newArray = new string [countElements];
    string temp = String.Empty;
    int newSize = 0;

    for (int i = 0; i < currentArray.Length; i++)
    {      
        if (currentArray[i].Length <= 3)
        {
            temp = currentArray[i];
            newArray[newSize] = temp;
            newSize++;  
        }      
    }
    PrintArray(newArray);
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            Console.Write($"[\"{array[i]}\", ");
        }
        else if (i == array.Length-1)
        {
            Console.Write($"\"{array[i]}\"]");
        }
        else if (i > 0 && i < array.Length-1)
        {
            Console.Write($"\"{array[i]}\", ");  
        }
    } 
}