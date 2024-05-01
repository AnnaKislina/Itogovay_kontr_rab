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

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] arraySt = {"Russia", "Denmark", "Kazan"};
int num = 0;
int j = 0;

for (int i = 0; i < arraySt.Length ; i++)
{
    if (CheckLength(arraySt[i]))
    {
        num++;
    }
}

string[] arraySt2 = new string [num];
for (int i = 0; i < arraySt.Length ; i++)
{   
    if (CheckLength(arraySt[i]))
    {
        arraySt2[j] = arraySt[i];
        j++;
    }
}

PrintArray(arraySt2);