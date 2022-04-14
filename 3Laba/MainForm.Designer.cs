namespace _3Laba
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.максимумToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.произведениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.text = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.ok = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.MaxRadioButton = new System.Windows.Forms.RadioButton();
			this.CompositionRadioButton = new System.Windows.Forms.RadioButton();
			this.ProcessingButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.MatrixDataGridView = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.файлToolStripMenuItem,
			this.обработкаToolStripMenuItem,
			this.обАвтореToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(481, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.новыйToolStripMenuItem,
			this.открытьToolStripMenuItem,
			this.сохранитьToolStripMenuItem,
			this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// новыйToolStripMenuItem
			// 
			this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
			this.новыйToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.новыйToolStripMenuItem.Text = "Новый";
			this.новыйToolStripMenuItem.Click += new System.EventHandler(this.новыйToolStripMenuItem_Click);
			// 
			// открытьToolStripMenuItem
			// 
			this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
			this.открытьToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.открытьToolStripMenuItem.Text = "Открыть";
			this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
			// 
			// сохранитьToolStripMenuItem
			// 
			this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
			this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.сохранитьToolStripMenuItem.Text = "Сохранить";
			this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
			// 
			// обработкаToolStripMenuItem
			// 
			this.обработкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.максимумToolStripMenuItem,
			this.произведениеToolStripMenuItem});
			this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
			this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
			this.обработкаToolStripMenuItem.Text = "Обработка";
			// 
			// максимумToolStripMenuItem
			// 
			this.максимумToolStripMenuItem.Name = "максимумToolStripMenuItem";
			this.максимумToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
			this.максимумToolStripMenuItem.Text = "Максимум";
			this.максимумToolStripMenuItem.Click += new System.EventHandler(this.максимумToolStripMenuItem_Click);
			// 
			// произведениеToolStripMenuItem
			// 
			this.произведениеToolStripMenuItem.Name = "произведениеToolStripMenuItem";
			this.произведениеToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
			this.произведениеToolStripMenuItem.Text = "Произведение";
			this.произведениеToolStripMenuItem.Click += new System.EventHandler(this.произведениеToolStripMenuItem_Click);
			// 
			// обАвтореToolStripMenuItem
			// 
			this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
			this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
			this.обАвтореToolStripMenuItem.Text = "Об авторе";
			this.обАвтореToolStripMenuItem.Click += new System.EventHandler(this.обАвтореToolStripMenuItem_Click);
			// 
			// text
			// 
			this.text.AutoSize = true;
			this.text.Location = new System.Drawing.Point(105, 51);
			this.text.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.text.Name = "text";
			this.text.Size = new System.Drawing.Size(94, 13);
			this.text.TabIndex = 1;
			this.text.Text = "Введите матрицу";
			this.text.Visible = false;
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(76, 84);
			this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(165, 165);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			this.richTextBox1.Visible = false;
			// 
			// ok
			// 
			this.ok.Location = new System.Drawing.Point(108, 265);
			this.ok.Margin = new System.Windows.Forms.Padding(2);
			this.ok.Name = "ok";
			this.ok.Size = new System.Drawing.Size(70, 27);
			this.ok.TabIndex = 3;
			this.ok.Text = "ОК";
			this.ok.UseVisualStyleBackColor = true;
			this.ok.Visible = false;
			this.ok.Click += new System.EventHandler(this.ok_Click);
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(86, 343);
			this.Save.Margin = new System.Windows.Forms.Padding(2);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(112, 32);
			this.Save.TabIndex = 4;
			this.Save.Text = "Сохранить";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Visible = false;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// MaxRadioButton
			// 
			this.MaxRadioButton.AutoSize = true;
			this.MaxRadioButton.Location = new System.Drawing.Point(332, 84);
			this.MaxRadioButton.Margin = new System.Windows.Forms.Padding(2);
			this.MaxRadioButton.Name = "MaxRadioButton";
			this.MaxRadioButton.Size = new System.Drawing.Size(79, 17);
			this.MaxRadioButton.TabIndex = 5;
			this.MaxRadioButton.TabStop = true;
			this.MaxRadioButton.Text = "Максимум";
			this.MaxRadioButton.UseVisualStyleBackColor = true;
			this.MaxRadioButton.Visible = false;

			// 
			// CompositionRadioButton
			// 
			this.CompositionRadioButton.AutoSize = true;
			this.CompositionRadioButton.Location = new System.Drawing.Point(332, 145);
			this.CompositionRadioButton.Margin = new System.Windows.Forms.Padding(2);
			this.CompositionRadioButton.Name = "CompositionRadioButton";
			this.CompositionRadioButton.Size = new System.Drawing.Size(99, 17);
			this.CompositionRadioButton.TabIndex = 6;
			this.CompositionRadioButton.TabStop = true;
			this.CompositionRadioButton.Text = "Произведение";
			this.CompositionRadioButton.UseVisualStyleBackColor = true;
			this.CompositionRadioButton.Visible = false;
			// 
			// ProcessingButton
			// 
			this.ProcessingButton.Location = new System.Drawing.Point(322, 221);
			this.ProcessingButton.Margin = new System.Windows.Forms.Padding(2);
			this.ProcessingButton.Name = "ProcessingButton";
			this.ProcessingButton.Size = new System.Drawing.Size(121, 28);
			this.ProcessingButton.TabIndex = 7;
			this.ProcessingButton.Text = "Обработка";
			this.ProcessingButton.UseVisualStyleBackColor = true;
			this.ProcessingButton.Visible = false;
			this.ProcessingButton.Click += new System.EventHandler(this.ProcessingButton_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MatrixDataGridView
			// 
			this.MatrixDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.MatrixDataGridView.ColumnHeadersVisible = false;
			this.MatrixDataGridView.Location = new System.Drawing.Point(30, 51);
			this.MatrixDataGridView.Margin = new System.Windows.Forms.Padding(2);
			this.MatrixDataGridView.Name = "MatrixDataGridView";
			this.MatrixDataGridView.RowHeadersVisible = false;
			this.MatrixDataGridView.RowHeadersWidth = 51;
			this.MatrixDataGridView.RowTemplate.Height = 24;
			this.MatrixDataGridView.Size = new System.Drawing.Size(258, 260);
			this.MatrixDataGridView.TabIndex = 8;
			this.MatrixDataGridView.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(481, 420);
			this.Controls.Add(this.MatrixDataGridView);
			this.Controls.Add(this.ProcessingButton);
			this.Controls.Add(this.CompositionRadioButton);
			this.Controls.Add(this.MaxRadioButton);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.ok);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.text);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.Text = "Матрица";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.MatrixDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.Label text;
		private System.Windows.Forms.Button ok;
		private System.Windows.Forms.Button Save;
		private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem максимумToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem произведениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.RadioButton MaxRadioButton;
		private System.Windows.Forms.RadioButton CompositionRadioButton;
		private System.Windows.Forms.Button ProcessingButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.DataGridView MatrixDataGridView;
		public System.Windows.Forms.RichTextBox richTextBox1;
	}
}

