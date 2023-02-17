double[,] InitMatrix()
{
double[,] matrix = new double[3,4];
Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i,j] = rnd.Next(1, 10);
}
}

return matrix;
}

void PrintMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}
}

double[,] matrix = InitMatrix();
PrintMatrix(matrix);