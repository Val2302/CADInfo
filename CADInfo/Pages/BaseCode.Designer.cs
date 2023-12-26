namespace CADInfo.Pages
{
    partial class BaseCode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseCode));
            this.toolStripCC = new System.Windows.Forms.ToolStrip();
            this.ButtonCrypt = new System.Windows.Forms.ToolStripButton();
            this.stripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtoncEncrypt = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButtonCear = new System.Windows.Forms.ToolStripButton();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.toolStripCC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
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
            this.ButtonCear});
            this.toolStripCC.Location = new System.Drawing.Point(0, 0);
            this.toolStripCC.Name = "toolStripCC";
            this.toolStripCC.Size = new System.Drawing.Size(636, 25);
            this.toolStripCC.TabIndex = 1;
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
            // ButtonCear
            // 
            this.ButtonCear.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCear.Image")));
            this.ButtonCear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButtonCear.Name = "ButtonCear";
            this.ButtonCear.Size = new System.Drawing.Size(79, 22);
            this.ButtonCear.Text = "Очистить";
            this.ButtonCear.Click += new System.EventHandler(this.ButtonCear_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(0, 21);
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
            this.splitContainer.Size = new System.Drawing.Size(636, 543);
            this.splitContainer.SplitterDistance = 263;
            this.splitContainer.TabIndex = 7;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.textBoxInput);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(636, 263);
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
            this.textBoxInput.Size = new System.Drawing.Size(624, 238);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "Манило море";
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.textBoxOutput);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(636, 276);
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
            this.textBoxOutput.Size = new System.Drawing.Size(624, 251);
            this.textBoxOutput.TabIndex = 1;
            // 
            // BaseCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.toolStripCC);
            this.Name = "BaseCode";
            this.Size = new System.Drawing.Size(636, 564);
            this.toolStripCC.ResumeLayout(false);
            this.toolStripCC.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripCC;
        private System.Windows.Forms.ToolStripButton ButtonCrypt;
        private System.Windows.Forms.ToolStripSeparator stripSeparator1;
        private System.Windows.Forms.ToolStripButton ButtoncEncrypt;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ButtonCear;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TextBox textBoxOutput;
    }
}
