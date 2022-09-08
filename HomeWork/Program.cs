Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber && length <= 1)
{
    Console.WriteLine("Не надо так!");
    return;
}

int[] array = FillArray(length);
PrintArray(array);

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) array[i] = random.Next(0, 100);
    return array;
}

void PrintArray(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Что то пошло не так!");
        return;
    }
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}
/* 
// Задача34
int EvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}
int evenNumbers = EvenNumbers(array);
Console.WriteLine($"Чётных чисел: {evenNumbers}");
*/
// Задача 36

int OddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < length; i = i + 2)
    {
       sum = sum + array[i];
    }
    return sum;
}
int oddNumber = OddNumbers(array);
Console.WriteLine($"Сумма чисел стоящих на нечётных местах: {oddNumber}");
/*
int GetMaxNumber(int[] array)
{
    int maxArray = array[0];
    for (int i = 1; i < length; i++)
    {
        if (maxArray < array[i])
        {
            maxArray = array[i];
        }
    }
    return maxArray;
}
int GetMinNumber(int[] array)
{
    int minArray = array[0];
    for (int i = 1; i < length; i++)
    {
        if (minArray > array[i]) minArray = array[i];
    }
    return minArray;
}
if (GetMaxNumber(array) == GetMinNumber(array))
{
    Console.WriteLine("Как не странно, но наибольший элемент равен наименьшему О_о");
}
Console.WriteLine(GetMaxNumber(array));
Console.WriteLine(GetMinNumber(array));

int divNumbers = GetMaxNumber(array) - GetMinNumber(array);
Console.WriteLine($"Разница между наибольшим элементом и наименьшим равна: {divNumbers}");
*/