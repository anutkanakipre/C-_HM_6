// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2 ; 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите размер массива ");
int M = Convert.ToInt32(Console.ReadLine());

int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i} число массива ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) count++;  
}
for(int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine($"Количество положительный элементов в массиве = {count}  ");