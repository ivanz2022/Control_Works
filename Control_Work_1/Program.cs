string[] currentArray = {"Rus", "178", "Denark", "+)", "0"};
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
    Console.WriteLine("Строк длинной 3 или менее символов в массиве нет.");
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
}