using AlgorithmsLibrary.Math;
using System.Timers;

int[,] array1 = new int[4, 4]
{
    { 1, 0, 3, 2},
    { 0, 1, -1, 0},
    { 2, 2, 1, 1},
    { -1, 0, 1, 3}
};

System.Numerics.Matrix4x4 matrix = new(1, 0, 3, 2, 0, 1, -1, 0, 2, 2, 1, 1, -1, 0, 1, 3);

int[,] array2 = new int[3, 3]
{
    { 6, 2, -4},
    { 5, 6, -2},
    { 5, 2, -3}
};
int[,] array3 = new int[2, 2]
{
    { 6, -2},
    { 2, -3}
};

for (int i = 0; i < 2000; i++)
{
    int start = Environment.TickCount;
    decimal result = (int)matrix.GetDeterminant();
    int end = Environment.TickCount;
    Console.WriteLine($"{result} in {end - start}ms (4x4)");

    int start1 = Environment.TickCount;
    decimal result1 = Matrix.CramerDeterminant(array1);
    int end1 = Environment.TickCount;
    Console.WriteLine($"{result1} in {end1 - start1}ms (Array)");
}
