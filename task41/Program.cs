﻿Console.Clear();
Console.WriteLine("Введите число");
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
    count++;   
}
Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine(count);