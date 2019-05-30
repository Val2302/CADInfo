namespace CADInfo.Pages
{
	partial class Colors
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colors));
			this.pictureBoxImage = new System.Windows.Forms.PictureBox();
			this.panelSelectColor = new System.Windows.Forms.Panel();
			this.groupBoxSelectColor = new System.Windows.Forms.GroupBox();
			this.groupBoxColorSystems = new System.Windows.Forms.GroupBox();
			this.groupBoxRGBA = new System.Windows.Forms.GroupBox();
			this.labelColorPartR = new System.Windows.Forms.Label();
			this.labelColorPartG = new System.Windows.Forms.Label();
			this.labelColorPartB = new System.Windows.Forms.Label();
			this.panelColorR = new System.Windows.Forms.Panel();
			this.panelColorG = new System.Windows.Forms.Panel();
			this.panelColorB = new System.Windows.Forms.Panel();
			this.groupBoxCMYK = new System.Windows.Forms.GroupBox();
			this.labelC = new System.Windows.Forms.Label();
			this.labelM = new System.Windows.Forms.Label();
			this.labelY = new System.Windows.Forms.Label();
			this.labelK = new System.Windows.Forms.Label();
			this.groupBoxXYZ = new System.Windows.Forms.GroupBox();
			this.labelZ = new System.Windows.Forms.Label();
			this.labelYY = new System.Windows.Forms.Label();
			this.labelX = new System.Windows.Forms.Label();
			this.groupBoxHSV = new System.Windows.Forms.GroupBox();
			this.labelV = new System.Windows.Forms.Label();
			this.labelS = new System.Windows.Forms.Label();
			this.labelH = new System.Windows.Forms.Label();
			this.groupBoxLAB = new System.Windows.Forms.GroupBox();
			this.labelB = new System.Windows.Forms.Label();
			this.labelA = new System.Windows.Forms.Label();
			this.labelL = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
			this.groupBoxSelectColor.SuspendLayout();
			this.groupBoxColorSystems.SuspendLayout();
			this.groupBoxRGBA.SuspendLayout();
			this.groupBoxCMYK.SuspendLayout();
			this.groupBoxXYZ.SuspendLayout();
			this.groupBoxHSV.SuspendLayout();
			this.groupBoxLAB.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxImage
			// 
			this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
			this.pictureBoxImage.Location = new System.Drawing.Point(13, 82);
			this.pictureBoxImage.Name = "pictureBoxImage";
			this.pictureBoxImage.Size = new System.Drawing.Size(426, 444);
			this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxImage.TabIndex = 0;
			this.pictureBoxImage.TabStop = false;
			this.pictureBoxImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBoxImage_MouseClick);
			// 
			// panelSelectColor
			// 
			this.panelSelectColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelSelectColor.Location = new System.Drawing.Point(10, 19);
			this.panelSelectColor.Name = "panelSelectColor";
			this.panelSelectColor.Size = new System.Drawing.Size(49, 44);
			this.panelSelectColor.TabIndex = 1;
			// 
			// groupBoxSelectColor
			// 
			this.groupBoxSelectColor.Controls.Add(this.panelSelectColor);
			this.groupBoxSelectColor.Location = new System.Drawing.Point(13, 7);
			this.groupBoxSelectColor.Name = "groupBoxSelectColor";
			this.groupBoxSelectColor.Size = new System.Drawing.Size(110, 69);
			this.groupBoxSelectColor.TabIndex = 2;
			this.groupBoxSelectColor.TabStop = false;
			this.groupBoxSelectColor.Text = "Выбранный цвет:";
			// 
			// groupBoxColorSystems
			// 
			this.groupBoxColorSystems.Controls.Add(this.groupBoxLAB);
			this.groupBoxColorSystems.Controls.Add(this.groupBoxHSV);
			this.groupBoxColorSystems.Controls.Add(this.groupBoxXYZ);
			this.groupBoxColorSystems.Controls.Add(this.groupBoxCMYK);
			this.groupBoxColorSystems.Location = new System.Drawing.Point(445, 82);
			this.groupBoxColorSystems.Name = "groupBoxColorSystems";
			this.groupBoxColorSystems.Size = new System.Drawing.Size(205, 444);
			this.groupBoxColorSystems.TabIndex = 3;
			this.groupBoxColorSystems.TabStop = false;
			this.groupBoxColorSystems.Text = "Цветовые системы:";
			// 
			// groupBoxRGBA
			// 
			this.groupBoxRGBA.Controls.Add(this.panelColorB);
			this.groupBoxRGBA.Controls.Add(this.panelColorG);
			this.groupBoxRGBA.Controls.Add(this.panelColorR);
			this.groupBoxRGBA.Controls.Add(this.labelColorPartB);
			this.groupBoxRGBA.Controls.Add(this.labelColorPartG);
			this.groupBoxRGBA.Controls.Add(this.labelColorPartR);
			this.groupBoxRGBA.Location = new System.Drawing.Point(129, 7);
			this.groupBoxRGBA.Name = "groupBoxRGBA";
			this.groupBoxRGBA.Size = new System.Drawing.Size(238, 69);
			this.groupBoxRGBA.TabIndex = 0;
			this.groupBoxRGBA.TabStop = false;
			this.groupBoxRGBA.Text = "RGBA:";
			// 
			// labelColorPartR
			// 
			this.labelColorPartR.AutoSize = true;
			this.labelColorPartR.Location = new System.Drawing.Point(6, 16);
			this.labelColorPartR.Name = "labelColorPartR";
			this.labelColorPartR.Size = new System.Drawing.Size(24, 13);
			this.labelColorPartR.TabIndex = 0;
			this.labelColorPartR.Text = "R =";
			// 
			// labelColorPartG
			// 
			this.labelColorPartG.AutoSize = true;
			this.labelColorPartG.Location = new System.Drawing.Point(75, 16);
			this.labelColorPartG.Name = "labelColorPartG";
			this.labelColorPartG.Size = new System.Drawing.Size(24, 13);
			this.labelColorPartG.TabIndex = 1;
			this.labelColorPartG.Text = "G =";
			// 
			// labelColorPartB
			// 
			this.labelColorPartB.AutoSize = true;
			this.labelColorPartB.Location = new System.Drawing.Point(149, 16);
			this.labelColorPartB.Name = "labelColorPartB";
			this.labelColorPartB.Size = new System.Drawing.Size(23, 13);
			this.labelColorPartB.TabIndex = 2;
			this.labelColorPartB.Text = "B =";
			// 
			// panelColorR
			// 
			this.panelColorR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelColorR.Location = new System.Drawing.Point(9, 32);
			this.panelColorR.Name = "panelColorR";
			this.panelColorR.Size = new System.Drawing.Size(25, 25);
			this.panelColorR.TabIndex = 3;
			// 
			// panelColorG
			// 
			this.panelColorG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelColorG.Location = new System.Drawing.Point(78, 32);
			this.panelColorG.Name = "panelColorG";
			this.panelColorG.Size = new System.Drawing.Size(25, 25);
			this.panelColorG.TabIndex = 4;
			// 
			// panelColorB
			// 
			this.panelColorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelColorB.Location = new System.Drawing.Point(152, 32);
			this.panelColorB.Name = "panelColorB";
			this.panelColorB.Size = new System.Drawing.Size(25, 25);
			this.panelColorB.TabIndex = 5;
			// 
			// groupBoxCMYK
			// 
			this.groupBoxCMYK.Controls.Add(this.labelK);
			this.groupBoxCMYK.Controls.Add(this.labelY);
			this.groupBoxCMYK.Controls.Add(this.labelM);
			this.groupBoxCMYK.Controls.Add(this.labelC);
			this.groupBoxCMYK.Location = new System.Drawing.Point(6, 19);
			this.groupBoxCMYK.Name = "groupBoxCMYK";
			this.groupBoxCMYK.Size = new System.Drawing.Size(189, 62);
			this.groupBoxCMYK.TabIndex = 0;
			this.groupBoxCMYK.TabStop = false;
			this.groupBoxCMYK.Text = "CMYK:";
			// 
			// labelC
			// 
			this.labelC.AutoSize = true;
			this.labelC.Location = new System.Drawing.Point(6, 16);
			this.labelC.Name = "labelC";
			this.labelC.Size = new System.Drawing.Size(26, 13);
			this.labelC.TabIndex = 0;
			this.labelC.Text = "C = ";
			// 
			// labelM
			// 
			this.labelM.AutoSize = true;
			this.labelM.Location = new System.Drawing.Point(93, 16);
			this.labelM.Name = "labelM";
			this.labelM.Size = new System.Drawing.Size(28, 13);
			this.labelM.TabIndex = 1;
			this.labelM.Text = "M = ";
			// 
			// labelY
			// 
			this.labelY.AutoSize = true;
			this.labelY.Location = new System.Drawing.Point(6, 37);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(26, 13);
			this.labelY.TabIndex = 0;
			this.labelY.Text = "Y = ";
			// 
			// labelK
			// 
			this.labelK.AutoSize = true;
			this.labelK.Location = new System.Drawing.Point(93, 37);
			this.labelK.Name = "labelK";
			this.labelK.Size = new System.Drawing.Size(26, 13);
			this.labelK.TabIndex = 1;
			this.labelK.Text = "K = ";
			// 
			// groupBoxXYZ
			// 
			this.groupBoxXYZ.Controls.Add(this.labelZ);
			this.groupBoxXYZ.Controls.Add(this.labelYY);
			this.groupBoxXYZ.Controls.Add(this.labelX);
			this.groupBoxXYZ.Location = new System.Drawing.Point(6, 87);
			this.groupBoxXYZ.Name = "groupBoxXYZ";
			this.groupBoxXYZ.Size = new System.Drawing.Size(189, 69);
			this.groupBoxXYZ.TabIndex = 1;
			this.groupBoxXYZ.TabStop = false;
			this.groupBoxXYZ.Text = "XYZ:";
			// 
			// labelZ
			// 
			this.labelZ.AutoSize = true;
			this.labelZ.Location = new System.Drawing.Point(7, 49);
			this.labelZ.Name = "labelZ";
			this.labelZ.Size = new System.Drawing.Size(26, 13);
			this.labelZ.TabIndex = 0;
			this.labelZ.Text = "Z = ";
			// 
			// labelYY
			// 
			this.labelYY.AutoSize = true;
			this.labelYY.Location = new System.Drawing.Point(6, 33);
			this.labelYY.Name = "labelYY";
			this.labelYY.Size = new System.Drawing.Size(26, 13);
			this.labelYY.TabIndex = 1;
			this.labelYY.Text = "Y = ";
			// 
			// labelX
			// 
			this.labelX.AutoSize = true;
			this.labelX.Location = new System.Drawing.Point(6, 16);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(26, 13);
			this.labelX.TabIndex = 0;
			this.labelX.Text = "X = ";
			// 
			// groupBoxHSV
			// 
			this.groupBoxHSV.Controls.Add(this.labelV);
			this.groupBoxHSV.Controls.Add(this.labelS);
			this.groupBoxHSV.Controls.Add(this.labelH);
			this.groupBoxHSV.Location = new System.Drawing.Point(6, 162);
			this.groupBoxHSV.Name = "groupBoxHSV";
			this.groupBoxHSV.Size = new System.Drawing.Size(189, 74);
			this.groupBoxHSV.TabIndex = 2;
			this.groupBoxHSV.TabStop = false;
			this.groupBoxHSV.Text = "HSV (HSB):";
			// 
			// labelV
			// 
			this.labelV.AutoSize = true;
			this.labelV.Location = new System.Drawing.Point(6, 51);
			this.labelV.Name = "labelV";
			this.labelV.Size = new System.Drawing.Size(23, 13);
			this.labelV.TabIndex = 0;
			this.labelV.Text = "V =";
			// 
			// labelS
			// 
			this.labelS.AutoSize = true;
			this.labelS.Location = new System.Drawing.Point(6, 33);
			this.labelS.Name = "labelS";
			this.labelS.Size = new System.Drawing.Size(26, 13);
			this.labelS.TabIndex = 1;
			this.labelS.Text = "S = ";
			// 
			// labelH
			// 
			this.labelH.AutoSize = true;
			this.labelH.Location = new System.Drawing.Point(6, 16);
			this.labelH.Name = "labelH";
			this.labelH.Size = new System.Drawing.Size(27, 13);
			this.labelH.TabIndex = 0;
			this.labelH.Text = "H = ";
			// 
			// groupBoxLAB
			// 
			this.groupBoxLAB.Controls.Add(this.labelB);
			this.groupBoxLAB.Controls.Add(this.labelA);
			this.groupBoxLAB.Controls.Add(this.labelL);
			this.groupBoxLAB.Location = new System.Drawing.Point(6, 242);
			this.groupBoxLAB.Name = "groupBoxLAB";
			this.groupBoxLAB.Size = new System.Drawing.Size(189, 74);
			this.groupBoxLAB.TabIndex = 3;
			this.groupBoxLAB.TabStop = false;
			this.groupBoxLAB.Text = "LAB:";
			// 
			// labelB
			// 
			this.labelB.AutoSize = true;
			this.labelB.Location = new System.Drawing.Point(6, 53);
			this.labelB.Name = "labelB";
			this.labelB.Size = new System.Drawing.Size(23, 13);
			this.labelB.TabIndex = 0;
			this.labelB.Text = "B =";
			// 
			// labelA
			// 
			this.labelA.AutoSize = true;
			this.labelA.Location = new System.Drawing.Point(6, 34);
			this.labelA.Name = "labelA";
			this.labelA.Size = new System.Drawing.Size(23, 13);
			this.labelA.TabIndex = 1;
			this.labelA.Text = "A =";
			// 
			// labelL
			// 
			this.labelL.AutoSize = true;
			this.labelL.Location = new System.Drawing.Point(6, 16);
			this.labelL.Name = "labelL";
			this.labelL.Size = new System.Drawing.Size(25, 13);
			this.labelL.TabIndex = 0;
			this.labelL.Text = "L = ";
			// 
			// Colors
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBoxRGBA);
			this.Controls.Add(this.groupBoxColorSystems);
			this.Controls.Add(this.groupBoxSelectColor);
			this.Controls.Add(this.pictureBoxImage);
			this.Name = "Colors";
			this.Size = new System.Drawing.Size(660, 543);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
			this.groupBoxSelectColor.ResumeLayout(false);
			this.groupBoxColorSystems.ResumeLayout(false);
			this.groupBoxRGBA.ResumeLayout(false);
			this.groupBoxRGBA.PerformLayout();
			this.groupBoxCMYK.ResumeLayout(false);
			this.groupBoxCMYK.PerformLayout();
			this.groupBoxXYZ.ResumeLayout(false);
			this.groupBoxXYZ.PerformLayout();
			this.groupBoxHSV.ResumeLayout(false);
			this.groupBoxHSV.PerformLayout();
			this.groupBoxLAB.ResumeLayout(false);
			this.groupBoxLAB.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxImage;
		private System.Windows.Forms.Panel panelSelectColor;
		private System.Windows.Forms.GroupBox groupBoxSelectColor;
		private System.Windows.Forms.GroupBox groupBoxColorSystems;
		private System.Windows.Forms.GroupBox groupBoxRGBA;
		private System.Windows.Forms.Label labelColorPartG;
		private System.Windows.Forms.Label labelColorPartR;
		private System.Windows.Forms.Label labelColorPartB;
		private System.Windows.Forms.Panel panelColorB;
		private System.Windows.Forms.Panel panelColorG;
		private System.Windows.Forms.Panel panelColorR;
		private System.Windows.Forms.GroupBox groupBoxCMYK;
		private System.Windows.Forms.Label labelM;
		private System.Windows.Forms.Label labelC;
		private System.Windows.Forms.Label labelK;
		private System.Windows.Forms.Label labelY;
		private System.Windows.Forms.GroupBox groupBoxXYZ;
		private System.Windows.Forms.Label labelZ;
		private System.Windows.Forms.Label labelYY;
		private System.Windows.Forms.Label labelX;
		private System.Windows.Forms.GroupBox groupBoxHSV;
		private System.Windows.Forms.Label labelV;
		private System.Windows.Forms.Label labelS;
		private System.Windows.Forms.Label labelH;
		private System.Windows.Forms.GroupBox groupBoxLAB;
		private System.Windows.Forms.Label labelB;
		private System.Windows.Forms.Label labelA;
		private System.Windows.Forms.Label labelL;
	}
}
