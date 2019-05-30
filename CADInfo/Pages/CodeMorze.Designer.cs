namespace CADInfo.Pages
{
	partial class CodeMorze
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeMorze));
			this.groupBoxInput = new System.Windows.Forms.GroupBox();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.toolStripCC = new System.Windows.Forms.ToolStrip();
			this.ButtonCrypt = new System.Windows.Forms.ToolStripButton();
			this.stripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.ButtoncEncrypt = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.ButtonPlay = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.ButtonCear = new System.Windows.Forms.ToolStripButton();
			this.groupBoxOutput = new System.Windows.Forms.GroupBox();
			this.textBoxOutput = new System.Windows.Forms.TextBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.groupBoxInput.SuspendLayout();
			this.toolStripCC.SuspendLayout();
			this.groupBoxOutput.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxInput
			// 
			this.groupBoxInput.Controls.Add(this.textBoxInput);
			this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
			this.groupBoxInput.Name = "groupBoxInput";
			this.groupBoxInput.Size = new System.Drawing.Size(573, 253);
			this.groupBoxInput.TabIndex = 0;
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
			this.textBoxInput.Size = new System.Drawing.Size(561, 228);
			this.textBoxInput.TabIndex = 0;
			this.textBoxInput.Text = "Манило море";
			// 
			// toolStripCC
			// 
			this.toolStripCC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.toolStripCC.AutoSize = false;
			this.toolStripCC.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStripCC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButtonCrypt,
            this.stripSeparator1,
            this.ButtoncEncrypt,
            this.toolStripSeparator2,
            this.ButtonPlay,
            this.toolStripSeparator3,
            this.ButtonCear});
			this.toolStripCC.Location = new System.Drawing.Point(0, 3);
			this.toolStripCC.Name = "toolStripCC";
			this.toolStripCC.Size = new System.Drawing.Size(573, 25);
			this.toolStripCC.TabIndex = 0;
			this.toolStripCC.Text = "toolStrip1";
			// 
			// ButtonCrypt
			// 
			this.ButtonCrypt.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCrypt.Image")));
			this.ButtonCrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtonCrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonCrypt.Name = "ButtonCrypt";
			this.ButtonCrypt.Size = new System.Drawing.Size(104, 22);
			this.ButtonCrypt.Text = "Зашифровать";
			this.ButtonCrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtonCrypt.Click += new System.EventHandler(this.ButtonCrypt_Click);
			// 
			// stripSeparator1
			// 
			this.stripSeparator1.Name = "stripSeparator1";
			this.stripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// ButtoncEncrypt
			// 
			this.ButtoncEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("ButtoncEncrypt.Image")));
			this.ButtoncEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.ButtoncEncrypt.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtoncEncrypt.Name = "ButtoncEncrypt";
			this.ButtoncEncrypt.Size = new System.Drawing.Size(110, 22);
			this.ButtoncEncrypt.Text = "Расшифровать";
			this.ButtoncEncrypt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.ButtoncEncrypt.Click += new System.EventHandler(this.ButtoncEncrypt_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// ButtonPlay
			// 
			this.ButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPlay.Image")));
			this.ButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ButtonPlay.Name = "ButtonPlay";
			this.ButtonPlay.Size = new System.Drawing.Size(117, 22);
			this.ButtonPlay.Text = "Воиспроизвести";
			this.ButtonPlay.ToolTipText = "Воиспроизвести";
			this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
			// groupBoxOutput
			// 
			this.groupBoxOutput.Controls.Add(this.textBoxOutput);
			this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
			this.groupBoxOutput.Name = "groupBoxOutput";
			this.groupBoxOutput.Size = new System.Drawing.Size(573, 265);
			this.groupBoxOutput.TabIndex = 0;
			this.groupBoxOutput.TabStop = false;
			this.groupBoxOutput.Text = "Вывод";
			// 
			// textBoxOutput
			// 
			this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxOutput.Location = new System.Drawing.Point(6, 16);
			this.textBoxOutput.Multiline = true;
			this.textBoxOutput.Name = "textBoxOutput";
			this.textBoxOutput.ReadOnly = true;
			this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBoxOutput.Size = new System.Drawing.Size(561, 240);
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
			this.splitContainer.Location = new System.Drawing.Point(0, 31);
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
			this.splitContainer.Size = new System.Drawing.Size(573, 522);
			this.splitContainer.SplitterDistance = 253;
			this.splitContainer.TabIndex = 6;
			// 
			// CodeMorze
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStripCC);
			this.Controls.Add(this.splitContainer);
			this.Name = "CodeMorze";
			this.Size = new System.Drawing.Size(573, 557);
			this.groupBoxInput.ResumeLayout(false);
			this.groupBoxInput.PerformLayout();
			this.toolStripCC.ResumeLayout(false);
			this.toolStripCC.PerformLayout();
			this.groupBoxOutput.ResumeLayout(false);
			this.groupBoxOutput.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxInput;
		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.ToolStrip toolStripCC;
		private System.Windows.Forms.ToolStripButton ButtonCrypt;
		private System.Windows.Forms.ToolStripSeparator stripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton ButtonCear;
		private System.Windows.Forms.GroupBox groupBoxOutput;
		private System.Windows.Forms.TextBox textBoxOutput;
		private System.Windows.Forms.ToolTip toolTip;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.ToolStripButton ButtoncEncrypt;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton ButtonPlay;
	}
}
