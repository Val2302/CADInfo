namespace CADInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.CaesarCypherPage = new System.Windows.Forms.TabPage();
            this.MorzeCodePage = new System.Windows.Forms.TabPage();
            this.NumbersPage = new System.Windows.Forms.TabPage();
            this.StringsPage = new System.Windows.Forms.TabPage();
            this.ColorPage = new System.Windows.Forms.TabPage();
            this.CodesPage = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.contentDataGrid = new System.Windows.Forms.DataGridView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.ContentColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.CaesarCypherPage);
            this.tabControl.Controls.Add(this.MorzeCodePage);
            this.tabControl.Controls.Add(this.NumbersPage);
            this.tabControl.Controls.Add(this.StringsPage);
            this.tabControl.Controls.Add(this.ColorPage);
            this.tabControl.Controls.Add(this.CodesPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(725, 621);
            this.tabControl.TabIndex = 0;
            // 
            // CaesarCypherPage
            // 
            this.CaesarCypherPage.Location = new System.Drawing.Point(4, 22);
            this.CaesarCypherPage.Name = "CaesarCypherPage";
            this.CaesarCypherPage.Padding = new System.Windows.Forms.Padding(3);
            this.CaesarCypherPage.Size = new System.Drawing.Size(717, 595);
            this.CaesarCypherPage.TabIndex = 0;
            this.CaesarCypherPage.Text = "1. Шифр Цезаря";
            this.CaesarCypherPage.UseVisualStyleBackColor = true;
            // 
            // MorzeCodePage
            // 
            this.MorzeCodePage.Location = new System.Drawing.Point(4, 22);
            this.MorzeCodePage.Name = "MorzeCodePage";
            this.MorzeCodePage.Padding = new System.Windows.Forms.Padding(3);
            this.MorzeCodePage.Size = new System.Drawing.Size(717, 595);
            this.MorzeCodePage.TabIndex = 1;
            this.MorzeCodePage.Text = "2. Азбука Морзе";
            this.MorzeCodePage.UseVisualStyleBackColor = true;
            // 
            // NumbersPage
            // 
            this.NumbersPage.Location = new System.Drawing.Point(4, 22);
            this.NumbersPage.Name = "NumbersPage";
            this.NumbersPage.Padding = new System.Windows.Forms.Padding(3);
            this.NumbersPage.Size = new System.Drawing.Size(717, 595);
            this.NumbersPage.TabIndex = 2;
            this.NumbersPage.Text = "3. Числа";
            this.NumbersPage.UseVisualStyleBackColor = true;
            // 
            // StringsPage
            // 
            this.StringsPage.Location = new System.Drawing.Point(4, 22);
            this.StringsPage.Name = "StringsPage";
            this.StringsPage.Padding = new System.Windows.Forms.Padding(3);
            this.StringsPage.Size = new System.Drawing.Size(717, 595);
            this.StringsPage.TabIndex = 3;
            this.StringsPage.Text = "4. Строки";
            this.StringsPage.UseVisualStyleBackColor = true;
            // 
            // ColorPage
            // 
            this.ColorPage.Location = new System.Drawing.Point(4, 22);
            this.ColorPage.Name = "ColorPage";
            this.ColorPage.Padding = new System.Windows.Forms.Padding(3);
            this.ColorPage.Size = new System.Drawing.Size(717, 595);
            this.ColorPage.TabIndex = 4;
            this.ColorPage.Text = "5. Цвета";
            this.ColorPage.UseVisualStyleBackColor = true;
            // 
            // CodesPage
            // 
            this.CodesPage.Location = new System.Drawing.Point(4, 22);
            this.CodesPage.Name = "CodesPage";
            this.CodesPage.Padding = new System.Windows.Forms.Padding(3);
            this.CodesPage.Size = new System.Drawing.Size(717, 595);
            this.CodesPage.TabIndex = 5;
            this.CodesPage.Text = "6. Код Грея";
            this.CodesPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.contentDataGrid);
            this.splitContainer.Panel1.Controls.Add(this.labelTitle);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(895, 625);
            this.splitContainer.SplitterDistance = 165;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 1;
            // 
            // contentDataGrid
            // 
            this.contentDataGrid.AllowUserToAddRows = false;
            this.contentDataGrid.AllowUserToDeleteRows = false;
            this.contentDataGrid.AllowUserToResizeColumns = false;
            this.contentDataGrid.AllowUserToResizeRows = false;
            this.contentDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contentDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.contentDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.contentDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.contentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contentDataGrid.ColumnHeadersVisible = false;
            this.contentDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContentColumn});
            this.contentDataGrid.Location = new System.Drawing.Point(15, 35);
            this.contentDataGrid.Name = "contentDataGrid";
            this.contentDataGrid.ReadOnly = true;
            this.contentDataGrid.RowHeadersVisible = false;
            this.contentDataGrid.ShowCellErrors = false;
            this.contentDataGrid.ShowCellToolTips = false;
            this.contentDataGrid.ShowEditingIcon = false;
            this.contentDataGrid.ShowRowErrors = false;
            this.contentDataGrid.Size = new System.Drawing.Size(143, 574);
            this.contentDataGrid.TabIndex = 1;
            this.contentDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ContentDataGrid_CellClick);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(10, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(148, 25);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Содержание";
            // 
            // ContentColumn
            // 
            this.ContentColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ContentColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.ContentColumn.Frozen = true;
            this.ContentColumn.HeaderText = "Содержание";
            this.ContentColumn.Name = "ContentColumn";
            this.ContentColumn.ReadOnly = true;
            this.ContentColumn.Width = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 625);
            this.Controls.Add(this.splitContainer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "КИД Инфо";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage MorzeCodePage;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView contentDataGrid;
		private System.Windows.Forms.TabPage CaesarCypherPage;
		private System.Windows.Forms.TabPage NumbersPage;
		private System.Windows.Forms.TabPage StringsPage;
		private System.Windows.Forms.TabPage ColorPage;
		private System.Windows.Forms.TabPage CodesPage;
        private System.Windows.Forms.DataGridViewButtonColumn ContentColumn;
    }
}

