#nullable disable
/*
Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber || length <= 0) 
{
    Console.WriteLine("Не надо так!"); 
    return;
}

int[] array = FillArray(length);

PrintArray(array);
int sumPositiveNumber = GetPositiveNumberInArray(array);
Console.WriteLine($"Сумма положительных чисел равна: {sumPositiveNumber}");

int sumNegativeNumber = GetNegativeNumberInArray(array);
Console.WriteLine($"Сумма отрицательных чисел равна: {sumNegativeNumber}");

int GetPositiveNumberInArray(int[] array)
{
    int sumPositiveNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 0) sumPositiveNumber += array[i];
    }
    return sumPositiveNumber;
}

int GetNegativeNumberInArray(int[] array)
{
    int sumNegativeNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegativeNumber += array[i];
    }
    return sumNegativeNumber;
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

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) array[i] = random.Next(-9, 10);
    return array;
}
*/
// Задача 32
/*
Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber || length <= 0) 
{
    Console.WriteLine("Не надо так!"); 
    return;
}

int[] ChangeElementArray(int[] array)
{
    int[] changeArray = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        changeArray[i] = -1 * array[i];
    }
    return changeArray;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) array[i] = random.Next(-99, 100);
    return array;
}

int[] array = FillArray(length);

PrintArray(array);
PrintArray(ChangeElementArray(array));

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
*/
// Задача 33 "Угадай число"
/*
Console.WriteLine("Введите длину массива:");
bool isNumber = int.TryParse(Console.ReadLine(), out int length);
if (!isNumber && length <= 0)
{
    Console.WriteLine("Не надо так!");
    return;
}
int[] array = FillArray(length);
PrintArray(array);

Console.WriteLine("Угадай положительое число от 0 до 999: ");
bool isCount = int.TryParse(Console.ReadLine(), out int count);
if (!isCount && count < 0 && count > 1000)
{
    Console.WriteLine("Повторите попытку");
    return;
}

for (int i = 0; i < length; i++)
{
    
    if(array[i] == count)
    {
        Console.WriteLine("Ура, победа!");
        return;
    }
    else
    {
        Console.WriteLine("Нет");
    }
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++) array[i] = random.Next(0, 1000);
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
*/
//Задача 35
/*
Console.WriteLine("Зададим массив из 123 элементов");
int length = 123;
int[] FillArray(int length)
{
    length = 123;
    int[] array = new int[123];
    Random random = new Random();
    for (int i = 0; i < length; i++) array[i] = random.Next(0, 1000);
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
int[] array = FillArray(length);
PrintArray(array);
int CountOfArray(int[] array)
{
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] < 100)
        {
            n++;
        }
    }
    return n;
}
int countOfArray = CountOfArray(array);
Console.WriteLine($"Число необходимых элементов равно: {countOfArray}");
*/
// Задача 37

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
    for (int i = 0; i < length; i++) array[i] = random.Next(0, 10);
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
int[] CoupleMultiplayNumbers(int[] array)
{
    int[] coupleArray = new int[length / 2];
    int[] x = new int[length];
    int i = 0;
    while (i < length)
    {
        x[i] = 1;
        i++;
    }
    for (int k = 0; k < length; k++)
    {
        if (k >= length/2) break;
        x[k] = array[k] * array[length - 1 - k];
    }
    for (int j = 0; j < length / 2; j++)
    {
        coupleArray[j] = x[j];
    }
    return coupleArray;
}
int[] coupleMultiplay = CoupleMultiplayNumbers(array);
PrintArray(coupleMultiplay);