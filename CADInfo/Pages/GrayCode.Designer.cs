namespace CADInfo.Pages
{
	partial class GrayCode
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose( );
			}
			base.Dispose( disposing );
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.groupBoxGrayCode = new System.Windows.Forms.GroupBox();
			this.groupBoxOutputGray = new System.Windows.Forms.GroupBox();
			this.labelBinOutputValue = new System.Windows.Forms.Label();
			this.labelDecGrayText = new System.Windows.Forms.Label();
			this.labelDecOutputValue = new System.Windows.Forms.Label();
			this.labelBinGrayText = new System.Windows.Forms.Label();
			this.groupBoxInputGray = new System.Windows.Forms.GroupBox();
			this.labelDecInputText = new System.Windows.Forms.Label();
			this.labelDecInputGray = new System.Windows.Forms.Label();
			this.buttonConvertOfGray = new System.Windows.Forms.Button();
			this.buttonConvertToGray = new System.Windows.Forms.Button();
			this.textBoxInputGray = new System.Windows.Forms.TextBox();
			this.labelBinTextGrayInput = new System.Windows.Forms.Label();
			this.groupBoxGrayCode.SuspendLayout();
			this.groupBoxOutputGray.SuspendLayout();
			this.groupBoxInputGray.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxGrayCode
			// 
			this.groupBoxGrayCode.Controls.Add(this.groupBoxOutputGray);
			this.groupBoxGrayCode.Controls.Add(this.groupBoxInputGray);
			this.groupBoxGrayCode.Location = new System.Drawing.Point(7, 14);
			this.groupBoxGrayCode.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.groupBoxGrayCode.Name = "groupBoxGrayCode";
			this.groupBoxGrayCode.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.groupBoxGrayCode.Size = new System.Drawing.Size(613, 260);
			this.groupBoxGrayCode.TabIndex = 0;
			this.groupBoxGrayCode.TabStop = false;
			this.groupBoxGrayCode.Text = "Код Грея:";
			// 
			// groupBoxOutputGray
			// 
			this.groupBoxOutputGray.Controls.Add(this.labelBinOutputValue);
			this.groupBoxOutputGray.Controls.Add(this.labelDecGrayText);
			this.groupBoxOutputGray.Controls.Add(this.labelDecOutputValue);
			this.groupBoxOutputGray.Controls.Add(this.labelBinGrayText);
			this.groupBoxOutputGray.Location = new System.Drawing.Point(8, 175);
			this.groupBoxOutputGray.Name = "groupBoxOutputGray";
			this.groupBoxOutputGray.Size = new System.Drawing.Size(597, 74);
			this.groupBoxOutputGray.TabIndex = 5;
			this.groupBoxOutputGray.TabStop = false;
			this.groupBoxOutputGray.Text = "Вывод:";
			// 
			// labelBinOutputValue
			// 
			this.labelBinOutputValue.AutoSize = true;
			this.labelBinOutputValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBinOutputValue.Location = new System.Drawing.Point(197, 43);
			this.labelBinOutputValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelBinOutputValue.Name = "labelBinOutputValue";
			this.labelBinOutputValue.Size = new System.Drawing.Size(2, 18);
			this.labelBinOutputValue.TabIndex = 5;
			// 
			// labelDecGrayText
			// 
			this.labelDecGrayText.AutoSize = true;
			this.labelDecGrayText.Location = new System.Drawing.Point(8, 19);
			this.labelDecGrayText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelDecGrayText.Name = "labelDecGrayText";
			this.labelDecGrayText.Size = new System.Drawing.Size(168, 16);
			this.labelDecGrayText.TabIndex = 2;
			this.labelDecGrayText.Text = "Десятичное число";
			// 
			// labelDecOutputValue
			// 
			this.labelDecOutputValue.AutoSize = true;
			this.labelDecOutputValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelDecOutputValue.Location = new System.Drawing.Point(197, 17);
			this.labelDecOutputValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelDecOutputValue.Name = "labelDecOutputValue";
			this.labelDecOutputValue.Size = new System.Drawing.Size(2, 18);
			this.labelDecOutputValue.TabIndex = 3;
			// 
			// labelBinGrayText
			// 
			this.labelBinGrayText.AutoSize = true;
			this.labelBinGrayText.Location = new System.Drawing.Point(8, 47);
			this.labelBinGrayText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelBinGrayText.Name = "labelBinGrayText";
			this.labelBinGrayText.Size = new System.Drawing.Size(88, 16);
			this.labelBinGrayText.TabIndex = 4;
			this.labelBinGrayText.Text = "Двоичное";
			// 
			// groupBoxInputGray
			// 
			this.groupBoxInputGray.Controls.Add(this.labelDecInputText);
			this.groupBoxInputGray.Controls.Add(this.labelDecInputGray);
			this.groupBoxInputGray.Controls.Add(this.buttonConvertOfGray);
			this.groupBoxInputGray.Controls.Add(this.buttonConvertToGray);
			this.groupBoxInputGray.Controls.Add(this.textBoxInputGray);
			this.groupBoxInputGray.Controls.Add(this.labelBinTextGrayInput);
			this.groupBoxInputGray.Location = new System.Drawing.Point(8, 23);
			this.groupBoxInputGray.Name = "groupBoxInputGray";
			this.groupBoxInputGray.Size = new System.Drawing.Size(597, 146);
			this.groupBoxInputGray.TabIndex = 1;
			this.groupBoxInputGray.TabStop = false;
			this.groupBoxInputGray.Text = "Ввод:";
			// 
			// labelDecInputText
			// 
			this.labelDecInputText.AutoSize = true;
			this.labelDecInputText.Location = new System.Drawing.Point(10, 45);
			this.labelDecInputText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelDecInputText.Name = "labelDecInputText";
			this.labelDecInputText.Size = new System.Drawing.Size(168, 16);
			this.labelDecInputText.TabIndex = 4;
			this.labelDecInputText.Text = "Десятичное число";
			// 
			// labelDecInputGray
			// 
			this.labelDecInputGray.AutoSize = true;
			this.labelDecInputGray.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelDecInputGray.Location = new System.Drawing.Point(197, 43);
			this.labelDecInputGray.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelDecInputGray.Name = "labelDecInputGray";
			this.labelDecInputGray.Size = new System.Drawing.Size(2, 18);
			this.labelDecInputGray.TabIndex = 5;
			// 
			// buttonConvertOfGray
			// 
			this.buttonConvertOfGray.Location = new System.Drawing.Point(349, 76);
			this.buttonConvertOfGray.Name = "buttonConvertOfGray";
			this.buttonConvertOfGray.Size = new System.Drawing.Size(146, 54);
			this.buttonConvertOfGray.TabIndex = 2;
			this.buttonConvertOfGray.Text = "Преобразовать из кода Грея";
			this.buttonConvertOfGray.UseVisualStyleBackColor = true;
			this.buttonConvertOfGray.Click += new System.EventHandler(this.ButtonConvertOfGray_Click);
			// 
			// buttonConvertToGray
			// 
			this.buttonConvertToGray.Location = new System.Drawing.Point(197, 76);
			this.buttonConvertToGray.Name = "buttonConvertToGray";
			this.buttonConvertToGray.Size = new System.Drawing.Size(146, 54);
			this.buttonConvertToGray.TabIndex = 1;
			this.buttonConvertToGray.Text = "Преобразовать в код Грея";
			this.buttonConvertToGray.UseVisualStyleBackColor = true;
			this.buttonConvertToGray.Click += new System.EventHandler(this.ButtonConvertToGray_Click);
			// 
			// textBoxInputGray
			// 
			this.textBoxInputGray.Location = new System.Drawing.Point(197, 16);
			this.textBoxInputGray.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.textBoxInputGray.MaxLength = 8;
			this.textBoxInputGray.Name = "textBoxInputGray";
			this.textBoxInputGray.Size = new System.Drawing.Size(392, 23);
			this.textBoxInputGray.TabIndex = 0;
			// 
			// labelBinTextGrayInput
			// 
			this.labelBinTextGrayInput.AutoSize = true;
			this.labelBinTextGrayInput.Location = new System.Drawing.Point(10, 19);
			this.labelBinTextGrayInput.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.labelBinTextGrayInput.Name = "labelBinTextGrayInput";
			this.labelBinTextGrayInput.Size = new System.Drawing.Size(148, 16);
			this.labelBinTextGrayInput.TabIndex = 2;
			this.labelBinTextGrayInput.Text = "Двоичное число";
			// 
			// Codes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxGrayCode);
			this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Codes";
			this.Size = new System.Drawing.Size(625, 558);
			this.groupBoxGrayCode.ResumeLayout(false);
			this.groupBoxOutputGray.ResumeLayout(false);
			this.groupBoxOutputGray.PerformLayout();
			this.groupBoxInputGray.ResumeLayout(false);
			this.groupBoxInputGray.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxGrayCode;
		private System.Windows.Forms.Label labelDecGrayText;
		private System.Windows.Forms.Label labelDecOutputValue;
		private System.Windows.Forms.Label labelBinGrayText;
		private System.Windows.Forms.GroupBox groupBoxInputGray;
		private System.Windows.Forms.TextBox textBoxInputGray;
		private System.Windows.Forms.Label labelBinTextGrayInput;
		private System.Windows.Forms.Button buttonConvertToGray;
		private System.Windows.Forms.GroupBox groupBoxOutputGray;
		private System.Windows.Forms.Button buttonConvertOfGray;
		private System.Windows.Forms.Label labelBinOutputValue;
		private System.Windows.Forms.Label labelDecInputText;
		private System.Windows.Forms.Label labelDecInputGray;
	}
}
