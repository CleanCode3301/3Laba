namespace _3Laba
{
	partial class CompositionMatrix
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.startRow = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.startCol = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.finishCol = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.finishRow = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.answerLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.startRow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.startCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.finishCol)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.finishRow)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Произведениие из интервала",
            "Произведение ниже главной дигонали"});
			this.comboBox1.Location = new System.Drawing.Point(12, 267);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(228, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(324, 82);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 26);
			this.button1.TabIndex = 1;
			this.button1.Text = "Вычислить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// startRow
			// 
			this.startRow.Location = new System.Drawing.Point(111, 43);
			this.startRow.Margin = new System.Windows.Forms.Padding(2);
			this.startRow.Name = "startRow";
			this.startRow.Size = new System.Drawing.Size(33, 20);
			this.startRow.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(9, 43);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Start row";
			// 
			// startCol
			// 
			this.startCol.Location = new System.Drawing.Point(111, 83);
			this.startCol.Margin = new System.Windows.Forms.Padding(2);
			this.startCol.Name = "startCol";
			this.startCol.Size = new System.Drawing.Size(33, 20);
			this.startCol.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(9, 82);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Start column";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(374, 169);
			this.textBox1.Margin = new System.Windows.Forms.Padding(2);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(103, 20);
			this.textBox1.TabIndex = 6;
			this.textBox1.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(9, 169);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Finish column";
			// 
			// finishCol
			// 
			this.finishCol.Location = new System.Drawing.Point(111, 170);
			this.finishCol.Margin = new System.Windows.Forms.Padding(2);
			this.finishCol.Name = "finishCol";
			this.finishCol.Size = new System.Drawing.Size(33, 20);
			this.finishCol.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(9, 125);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Finish row";
			// 
			// finishRow
			// 
			this.finishRow.Location = new System.Drawing.Point(111, 126);
			this.finishRow.Margin = new System.Windows.Forms.Padding(2);
			this.finishRow.Name = "finishRow";
			this.finishRow.Size = new System.Drawing.Size(33, 20);
			this.finishRow.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(9, 230);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(275, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Выберите метод высчета произведения";
			// 
			// answerLabel
			// 
			this.answerLabel.AutoSize = true;
			this.answerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.answerLabel.Location = new System.Drawing.Point(321, 169);
			this.answerLabel.Name = "answerLabel";
			this.answerLabel.Size = new System.Drawing.Size(48, 17);
			this.answerLabel.TabIndex = 12;
			this.answerLabel.Text = "Ответ";
			this.answerLabel.Visible = false;
			// 
			// CompositionMatrix
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(508, 332);
			this.Controls.Add(this.answerLabel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.finishCol);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.finishRow);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.startCol);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.startRow);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.comboBox1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "CompositionMatrix";
			this.Text = "Произведение";
			((System.ComponentModel.ISupportInitialize)(this.startRow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.startCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.finishCol)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.finishRow)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		public System.Windows.Forms.NumericUpDown finishCol;
		public System.Windows.Forms.NumericUpDown finishRow;
		public System.Windows.Forms.NumericUpDown startRow;
		public System.Windows.Forms.NumericUpDown startCol;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label answerLabel;
	}
}