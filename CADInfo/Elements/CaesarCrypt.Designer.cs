namespace CADInfo.Elements
{
	partial class CaesarCrypt
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaesarCrypt));
			this.toolStripCC = new System.Windows.Forms.ToolStrip();
			this.ButtonCryptCC = new System.Windows.Forms.ToolStripButton();
			this.stripSeparatorCC1 = new System.Windows.Forms.ToolStripSeparator();
			this.ButtoncEncryptCC = new System.Windows.Forms.ToolStripButton();
			this.groupBoxInput = new System.Windows.Forms.GroupBox();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.groupBoxOutput = new System.Windows.Forms.GroupBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.ButtonCear = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparatorCC2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparatorCC3 = new System.Windows.Forms.ToolStripSeparator();
			this.keyLabel = new System.Windows.Forms.ToolStripLabel();
			this.textBoxKey = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripCC.SuspendLayout();
			this.groupBoxInput.SuspendLayout();
			this.groupBoxOutput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStripCC
			// 
			this.toolStripCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStripCC.AutoSize = false;
			this.toolStripCC.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripCC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonCryptCC,
            this.stripSeparatorCC1,
            this.ButtoncEncryptCC,
            this.toolStripSeparatorCC2,
            this.keyLabel,
            this.textBoxKey,
            this.toolStripSeparatorCC3,
            this.ButtonCear});
			this.toolStripCC.Location = new System.Drawing.Point(0, 0);
			this.toolStripCC.Name = "toolStripCC";
			this.toolStripCC.Size = new System.Drawing.Size(554, 25);
			this.toolStripCC.TabIndex = 1;
			this.toolStripCC.Text = "toolStrip1";
			// 
			// ButtonCryptCC
			// 
			this.ButtonCryptCC.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCryptCC.Image")));
			this.ButtonCryptCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonCryptCC.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonCryptCC.Name = "ButtonCryptCC";
			this.ButtonCryptCC.Size = new System.Drawing.Size(104, 22);
			this.ButtonCryptCC.Text = "Зашифровать";
			this.ButtonCryptCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonCryptCC.Click += new System.EventHandler(this.ButtonCryptCC_Click);
			// 
			// stripSeparatorCC1
			// 
			this.stripSeparatorCC1.Name = "stripSeparatorCC1";
			this.stripSeparatorCC1.Size = new System.Drawing.Size(6, 25);
			// 
			// ButtoncEncryptCC
			// 
			this.ButtoncEncryptCC.Image = ((System.Drawing.Image)(resources.GetObject("ButtoncEncryptCC.Image")));
			this.ButtoncEncryptCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtoncEncryptCC.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtoncEncryptCC.Name = "ButtoncEncryptCC";
			this.ButtoncEncryptCC.Size = new System.Drawing.Size(110, 22);
			this.ButtoncEncryptCC.Text = "Расшифровать";
			this.ButtoncEncryptCC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtoncEncryptCC.Click += new System.EventHandler(this.ButtoncEncryptCC_Click);
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Controls.Add(this.textBoxInput);
			this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
			this.groupBoxInput.Name = "groupBoxInput";
			this.groupBoxInput.Size = new System.Drawing.Size(560, 254);
			this.groupBoxInput.TabIndex = 2;
			this.groupBoxInput.TabStop = false;
			this.groupBoxInput.Text = "Ввод";
			// 
			// textBoxInput
			// 
			this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxInput.Location = new System.Drawing.Point(6, 19);
			this.textBoxInput.Multiline = true;
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxInput.Size = new System.Drawing.Size(548, 229);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.Text = resources.GetString("textBoxInput.Text");
			// 
			// groupBoxOutput
			// 
			this.groupBoxOutput.Controls.Add(this.textBoxOutput);
			this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
			this.groupBoxOutput.Name = "groupBoxOutput";
			this.groupBoxOutput.Size = new System.Drawing.Size(560, 264);
			this.groupBoxOutput.TabIndex = 3;
			this.groupBoxOutput.TabStop = false;
			this.groupBoxOutput.Text = "Вывод";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutput.Location = new System.Drawing.Point(6, 16);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxOutput.Size = new System.Drawing.Size(548, 239);
			this.textBoxOutput.TabIndex = 1;
			// 
			// toolTip
			// 
			this.toolTip.AutomaticDelay = 0;
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(0, 28);
			this.splitContainer.Name = "splitContainer";
			this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.groupBoxInput);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.groupBoxOutput);
			this.splitContainer.Size = new System.Drawing.Size(560, 522);
			this.splitContainer.SplitterDistance = 254;
			this.splitContainer.TabIndex = 4;
			// 
			// ButtonCear
			// 
			this.ButtonCear.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCear.Image")));
			this.ButtonCear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonCear.Name = "ButtonCear";
			this.ButtonCear.Size = new System.Drawing.Size(79, 22);
			this.ButtonCear.Text = "Очистить";
			this.ButtonCear.Click += new System.EventHandler(this.ButtonCear_Click);
			// 
			// toolStripSeparatorCC2
			// 
			this.toolStripSeparatorCC2.Name = "toolStripSeparatorCC2";
			this.toolStripSeparatorCC2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparatorCC3
			// 
			this.toolStripSeparatorCC3.Name = "toolStripSeparatorCC3";
			this.toolStripSeparatorCC3.Size = new System.Drawing.Size(6, 25);
			// 
			// keyLabel
			// 
			this.keyLabel.Name = "keyLabel";
			this.keyLabel.Size = new System.Drawing.Size(38, 22);
			this.keyLabel.Text = "Ключ";
			// 
			// textBoxKey
			// 
			this.textBoxKey.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxKey.Name = "textBoxKey";
			this.textBoxKey.Size = new System.Drawing.Size(100, 25);
			this.textBoxKey.Text = "123";
			// 
			// CaesarCrypt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.toolStripCC);
			this.Name = "CaesarCrypt";
			this.Size = new System.Drawing.Size(560, 550);
			this.toolStripCC.ResumeLayout(false);
			this.toolStripCC.PerformLayout();
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.groupBoxOutput.ResumeLayout(false);
			this.groupBoxOutput.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStripCC;
		private System.Windows.Forms.ToolStripButton ButtonCryptCC;
		private System.Windows.Forms.ToolStripSeparator stripSeparatorCC1;
		private System.Windows.Forms.ToolStripButton ButtoncEncryptCC;
		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.GroupBox groupBoxOutput;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCC2;
		private System.Windows.Forms.ToolStripButton ButtonCear;
		private System.Windows.Forms.ToolStripLabel keyLabel;
		private System.Windows.Forms.ToolStripTextBox textBoxKey;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparatorCC3;
	}
}
