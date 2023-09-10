// Итоговая контрольная работа
// Написать программу, которая из имеющего массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.

Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [m];
void array(string [] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите [i+] элемент массива");
        stringArray[i] = Console.ReadLine();
    }
}
string[] symbol(string [] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <=3)
        n++;
    }
    string [] rez = new string [n];
    int j = 0;
    for (int i =0; i < stringArray.Length; i++)
    {
        if(stringArray[i].Length <= 3)
        {
            rez[j] = stringArray[i];
            j++;
        }
    }
    return rez;
}
void printA(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"'{stringArray[i]}',");
    }
    Console.Write("]");
}
array(stringArray);
printA(symbol(stringArray));
