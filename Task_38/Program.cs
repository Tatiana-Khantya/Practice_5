// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] arr = new Double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.NextDouble()*(max-min);
    }
    return arr;
}
double DifMaxMin(double[] arr)
{
    double dif = 0;
    int iMax = 0;
    int iMin = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[iMax] < arr[i]) iMax = i;
        if (arr[iMin] > arr[i]) iMin = i;
    }
    double maxD = arr[iMax];
    double minD = arr[iMin];
    dif = maxD - minD;
    return dif;
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(Math.Round(arr[i], 1) + ", ");
        else Console.Write(Math.Round(arr[i], 1) + "]\n");
    }
}
double[] array = CreateArrayRndInt(5, 1, 100);
PrintArray(array);
double difMaxMin = DifMaxMin(array);
Console.WriteLine(Math.Round(difMaxMin, 1));