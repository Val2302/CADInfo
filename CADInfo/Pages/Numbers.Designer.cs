namespace CADInfo.Pages
{
	partial class Numbers
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Numbers));
			this.labelDecNumber = new System.Windows.Forms.Label();
			this.textBoxDec = new System.Windows.Forms.TextBox();
			this.labelExpText = new System.Windows.Forms.Label();
			this.groupBoxDecNumber = new System.Windows.Forms.GroupBox();
			this.buttonDecCalc = new System.Windows.Forms.Button();
			this.labelHexValue = new System.Windows.Forms.Label();
			this.labelOctValue = new System.Windows.Forms.Label();
			this.labelBinValue = new System.Windows.Forms.Label();
			this.labelExpValue = new System.Windows.Forms.Label();
			this.labelHex = new System.Windows.Forms.Label();
			this.labelOct = new System.Windows.Forms.Label();
			this.labelBin = new System.Windows.Forms.Label();
			this.groupBoxBinNumber = new System.Windows.Forms.GroupBox();
			this.labelAddCodeValue = new System.Windows.Forms.Label();
			this.labelReflexCodeValue = new System.Windows.Forms.Label();
			this.labelPrimeCodeValue = new System.Windows.Forms.Label();
			this.labelAddCode = new System.Windows.Forms.Label();
			this.labelReflexCode = new System.Windows.Forms.Label();
			this.labelPrimeCode = new System.Windows.Forms.Label();
			this.textBoxSignDec = new System.Windows.Forms.TextBox();
			this.labelDecText = new System.Windows.Forms.Label();
			this.buttonBinCalc = new System.Windows.Forms.Button();
			this.groupBoxDecNumber.SuspendLayout();
			this.groupBoxBinNumber.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelDecNumber
			// 
			this.labelDecNumber.AutoSize = true;
			this.labelDecNumber.Location = new System.Drawing.Point(8, 25);
			this.labelDecNumber.Name = "labelDecNumber";
			this.labelDecNumber.Size = new System.Drawing.Size(48, 16);
			this.labelDecNumber.TabIndex = 1;
			this.labelDecNumber.Text = "Ввод";
			// 
			// textBoxDec
			// 
			this.textBoxDec.Location = new System.Drawing.Point(242, 22);
			this.textBoxDec.MaxLength = 8;
			this.textBoxDec.Name = "textBoxDec";
			this.textBoxDec.Size = new System.Drawing.Size(122, 23);
			this.textBoxDec.TabIndex = 0;
			// 
			// labelExpText
			// 
			this.labelExpText.AutoSize = true;
			this.labelExpText.Location = new System.Drawing.Point(8, 56);
			this.labelExpText.Name = "labelExpText";
			this.labelExpText.Size = new System.Drawing.Size(228, 16);
			this.labelExpText.TabIndex = 2;
			this.labelExpText.Text = "Экспоненциальная форма";
			// 
			// groupBoxDecNumber
			// 
			this.groupBoxDecNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxDecNumber.Controls.Add(this.buttonDecCalc);
			this.groupBoxDecNumber.Controls.Add(this.labelHexValue);
			this.groupBoxDecNumber.Controls.Add(this.labelOctValue);
			this.groupBoxDecNumber.Controls.Add(this.labelBinValue);
			this.groupBoxDecNumber.Controls.Add(this.labelExpValue);
			this.groupBoxDecNumber.Controls.Add(this.textBoxDec);
			this.groupBoxDecNumber.Controls.Add(this.labelHex);
			this.groupBoxDecNumber.Controls.Add(this.labelOct);
			this.groupBoxDecNumber.Controls.Add(this.labelBin);
			this.groupBoxDecNumber.Controls.Add(this.labelExpText);
			this.groupBoxDecNumber.Controls.Add(this.labelDecNumber);
			this.groupBoxDecNumber.Location = new System.Drawing.Point(14, 13);
			this.groupBoxDecNumber.Name = "groupBoxDecNumber";
			this.groupBoxDecNumber.Size = new System.Drawing.Size(545, 168);
			this.groupBoxDecNumber.TabIndex = 3;
			this.groupBoxDecNumber.TabStop = false;
			this.groupBoxDecNumber.Text = "Для десятичных чисел:";
			// 
			// buttonDecCalc
			// 
			this.buttonDecCalc.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecCalc.Image")));
			this.buttonDecCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonDecCalc.Location = new System.Drawing.Point(399, 14);
			this.buttonDecCalc.Name = "buttonDecCalc";
			this.buttonDecCalc.Size = new System.Drawing.Size(126, 38);
			this.buttonDecCalc.TabIndex = 1;
			this.buttonDecCalc.Text = "Пересчёт";
			this.buttonDecCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDecCalc.UseVisualStyleBackColor = true;
			this.buttonDecCalc.Click += new System.EventHandler(this.ButtonDecCalc_Click);
			// 
			// labelHexValue
			// 
			this.labelHexValue.AutoSize = true;
			this.labelHexValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelHexValue.Location = new System.Drawing.Point(242, 136);
			this.labelHexValue.Name = "labelHexValue";
			this.labelHexValue.Size = new System.Drawing.Size(2, 18);
			this.labelHexValue.TabIndex = 3;
			// 
			// labelOctValue
			// 
			this.labelOctValue.AutoSize = true;
			this.labelOctValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelOctValue.Location = new System.Drawing.Point(242, 109);
			this.labelOctValue.Name = "labelOctValue";
			this.labelOctValue.Size = new System.Drawing.Size(2, 18);
			this.labelOctValue.TabIndex = 3;
			// 
			// labelBinValue
			// 
			this.labelBinValue.AutoSize = true;
			this.labelBinValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelBinValue.Location = new System.Drawing.Point(242, 82);
			this.labelBinValue.Name = "labelBinValue";
			this.labelBinValue.Size = new System.Drawing.Size(2, 18);
			this.labelBinValue.TabIndex = 3;
			// 
			// labelExpValue
			// 
			this.labelExpValue.AutoSize = true;
			this.labelExpValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelExpValue.Location = new System.Drawing.Point(242, 56);
			this.labelExpValue.Name = "labelExpValue";
			this.labelExpValue.Size = new System.Drawing.Size(2, 18);
			this.labelExpValue.TabIndex = 3;
			// 
			// labelHex
			// 
			this.labelHex.AutoSize = true;
			this.labelHex.Location = new System.Drawing.Point(8, 136);
			this.labelHex.Name = "labelHex";
			this.labelHex.Size = new System.Drawing.Size(208, 16);
			this.labelHex.TabIndex = 2;
			this.labelHex.Text = "Шестнадцатеричная СС";
			// 
			// labelOct
			// 
			this.labelOct.AutoSize = true;
			this.labelOct.Location = new System.Drawing.Point(8, 109);
			this.labelOct.Name = "labelOct";
			this.labelOct.Size = new System.Drawing.Size(158, 16);
			this.labelOct.TabIndex = 2;
			this.labelOct.Text = "Восьмеричная СС";
			// 
			// labelBin
			// 
			this.labelBin.AutoSize = true;
			this.labelBin.Location = new System.Drawing.Point(8, 82);
			this.labelBin.Name = "labelBin";
			this.labelBin.Size = new System.Drawing.Size(118, 16);
			this.labelBin.TabIndex = 2;
			this.labelBin.Text = "Двоичная СС";
			// 
			// groupBoxBinNumber
			// 
			this.groupBoxBinNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxBinNumber.Controls.Add(this.labelAddCodeValue);
			this.groupBoxBinNumber.Controls.Add(this.labelReflexCodeValue);
			this.groupBoxBinNumber.Controls.Add(this.labelPrimeCodeValue);
			this.groupBoxBinNumber.Controls.Add(this.labelAddCode);
			this.groupBoxBinNumber.Controls.Add(this.labelReflexCode);
			this.groupBoxBinNumber.Controls.Add(this.labelPrimeCode);
			this.groupBoxBinNumber.Controls.Add(this.textBoxSignDec);
			this.groupBoxBinNumber.Controls.Add(this.labelDecText);
			this.groupBoxBinNumber.Controls.Add(this.buttonBinCalc);
			this.groupBoxBinNumber.Location = new System.Drawing.Point(14, 187);
			this.groupBoxBinNumber.Name = "groupBoxBinNumber";
			this.groupBoxBinNumber.Size = new System.Drawing.Size(545, 146);
			this.groupBoxBinNumber.TabIndex = 4;
			this.groupBoxBinNumber.TabStop = false;
			this.groupBoxBinNumber.Text = "Для двоичных чисел:";
			// 
			// labelAddCodeValue
			// 
			this.labelAddCodeValue.AutoSize = true;
			this.labelAddCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelAddCodeValue.Location = new System.Drawing.Point(240, 116);
			this.labelAddCodeValue.Name = "labelAddCodeValue";
			this.labelAddCodeValue.Size = new System.Drawing.Size(2, 18);
			this.labelAddCodeValue.TabIndex = 8;
			// 
			// labelReflexCodeValue
			// 
			this.labelReflexCodeValue.AutoSize = true;
			this.labelReflexCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelReflexCodeValue.Location = new System.Drawing.Point(240, 89);
			this.labelReflexCodeValue.Name = "labelReflexCodeValue";
			this.labelReflexCodeValue.Size = new System.Drawing.Size(2, 18);
			this.labelReflexCodeValue.TabIndex = 8;
			// 
			// labelPrimeCodeValue
			// 
			this.labelPrimeCodeValue.AutoSize = true;
			this.labelPrimeCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelPrimeCodeValue.Location = new System.Drawing.Point(240, 62);
			this.labelPrimeCodeValue.Name = "labelPrimeCodeValue";
			this.labelPrimeCodeValue.Size = new System.Drawing.Size(2, 18);
			this.labelPrimeCodeValue.TabIndex = 8;
			// 
			// labelAddCode
			// 
			this.labelAddCode.AutoSize = true;
			this.labelAddCode.Location = new System.Drawing.Point(6, 116);
			this.labelAddCode.Name = "labelAddCode";
			this.labelAddCode.Size = new System.Drawing.Size(148, 16);
			this.labelAddCode.TabIndex = 7;
			this.labelAddCode.Text = "Дополнительный";
			// 
			// labelReflexCode
			// 
			this.labelReflexCode.AutoSize = true;
			this.labelReflexCode.Location = new System.Drawing.Point(6, 89);
			this.labelReflexCode.Name = "labelReflexCode";
			this.labelReflexCode.Size = new System.Drawing.Size(128, 16);
			this.labelReflexCode.TabIndex = 7;
			this.labelReflexCode.Text = "Обратный код";
			// 
			// labelPrimeCode
			// 
			this.labelPrimeCode.AutoSize = true;
			this.labelPrimeCode.Location = new System.Drawing.Point(6, 62);
			this.labelPrimeCode.Name = "labelPrimeCode";
			this.labelPrimeCode.Size = new System.Drawing.Size(108, 16);
			this.labelPrimeCode.TabIndex = 7;
			this.labelPrimeCode.Text = "Прямой код";
			// 
			// textBoxSignDec
			// 
			this.textBoxSignDec.Location = new System.Drawing.Point(240, 25);
			this.textBoxSignDec.MaxLength = 8;
			this.textBoxSignDec.Name = "textBoxSignDec";
			this.textBoxSignDec.Size = new System.Drawing.Size(122, 23);
			this.textBoxSignDec.TabIndex = 0;
			// 
			// labelDecText
			// 
			this.labelDecText.AutoSize = true;
			this.labelDecText.Location = new System.Drawing.Point(6, 28);
			this.labelDecText.Name = "labelDecText";
			this.labelDecText.Size = new System.Drawing.Size(168, 16);
			this.labelDecText.TabIndex = 6;
			this.labelDecText.Text = "Десятичное число";
			// 
			// buttonBinCalc
			// 
			this.buttonBinCalc.Image = ((System.Drawing.Image)(resources.GetObject("buttonBinCalc.Image")));
			this.buttonBinCalc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonBinCalc.Location = new System.Drawing.Point(399, 14);
			this.buttonBinCalc.Name = "buttonBinCalc";
			this.buttonBinCalc.Size = new System.Drawing.Size(126, 38);
			this.buttonBinCalc.TabIndex = 1;
			this.buttonBinCalc.Text = "Пересчёт";
			this.buttonBinCalc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonBinCalc.UseVisualStyleBackColor = true;
			this.buttonBinCalc.Click += new System.EventHandler(this.ButtonBinCalc_Click);
			// 
			// Numbers
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxBinNumber);
			this.Controls.Add(this.groupBoxDecNumber);
			this.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Numbers";
			this.Size = new System.Drawing.Size(574, 348);
			this.groupBoxDecNumber.ResumeLayout(false);
			this.groupBoxDecNumber.PerformLayout();
			this.groupBoxBinNumber.ResumeLayout(false);
			this.groupBoxBinNumber.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label labelDecNumber;
		private System.Windows.Forms.TextBox textBoxDec;
		private System.Windows.Forms.Label labelExpText;
		private System.Windows.Forms.GroupBox groupBoxDecNumber;
		private System.Windows.Forms.Label labelExpValue;
		private System.Windows.Forms.Label labelHexValue;
		private System.Windows.Forms.Label labelOctValue;
		private System.Windows.Forms.Label labelBinValue;
		private System.Windows.Forms.Label labelHex;
		private System.Windows.Forms.Label labelOct;
		private System.Windows.Forms.Label labelBin;
		private System.Windows.Forms.GroupBox groupBoxBinNumber;
		private System.Windows.Forms.Button buttonDecCalc;
		private System.Windows.Forms.Button buttonBinCalc;
		private System.Windows.Forms.TextBox textBoxSignDec;
		private System.Windows.Forms.Label labelDecText;
		private System.Windows.Forms.Label labelPrimeCodeValue;
		private System.Windows.Forms.Label labelPrimeCode;
		private System.Windows.Forms.Label labelAddCodeValue;
		private System.Windows.Forms.Label labelReflexCodeValue;
		private System.Windows.Forms.Label labelAddCode;
		private System.Windows.Forms.Label labelReflexCode;
	}
}
