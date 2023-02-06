// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] FillArray(int length, int start, int end)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(start, end + 1);
    }
    return array;
}

int getUserData(string massage)
{
    Console.WriteLine(massage);
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}

double maximum(double [] array)
{
    double max = array[1];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> max)
        {
            max = array[i];
        }
    }
    return max;
}
double mimimum(double [] array)
{
    double min = array[1];
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}
void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int number = getUserData("Введите длинну этого массива");
double [] arr = FillArray(number,0,100);
PrintArray(arr);
double Diff = maximum(arr) - mimimum(arr);
Console.WriteLine($"Разница между максимальным и минимальным значением = {Diff}");
