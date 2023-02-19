// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Функция FillArray наполняет массив случайными целыми числами
int[,] FillArray(int[,] matr, int lBound, int hBound)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            matr[i, j] = new Random().Next(lBound, hBound);
    return matr;
}

// Функция PrintArray выводит значения массива на консоль
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write("\t" + matr[i, j]);
        Console.WriteLine();
    }
}

const int m=3;                                                          //  размерность массива по вертикали
const int n=4;                                                          //  размерность массива по горизонтали
int[,] matrix = new int[m, n];
FillArray(matrix,1,100);                                                //  вызов функции по наполнению массива случайными целыми числами
Console.Clear();				                                        //  очистка консоли
Console.WriteLine("Введите позицию элемента в массиве по вертикали:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в массиве по горизонтали:");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && x <= matrix.GetLength(0) && y > 0 && y <= matrix.GetLength(1))
    Console.WriteLine($"На позиции ({x},{y}) находится число {matrix[x - 1, y - 1]}:");
else
    Console.WriteLine("Такого элемента нет:");
PrintArray(matrix);                                                     //  вызов функции по выводу массива в консоль для контроля   