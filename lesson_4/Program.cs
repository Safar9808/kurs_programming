﻿/*
string[,] table = new string[2,5];                                      // изначально String.Empty
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4] 
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4] 
table[1,2] = "слово";

for (int rows = 0; rows < 2; rows++)
{
    for (int columns = 0; columns < 5; columns++)
    {
        Console.Write($"-{table[rows, columns]}- ");
    }
    Console.WriteLine();
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)                        
    {
        for (int g = 0; g < matr.GetLength(1); g++)                   
        {
            Console.Write($"{matr[i, g]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)                        
    {
        for (int g = 0; g < matr.GetLength(1); g++)                   
        {
            matr[i,g]=new Random().Next(1,10);  //[1,10) полуинтервал
        }
    }
    Console.WriteLine();
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);
 
*/

int factorial (int n)
{
    if (n == 1) return 1;
    else return n * factorial(n-1);
}
Console.WriteLine(factorial(5));