// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

System.Console.WriteLine("Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];
int j = 0;

void Rand (int[] array)
{
   for (int i = 0; i<array.Length; i++)
   {
   array[i] = new Random().Next(-1000,1000);
   }
}

void Print (int[]array)
{
    for (int i = 0; i<array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(" ");
        
    }
}   

void PosNumSum (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) j++;
    }

    Console.WriteLine(j);
}

Rand(array);
Print(array);
Console.WriteLine();
PosNumSum(array);