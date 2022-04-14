using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _3Laba
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
		{
			text.Visible = true;
			richTextBox1.Visible = true;
			ok.Visible = true;
		}

		private void Save_Click(object sender, EventArgs e)
			=> Saving(new Matrix(richTextBox1));

		private void Saving(Matrix matrix)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				var file = new StreamWriter(saveFileDialog1.FileName);
				int count = 0;

				for (int i = 0; i < matrix.GetLength(0); i++)
				{

					for (int j = 0; j < matrix.GetLength(1); j++)
					{
						file.Write(matrix[i, j]);

						if (j < matrix.GetLength(1) - 1)
						{
							file.Write(" ");
						}
					}
					count++;
					if (count < matrix.GetLength(0))
					{
						file.WriteLine();
					}

				}

				file.Close();
			}
		}

		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text != "")
			{
				var matrix = new Matrix(richTextBox1);
				Saving(matrix);
			}
			else
			{
				MessageBox.Show("Вы ещё ничего не ввели. Создайте новый файл.");
			}

		}

		private void обАвтореToolStripMenuItem_Click(object sender, EventArgs e)
			=> new AboutAuthot().Show();

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
			=> Close();

		private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
				return;

			text.Visible = false;
			richTextBox1.Visible = false;
			ok.Visible = false;
			MatrixDataGridView.Visible = true;
			Save.Visible = false;
			MaxRadioButton.Visible = true;
			CompositionRadioButton.Visible = true;
			ProcessingButton.Visible = true;

			string filename = openFileDialog1.FileName;
			string fileText = File.ReadAllText(filename);
			richTextBox1.Text = fileText;

			var matrix = new Matrix(richTextBox1);

			MatrixDataGridView.RowCount = matrix.GetLength(0);
			MatrixDataGridView.ColumnCount = matrix.GetLength(1);

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					MatrixDataGridView[j, i].Value = matrix[i, j];
				}
			}
		}

		private void максимумToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (MatrixDataGridView.Visible == false)
			{
				var matrix = new Matrix(richTextBox1);
				ChangeColourMaxElementInRichTextBox(matrix);
			}
			else
			{
				var matrix = new Matrix(richTextBox1);
				ChangeColourMaxElementInDateGridView(matrix);
			}
		}

		private void ChangeColourMaxElementInDateGridView(Matrix matrix)
			=> MatrixDataGridView[matrix.MaximumIndexes().Item1, matrix.MaximumIndexes().Item2].Style.BackColor = Color.Red;

		private void ChangeColourMaxElementInRichTextBox(Matrix matrix)
		{
			int number = matrix.MaximumElement(matrix.MaximumIndexes().Item1, matrix.MaximumIndexes().Item2);
			int index = IndexSearch(number) * 2 + 1;
			int lenght = 1;

			int count = 0;
			while (richTextBox1.Text[index + count] != ' ' && richTextBox1.Text[index + count] != '\n')
			{
				lenght++;
				count++;
			}

			if (richTextBox1.Text[index] == ' ')
				index--;

			if (richTextBox1.Text[index] == '\n')
				index--;

			richTextBox1.SelectionStart = index;
			richTextBox1.SelectionLength = lenght;
			richTextBox1.SelectionColor = Color.Red;
			richTextBox1.SelectionProtected = true;
		}

		private int IndexSearch(int index)
		{
			var text = richTextBox1.Text.Split(' ', '\n');

			for (int i = 0; i < text.Length; i++)
			{

				if (text[i] == index.ToString())
				{
					return i;
				}
			}

			return -1;
		}

		private void произведениеToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text != "")
			{
				var matrix = new Matrix(richTextBox1);

				var form = new CompositionMatrix();

				form.Matrixx = matrix;

				form.Show();
			}
			else
			{
				MessageBox.Show("Вы ничего ещё не ввели");
			}

		}

		private void ProcessingButton_Click(object sender, EventArgs e)
		{
			var matrix = new Matrix(richTextBox1);

			if (CompositionRadioButton.Checked)
			{
				var form = new CompositionMatrix();

				form.Matrixx = matrix;

				form.Show();
			}
			else if (MaxRadioButton.Checked)
			{
				if (MatrixDataGridView.Visible == false)
				{
					ChangeColourMaxElementInRichTextBox(matrix);
				}
				else
				{
					ChangeColourMaxElementInDateGridView(matrix);
				}
			}
		}

		private void ok_Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text != "")
			{
				var matrix = new Matrix(richTextBox1);
				Save.Visible = true;
				MaxRadioButton.Visible = true;
				CompositionRadioButton.Visible = true;
				ProcessingButton.Visible = true;
			}
			else
			{
				MessageBox.Show("Вы ещё ничего не ввели. Введите матрицу");
			}
		}
	}
}
