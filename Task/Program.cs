﻿// Итоговый проет GeekBrains 1 четверть

// Написать программу, которая из имеющегося массива из строк формирует массив из строк, 
// длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами 

void AnalyseArray(string line)
{
    char[] arrAnalyse = line.ToCharArray();
    if (arrAnalyse.Length <= 3)
    {
        Console.WriteLine(line);
    }
}


