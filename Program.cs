﻿/* Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

string st = "1234";

bool CheckLength (string st)
{
    bool rezult = true;
    if (st.Length > 3)
    {
        rezult = false;
    }
    return rezult;
}

bool rezult = CheckLength(st);
System.Console.WriteLine(rezult);