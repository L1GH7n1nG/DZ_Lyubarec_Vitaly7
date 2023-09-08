//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateMatrixRndInt(int n, int m, int min, int max)
{
	double[,] matrix = new double[n, m];
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), 1);
		}
	}
	return matrix;
}

void PrintMatrix(double[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j],7}");
		}
		Console.WriteLine(" |");
	}
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateMatrixRndInt(rows, columns, -100, 100);
PrintMatrix(array);
