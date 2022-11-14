Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите элементы массива строк: ");
string[] wordsArray = new string[N];
    for (int i = 0; i < N; i++)
    {
        wordsArray[i] = Convert.ToString(Console.ReadLine());
    }

void printArray(string[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write($"'{incomingArray[i]}'");
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
printArray(wordsArray);
for (int i = 0; i < N; i++)
    {
        int wordLength = wordsArray[i].Length;
        if (wordLength <= 3)
        {
            Console.Write($"'{wordsArray[i]}', ");
        }
    }
Console.WriteLine();