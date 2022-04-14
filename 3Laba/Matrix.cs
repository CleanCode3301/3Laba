using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Laba
{
	public class Matrix
	{
		private int[,] matrix;

		public int this[int i, int j]
		{
			get => matrix[i, j];
			set => matrix[i, j] = value;
		}

		public int GetLength(int index)
		{ return matrix.GetLength(index); }


		public Matrix(RichTextBox richTextBox)
		{
			var lines = richTextBox.Lines;
			var rowCount = lines.Length;
			var colsCount = lines[0].Split(' ').Length;

			if (rowCount != colsCount)
			{
				throw new Exception("Число строк и столбцов не совпадает");
			}

			matrix = new int[rowCount, colsCount];

			for (int i = 0; i < rowCount; i++)
			{
				var elements = lines[i].Split(' ');
				for (int j = 0; j < elements.Length; j++)
				{
					matrix[i, j] = int.Parse(elements[j]);
				}
			}
		}

		public int Composition(int startI, int startJ, int finishI, int finishJ)
		{
			int result = 1;

			if (startJ == finishJ)
			{
				for (int i = startI; i <= finishI; i++)
				{
					result *= matrix[i, startJ];
				}
			}
			else if (startI == finishI)
			{
				for (int j = startJ; j <= finishJ; j++)
				{
					result *= matrix[startI, j];

				}
			}
			else
			{
				MessageBox.Show("Вы задали некорректные параметры");
			}

			return result;
		}

		public int Composition()
		{
			int result = 1;

			if (GetLength(0) == GetLength(1))
			{
				for (int i = GetLength(0) - 1; i >= 0; i--)
				{
					for (int j = GetLength(1) - 1; j >= 0; j--)
					{
						if (j < i)
						{
							result *= matrix[i, j];
						}
					}
				}
			}

			return result;
		}

		public int MaximumElement(int start, int finish)
		{
			return matrix[start, finish];
		}

		public (int, int) MaximumIndexes()
		{
			int max = matrix[0, 0];
			int start = 0;
			int finish = 0;
			for (int i = 0; i < GetLength(0); i++)
			{
				for (int j = 0; j < GetLength(1); j++)
				{
					if (matrix[i, j] > max)
					{
						max = matrix[i, j];
						start = i;
						finish = j;

					}
				}
			}

			return (start, finish);
		}
	}
}
