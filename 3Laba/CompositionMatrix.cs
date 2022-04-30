using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Laba
{
	public partial class CompositionMatrix : Form
	{
		public CompositionMatrix()
		{
			InitializeComponent();
			comboBox1.SelectedIndex = 0;
		}

		public Matrix Matrixx { get; set; }

		private void button1_Click(object sender, EventArgs e)
		{
			answerLabel.Visible = true;
			textBox1.Visible = true;

			if (comboBox1.SelectedIndex == 0)
			{

				int result = Matrixx.Composition((int)startRow.Value, (int)startCol.Value, (int)finishRow.Value, (int)finishCol.Value);
				textBox1.Text = $"{result}";
			}
			else if (comboBox1.SelectedIndex == 1)
			{
				int result = Matrixx.Composition();
				textBox1.Text = result.ToString();
			}

		}
	}
}
