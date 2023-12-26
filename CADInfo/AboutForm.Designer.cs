namespace CADInfo
{
    partial class AboutForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelShortTitle = new System.Windows.Forms.Label();
            this.labelFullTitle = new System.Windows.Forms.Label();
            this.labelVerstion = new System.Windows.Forms.Label();
            this.labelVersionText = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.labelGroupText = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonOk.Location = new System.Drawing.Point(138, 162);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(16, 126);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(43, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Емаил:";
            // 
            // linkLabelEmail
            // 
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Location = new System.Drawing.Point(97, 126);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(128, 13);
            this.linkLabelEmail.TabIndex = 2;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "dolgove4nyP@yandex.by";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(16, 12);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(60, 13);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Название:";
            // 
            // labelShortTitle
            // 
            this.labelShortTitle.AutoSize = true;
            this.labelShortTitle.Location = new System.Drawing.Point(97, 12);
            this.labelShortTitle.Name = "labelShortTitle";
            this.labelShortTitle.Size = new System.Drawing.Size(72, 13);
            this.labelShortTitle.TabIndex = 4;
            this.labelShortTitle.Text = "\"КИД Инфо\"";
            // 
            // labelFullTitle
            // 
            this.labelFullTitle.AutoSize = true;
            this.labelFullTitle.Location = new System.Drawing.Point(97, 34);
            this.labelFullTitle.Name = "labelFullTitle";
            this.labelFullTitle.Size = new System.Drawing.Size(241, 13);
            this.labelFullTitle.TabIndex = 5;
            this.labelFullTitle.Text = "\"Кодироваине и декодирование информации\"";
            // 
            // labelVerstion
            // 
            this.labelVerstion.AutoSize = true;
            this.labelVerstion.Location = new System.Drawing.Point(16, 57);
            this.labelVerstion.Name = "labelVerstion";
            this.labelVerstion.Size = new System.Drawing.Size(47, 13);
            this.labelVerstion.TabIndex = 6;
            this.labelVerstion.Text = "Версия:";
            // 
            // labelVersionText
            // 
            this.labelVersionText.AutoSize = true;
            this.labelVersionText.Location = new System.Drawing.Point(97, 57);
            this.labelVersionText.Name = "labelVersionText";
            this.labelVersionText.Size = new System.Drawing.Size(40, 13);
            this.labelVersionText.TabIndex = 7;
            this.labelVersionText.Text = "1.0.0.0";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(97, 79);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(111, 13);
            this.labelFullName.TabIndex = 9;
            this.labelFullName.Text = "Павел Долговечный";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Location = new System.Drawing.Point(16, 79);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(75, 13);
            this.labelDeveloper.TabIndex = 8;
            this.labelDeveloper.Text = "Разработчик:";
            // 
            // labelGroupText
            // 
            this.labelGroupText.AutoSize = true;
            this.labelGroupText.Location = new System.Drawing.Point(97, 102);
            this.labelGroupText.Name = "labelGroupText";
            this.labelGroupText.Size = new System.Drawing.Size(29, 13);
            this.labelGroupText.TabIndex = 10;
            this.labelGroupText.Text = "31-З";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(16, 102);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(45, 13);
            this.labelGroup.TabIndex = 11;
            this.labelGroup.Text = "Группа:";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonOk;
            this.ClientSize = new System.Drawing.Size(351, 194);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelGroupText);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelDeveloper);
            this.Controls.Add(this.labelVersionText);
            this.Controls.Add(this.labelVerstion);
            this.Controls.Add(this.labelFullTitle);
            this.Controls.Add(this.labelShortTitle);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.linkLabelEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelShortTitle;
        private System.Windows.Forms.Label labelFullTitle;
        private System.Windows.Forms.Label labelVerstion;
        private System.Windows.Forms.Label labelVersionText;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.Label labelGroupText;
        private System.Windows.Forms.Label labelGroup;
    }
}