//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Cube(int a, int b)
{
    int cub = 1;
    for (int i = 1; i <= b; i++)
    {
        cub = cub * a;
    }
    return cub;
}

Console.WriteLine(Cube(3, 5));

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int n)
{
    int coun = 0;
    while (n > 0)
    {
        coun = coun + n % 10;
        n /= 10;
    }
    return coun;
}

Console.WriteLine(Sum(9012));

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] ArrayRnd(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(1, 20);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write('[');
    for (int i = 0; i < arr.Length; i++)
    {
        if (i>0) Console.Write(", ");
        Console.Write("{0} ", arr[i]);
    }
    Console.WriteLine(']');
}


PrintArray(ArrayRnd(8));