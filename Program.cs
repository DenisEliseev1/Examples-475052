void Zadacha47()
{
    //Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
    Console.Write("Введите количество строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    FillArray2(array);
    PrintArray2(array);
}


void Zadacha50()
{
    //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
    //и возвращает значение этого элемента или же указание, что такого элемента нет.
    Random random = new Random();
    int rows = random.Next(3, 10);
    int coloms = random.Next(3, 10);
    int count = 1;
    double[,] array = new double[rows, coloms];
    FillArray2(array);
    Console.WriteLine($"Выбирете позицию в данном массиве размерностью {rows}х{coloms}");
    Console.WriteLine("Номера позиций в массиве указаны ниже: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            Console.Write(count + "\t");
            count++;
        }
        Console.WriteLine();

    }
    Console.Write("Ваш выбор: ");
    int userSelect = Convert.ToInt32(Console.ReadLine());

    if ((userSelect > rows * coloms) || (userSelect <= 0)) Console.WriteLine("Позиции не существует, выход за пределы массива");
    else
    {
        int userSelectRow = 0;
        int userSelectColom = 0;
        if (userSelect % coloms == 0)
        {
            userSelectRow = userSelect / coloms - 1;
            userSelectColom = coloms - 1;
        }
        else
        {
            userSelectRow = userSelect / coloms;
            userSelectColom = userSelect % coloms - 1;
        }
        double answer = array[userSelectRow, userSelectColom];
        Console.WriteLine($"Значение позиции 1 - {answer}");
        Console.WriteLine();
        PrintArray2(array);
    }
}

void Zadacha52()
{
    //Задача 52. Задайте двумерный массив из целых чисел. 
    //Найдите среднее арифметическое элементов в каждом столбце.
    Random random = new Random();
    int rows = random.Next(3, 5);
    int coloms = random.Next(3, 5);
    int[,] array = new int[rows, coloms];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Среднее арифметическое столбцов массива: ");
    for (int j = 0; j < coloms; j++)
    {
        int sum = 0;
        double answer = 0;
        for (int i = 0; i < rows; i++)
        {
            sum += array[i, j];
        }
        answer = (sum*100 / rows);

        Console.Write(Math.Round(answer/100,2) + "\t");
    }

}

void FillArray(int[,] array, int startNumber = -9, int finishNumber = 9)
{
    int rows = array.GetLength(0);
    int coloms = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            array[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void FillArray2(double[,] array, int startNumber = -999, int finishNumber = 1000)
{
    int rows = array.GetLength(0);
    int coloms = array.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            array[i, j] = Math.Round(random.Next(startNumber, finishNumber) * 0.01, 2);
        }
    }
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int coloms = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void PrintArray2(double[,] array)
{
    int rows = array.GetLength(0);
    int coloms = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < coloms; j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


//Zadacha47 ();
//Zadacha50();
Zadacha52();