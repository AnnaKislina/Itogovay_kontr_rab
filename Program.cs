/* Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых меньше, 
либо равна 3 символам. Первоначальный массив можно ввести 
с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

bool CheckLength (string st)
{
    bool rezult = true;
    if (st.Length > 3)
    {
        rezult = false;
    }
    return rezult;
}

string[] arraySt = {"Hello", "2", "world", ":-)"};
int num = 0;

for (int i = 0; i < arraySt.Length ; i++)
{
    if (CheckLength(arraySt[i]))
    {
        num++;
    }
}

System.Console.WriteLine(num);