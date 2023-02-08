// Задача
// Написать программу, которая из имеющегося массива строк формирует массив из строк, 

// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами


// функции:
// функция вывода массива
void PrintArray (int[, ]array)
{
    for (int i=0; i<array.GetLength(0); i++) // условие для строк
    {
        for (int j=0; j<array.GetLength(1); j++) // условие для столбцов
        {
            Console.Write($"{array[i, j]} "); // отображение в консоль
        }
        Console.WriteLine(); // отступ
    }
}
// функция заполнения массива
void FillArray (int[, ]array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(-999,1000);  // рандомное число от -999 до 999 
        }
    }
}
// функция переноса данных из одного массива в другой
void Perenos1to2 (int[,] array1, int[,] array2)  
{
    for (int i=0; i<array1.GetLength(0); i++)
    {
        for (int j=0; j<array1.GetLength(1); j++)
        {
            array2[i, j] = array1[i, j];
        }
    }
}


//создаем несколько массивов , во второй будем записывать результат от 1го
int [, ] array1 = new int [2, 2];
int [, ] array2 = new int [2, 2];

// применяем функции по заполнению и выводу
FillArray(array1);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();

FillArray(array2);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();


// вывод итогового массива и комментария
Perenos1to2(array1, array2);
Console.WriteLine($"\aarray2 is:");
PrintArray(array2);