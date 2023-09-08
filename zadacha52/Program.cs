// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}

void PrintMatrix(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		Console.Write("|");
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write($"{arr[i, j],6}");
		}
		Console.WriteLine(" |");
	}
}

double[] MatrixArithmeticMeanInColumns(int[,] arr)
{
	int numRows = arr.GetLength(0);
	int numColumns = arr.GetLength(1);
	double[] avg = new double[numColumns];
	for (int i = 0; i < numColumns; i++)
	{
		double sum = 0;
		for (int j = 0; j < numRows; j++)
		{
			sum += arr[j, i];
		}
		avg[i] = sum / numRows;
	}
	return avg;
}

int[,] array = CreateMatrixRndInt(10, 10, -100, 100);
double[] result = MatrixArithmeticMeanInColumns(array);
string strresult = string.Join("; ", result);
PrintMatrix(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: [{strresult}]");
