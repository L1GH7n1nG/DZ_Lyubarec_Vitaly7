// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

bool FindAndReturnElement(int[,] arr, int rows, int columns)
{
	int numRows = arr.GetLength(0);
	int numColumns = arr.GetLength(1);
	if (rows >= 0 && rows < numRows && columns >= 0 && columns < numColumns) return true;
	return false;
}

Console.Write("Введите номер строки от 1: ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца от 1: ");
int column = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] array = CreateMatrixRndInt(7, 7, -100, 100);
PrintMatrix(array);

bool result = FindAndReturnElement(array, row, column);
Console.WriteLine(result ? $"Элемент в массиве на {row + 1} строке и {column + 1} столбце = {array[row, column]}" : $"{row + 1}, {column + 1} - Такого элемента нет в массиве");
