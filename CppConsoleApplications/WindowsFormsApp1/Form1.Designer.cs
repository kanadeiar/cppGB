namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.checkBoxWindow = new System.Windows.Forms.CheckBox();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.checkBoxWindow);
            this.panelTop.Controls.Add(this.buttonOpenFile);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(562, 46);
            this.panelTop.TabIndex = 0;
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(103, 23);
            this.buttonOpenFile.TabIndex = 0;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // checkBoxWindow
            // 
            this.checkBoxWindow.AutoSize = true;
            this.checkBoxWindow.Location = new System.Drawing.Point(130, 16);
            this.checkBoxWindow.Name = "checkBoxWindow";
            this.checkBoxWindow.Size = new System.Drawing.Size(122, 17);
            this.checkBoxWindow.TabIndex = 1;
            this.checkBoxWindow.Text = "По размерам окна";
            this.checkBoxWindow.UseVisualStyleBackColor = true;
            this.checkBoxWindow.CheckedChanged += new System.EventHandler(this.checkBoxWindow_CheckedChanged);
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImg.Location = new System.Drawing.Point(0, 46);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(562, 288);
            this.pictureBoxImg.TabIndex = 1;
            this.pictureBoxImg.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "\"Файлы с рисунками|*.jpg;*.jpeg;*.gif;*.bmp\"";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 334);
            this.Controls.Add(this.pictureBoxImg);
            this.Controls.Add(this.panelTop);
            this.Name = "FormMain";
            this.Text = "Просмотр рисунков";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.CheckBox checkBoxWindow;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

