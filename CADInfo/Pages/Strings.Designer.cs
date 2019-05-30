namespace CADInfo.Pages
{
	partial class Strings
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
			this.labelString = new System.Windows.Forms.Label();
			this.textBoxString = new System.Windows.Forms.TextBox();
			this.buttonRun = new System.Windows.Forms.Button();
			this.labelSymbolsCodes = new System.Windows.Forms.Label();
			this.groupBoxSymbolCodes = new System.Windows.Forms.GroupBox();
			this.groupBoxHash = new System.Windows.Forms.GroupBox();
			this.labelInputCode = new System.Windows.Forms.Label();
			this.labelStandartCode = new System.Windows.Forms.Label();
			this.labelStandartCodeText = new System.Windows.Forms.Label();
			this.labelInputCodeText = new System.Windows.Forms.Label();
			this.groupBoxSymbolCodes.SuspendLayout();
			this.groupBoxHash.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelString
			// 
			this.labelString.AutoSize = true;
			this.labelString.Location = new System.Drawing.Point(18, 14);
			this.labelString.Name = "labelString";
			this.labelString.Size = new System.Drawing.Size(32, 13);
			this.labelString.TabIndex = 0;
			this.labelString.Text = "Ввод";
			// 
			// textBoxString
			// 
			this.textBoxString.Location = new System.Drawing.Point(62, 11);
			this.textBoxString.Name = "textBoxString";
			this.textBoxString.Size = new System.Drawing.Size(297, 20);
			this.textBoxString.TabIndex = 1;
			// 
			// buttonRun
			// 
			this.buttonRun.Location = new System.Drawing.Point(394, 9);
			this.buttonRun.Name = "buttonRun";
			this.buttonRun.Size = new System.Drawing.Size(75, 23);
			this.buttonRun.TabIndex = 2;
			this.buttonRun.Text = "Выполнить";
			this.buttonRun.UseVisualStyleBackColor = true;
			this.buttonRun.Click += new System.EventHandler(this.ButtonRun_Click);
			// 
			// labelSymbolsCodes
			// 
			this.labelSymbolsCodes.AutoSize = true;
			this.labelSymbolsCodes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelSymbolsCodes.Location = new System.Drawing.Point(12, 21);
			this.labelSymbolsCodes.Name = "labelSymbolsCodes";
			this.labelSymbolsCodes.Size = new System.Drawing.Size(2, 15);
			this.labelSymbolsCodes.TabIndex = 3;
			// 
			// groupBoxSymbolCodes
			// 
			this.groupBoxSymbolCodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxSymbolCodes.AutoSize = true;
			this.groupBoxSymbolCodes.Controls.Add(this.labelSymbolsCodes);
			this.groupBoxSymbolCodes.Location = new System.Drawing.Point(11, 42);
			this.groupBoxSymbolCodes.Name = "groupBoxSymbolCodes";
			this.groupBoxSymbolCodes.Size = new System.Drawing.Size(499, 52);
			this.groupBoxSymbolCodes.TabIndex = 4;
			this.groupBoxSymbolCodes.TabStop = false;
			this.groupBoxSymbolCodes.Text = "Коды символов:";
			// 
			// groupBoxHash
			// 
			this.groupBoxHash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBoxHash.AutoSize = true;
			this.groupBoxHash.Controls.Add(this.labelStandartCodeText);
			this.groupBoxHash.Controls.Add(this.labelInputCodeText);
			this.groupBoxHash.Controls.Add(this.labelStandartCode);
			this.groupBoxHash.Controls.Add(this.labelInputCode);
			this.groupBoxHash.Location = new System.Drawing.Point(11, 100);
			this.groupBoxHash.Name = "groupBoxHash";
			this.groupBoxHash.Size = new System.Drawing.Size(499, 80);
			this.groupBoxHash.TabIndex = 5;
			this.groupBoxHash.TabStop = false;
			this.groupBoxHash.Text = "Хешкоды:";
			// 
			// labelInputCode
			// 
			this.labelInputCode.AutoSize = true;
			this.labelInputCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelInputCode.Location = new System.Drawing.Point(87, 23);
			this.labelInputCode.Name = "labelInputCode";
			this.labelInputCode.Size = new System.Drawing.Size(2, 15);
			this.labelInputCode.TabIndex = 4;
			// 
			// labelStandartCode
			// 
			this.labelStandartCode.AutoSize = true;
			this.labelStandartCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelStandartCode.Location = new System.Drawing.Point(87, 49);
			this.labelStandartCode.Name = "labelStandartCode";
			this.labelStandartCode.Size = new System.Drawing.Size(2, 15);
			this.labelStandartCode.TabIndex = 5;
			// 
			// labelStandartCodeText
			// 
			this.labelStandartCodeText.AutoSize = true;
			this.labelStandartCodeText.Location = new System.Drawing.Point(8, 49);
			this.labelStandartCodeText.Name = "labelStandartCodeText";
			this.labelStandartCodeText.Size = new System.Drawing.Size(74, 13);
			this.labelStandartCodeText.TabIndex = 7;
			this.labelStandartCodeText.Text = "Стандартный";
			// 
			// labelInputCodeText
			// 
			this.labelInputCodeText.AutoSize = true;
			this.labelInputCodeText.Location = new System.Drawing.Point(8, 23);
			this.labelInputCodeText.Name = "labelInputCodeText";
			this.labelInputCodeText.Size = new System.Drawing.Size(32, 13);
			this.labelInputCodeText.TabIndex = 6;
			this.labelInputCodeText.Text = "Свой";
			// 
			// Strings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxHash);
			this.Controls.Add(this.groupBoxSymbolCodes);
			this.Controls.Add(this.buttonRun);
			this.Controls.Add(this.textBoxString);
			this.Controls.Add(this.labelString);
			this.Name = "Strings";
			this.Size = new System.Drawing.Size(521, 235);
			this.groupBoxSymbolCodes.ResumeLayout(false);
			this.groupBoxSymbolCodes.PerformLayout();
			this.groupBoxHash.ResumeLayout(false);
			this.groupBoxHash.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelString;
		private System.Windows.Forms.TextBox textBoxString;
		private System.Windows.Forms.Button buttonRun;
		private System.Windows.Forms.Label labelSymbolsCodes;
		private System.Windows.Forms.GroupBox groupBoxSymbolCodes;
		private System.Windows.Forms.GroupBox groupBoxHash;
		private System.Windows.Forms.Label labelStandartCodeText;
		private System.Windows.Forms.Label labelInputCodeText;
		private System.Windows.Forms.Label labelStandartCode;
		private System.Windows.Forms.Label labelInputCode;
	}
}
