//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] Check(int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         int max = array[i,0];
//         int maxInd = 0;
//         for(int k = 0; k < array.GetLength(1) - 1;k++)
//         {
//             max = array[i,k];
//             maxInd = k;
//             for(int j = k; j < array.GetLength(1) - 1;j++)
//             {
//                 if(array[i,j+1] > max) 
//                 {
//                     max = array[i, j+1];
//                     maxInd = j+1;

//                 }
               
//             }
//             int temp = array[i, maxInd];
//             array[i, maxInd] = array[i,k];
//             array[i,k] = temp;
//         }
//     }
//     return array;
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] Array = Create2DRandomArray(rows, columns, minValue, maxValue);
// Console.WriteLine("Initial array:");
// Show2DArray(Array);
// Array = Check(Array);
// Console.WriteLine("Reversed array:");
// Show2DArray(Array);



//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int Check(int[,] array)
// {
//     int minInd = 0;
//     int[] newArray = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             sum += array[i,j];
//         }
//         newArray[i] = sum;
//     }
//     int minSum = newArray[0];
//     for(int k = 1; k < newArray.Length; k++)
//     {
//         if(newArray[k] < minSum) minInd = k;
//     }
//     return minInd;
// }

// int[] Check1(int[,] array)
// {
//     int minInd = 0;
//     int[] newArray = new int[array.GetLength(0)];
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         int sum = 0;
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             sum += array[i,j];
//         }
//         newArray[i] = sum;
//     }
//     return newArray;
// }

// void ShowArray1 (int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         Console.Write ($"<{array[i]}>" + " ");
//     }
//     Console.WriteLine ();
// }

// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// int[,] Array = Create2DRandomArray(rows, columns, minValue, maxValue);
// Console.WriteLine("Initial array:");
// Show2DArray(Array);
// int Index = Check(Array);
// Console.WriteLine($"The index of the row with min sum of the elements is: {Index}");

// int[] myArray = Check1(Array);
// ShowArray1(myArray);





//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int[,] Create2DRandomArray (int rows, int columns, int minValue, int maxValue)
// {
//     int[,] myArray = new int[rows, columns];
//     for(int i = 0; i < rows;i++)
//     {
//         for(int j = 0; j < columns;j++)
//         {
//             myArray[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] Check(int[,] array1, int[,] array2)
// {
//     int[,] NewArray = new int[array1.GetLength(0), array2.GetLength(1)];
//     if(array1.GetLength(1) != array2.GetLength(0))
//     {
//         Console.WriteLine("Can't multiply these arrays");
//         return array1;
//     }
//     else
//     {
//         for(int k = 0; k < array1.GetLength(0);k++)
//         {
//             for(int i = 0; i < array2.GetLength(1);i++)
//             {
//                 int sum = 0;
//                 for(int j = 0; j < array2.GetLength(0);j++)
//                 {
//                  sum += array1[k,j] * array2[j, i];
//                 }
//                 NewArray[k,i] = sum;
//             }
//         }    
//     }
//     return NewArray;
// }

// Console.Write("Введите количество строк для первой матрицы ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов для первой матрицы ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение для первой матрицы ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение для первой матрицы ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите количество строк для второй матрицы ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов для второй матрицы ");
// int columns1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение для второй матрицы ");
// int minValue1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение для второй матрицы ");
// int maxValue1 = Convert.ToInt32(Console.ReadLine());

// int[,] Array1 = Create2DRandomArray(rows, columns, minValue, maxValue);
// int[,] Array2 = Create2DRandomArray(rows1, columns1, minValue1, maxValue1);
// Console.WriteLine("First array:");
// Show2DArray(Array1);
// Console.WriteLine("Second array:");
// Show2DArray(Array2);
// int[,] Array3 = Check(Array1, Array2);
// Show2DArray(Array3);




//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[, ,] Create3DRandomArray (int depth, int rows, int columns)
// {
//     int[, ,] myArray = new int[depth, rows, columns];
//     for(int k =0; k<depth; k++)
//     for(int i = 0; i < rows;i++)
//         {
//             for(int j = 0; j < columns;j++)
//             {
//               myArray[k,i,j] = new Random().Next(10,100);
//             }
//         }
//     return myArray;
// }

// void Show3DArray (int[, ,] array)
// {
//     for(int k =0; k<array.GetLength(0); k++)
//     for(int i = 0; i < array.GetLength(1);i++)
//     {
//         for(int j = 0; j < array.GetLength(2);j++)
//         {
//             Console.Write($"{array[k,i,j]}({k},{i},{j})" + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите глубину матрицы ");
// int depth = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[, ,] Array = Create3DRandomArray(depth, rows, columns);
// Console.WriteLine("Initial array:");
// Show3DArray(Array);



//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int[,] Create2DArray()
// {
//     int rows = 4;
//     int columns = 4;
//     int[,] myArray = new int[rows, columns];
//     int k=1;
//     int i=0;
//     int j=0;
//     while(k<=rows*columns)
//     {
//         myArray[i,j] = k;
//         if (i <= j + 1 && i + j < columns - 1)
//             ++j;
//         else if (i < j && i + j >= rows - 1)
//             ++i;
//         else if (i >= j && i + j > columns - 1)
//             --j;
//         else 
//             --i;
//         ++k;

//     }
    
//     return myArray;
// }

// void Show2DArray (int[,] array)
// {
//     for(int i = 0; i < array.GetLength(0);i++)
//     {
//         for(int j = 0; j < array.GetLength(1);j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] Array = Create2DArray();
// Show2DArray(Array);