/*
    Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Сколько чисел будете вводить? ");
int index = Convert.ToInt32(Console.ReadLine());
int[] array = new int[index];

void InitArray(int[] array)
{
    int a = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {a} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        a++;
    }

}

void PrintArray(int[] array)
{
    Console.WriteLine();
    Console.Write("[ ");
    
    for (int b = 0; b < array.Length; b++)
    {

        Console.Write($"{array[b]}");
        if (b == array.Length - 1) Console.WriteLine(" ]");
        else Console.Write(", ");
    }
}

void NumberMoreZero(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)     sum++;
        if (i == index - 1)      Console.WriteLine($"Из всех введённых вами чисел, {sum} больше нуля!");
    }
}

InitArray(array);
PrintArray(array);
NumberMoreZero(array);