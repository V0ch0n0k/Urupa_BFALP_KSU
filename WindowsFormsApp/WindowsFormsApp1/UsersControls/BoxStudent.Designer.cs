
namespace WindowsFormsAppUrupaBohdan.UsersControls
{
    partial class BoxStudent
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelAmountTermPaper = new System.Windows.Forms.Label();
            this.buttonTermPaper = new System.Windows.Forms.Button();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.labelSurnameStudent = new System.Windows.Forms.Label();
            this.labelNameStudent = new System.Windows.Forms.Label();
            this.buttonAddTermPaper = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAmountTermPaper
            // 
            this.labelAmountTermPaper.AutoSize = true;
            this.labelAmountTermPaper.Location = new System.Drawing.Point(71, 50);
            this.labelAmountTermPaper.Name = "labelAmountTermPaper";
            this.labelAmountTermPaper.Size = new System.Drawing.Size(107, 13);
            this.labelAmountTermPaper.TabIndex = 14;
            this.labelAmountTermPaper.Text = "_AmountTermPaper_";
            // 
            // buttonTermPaper
            // 
            this.buttonTermPaper.AutoSize = true;
            this.buttonTermPaper.Location = new System.Drawing.Point(183, 73);
            this.buttonTermPaper.Name = "buttonTermPaper";
            this.buttonTermPaper.Size = new System.Drawing.Size(55, 23);
            this.buttonTermPaper.TabIndex = 13;
            this.buttonTermPaper.Text = "Курсові";
            this.buttonTermPaper.UseVisualStyleBackColor = true;
            this.buttonTermPaper.Click += new System.EventHandler(this.buttonTermPaper_Click);
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.AutoSize = true;
            this.buttonDeleteStudent.Location = new System.Drawing.Point(3, 73);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(65, 23);
            this.buttonDeleteStudent.TabIndex = 12;
            this.buttonDeleteStudent.Text = "Видалити";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // labelSurnameStudent
            // 
            this.labelSurnameStudent.AutoSize = true;
            this.labelSurnameStudent.Location = new System.Drawing.Point(69, 16);
            this.labelSurnameStudent.Name = "labelSurnameStudent";
            this.labelSurnameStudent.Size = new System.Drawing.Size(98, 13);
            this.labelSurnameStudent.TabIndex = 11;
            this.labelSurnameStudent.Text = "_SurnameStudent_";
            // 
            // labelNameStudent
            // 
            this.labelNameStudent.AutoSize = true;
            this.labelNameStudent.Location = new System.Drawing.Point(69, 3);
            this.labelNameStudent.Name = "labelNameStudent";
            this.labelNameStudent.Size = new System.Drawing.Size(84, 13);
            this.labelNameStudent.TabIndex = 10;
            this.labelNameStudent.Text = "_NameStudent_";
            // 
            // buttonAddTermPaper
            // 
            this.buttonAddTermPaper.AutoSize = true;
            this.buttonAddTermPaper.Location = new System.Drawing.Point(74, 73);
            this.buttonAddTermPaper.Name = "buttonAddTermPaper";
            this.buttonAddTermPaper.Size = new System.Drawing.Size(103, 23);
            this.buttonAddTermPaper.TabIndex = 9;
            this.buttonAddTermPaper.Text = "Додати курсову";
            this.buttonAddTermPaper.UseVisualStyleBackColor = true;
            this.buttonAddTermPaper.Click += new System.EventHandler(this.buttonAddTermPaper_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // BoxStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelAmountTermPaper);
            this.Controls.Add(this.buttonTermPaper);
            this.Controls.Add(this.buttonDeleteStudent);
            this.Controls.Add(this.labelSurnameStudent);
            this.Controls.Add(this.labelNameStudent);
            this.Controls.Add(this.buttonAddTermPaper);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BoxStudent";
            this.Size = new System.Drawing.Size(250, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAmountTermPaper;
        private System.Windows.Forms.Button buttonTermPaper;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Label labelSurnameStudent;
        private System.Windows.Forms.Label labelNameStudent;
        private System.Windows.Forms.Button buttonAddTermPaper;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
