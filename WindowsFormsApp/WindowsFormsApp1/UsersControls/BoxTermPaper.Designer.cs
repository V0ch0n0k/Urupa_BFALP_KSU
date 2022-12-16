
namespace WindowsFormsAppUrupaBohdan.UsersControls
{
    partial class BoxTermPaper
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
            this.buttonDeleteTermPaper = new System.Windows.Forms.Button();
            this.richTextBox_title = new System.Windows.Forms.RichTextBox();
            this.richTextBox_description = new System.Windows.Forms.RichTextBox();
            this.label_deadline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonDeleteTermPaper
            // 
            this.buttonDeleteTermPaper.AutoSize = true;
            this.buttonDeleteTermPaper.Location = new System.Drawing.Point(80, 148);
            this.buttonDeleteTermPaper.Name = "buttonDeleteTermPaper";
            this.buttonDeleteTermPaper.Size = new System.Drawing.Size(65, 23);
            this.buttonDeleteTermPaper.TabIndex = 13;
            this.buttonDeleteTermPaper.Text = "Видалити";
            this.buttonDeleteTermPaper.UseVisualStyleBackColor = true;
            this.buttonDeleteTermPaper.Click += new System.EventHandler(this.buttonDeleteTermPaper_Click);
            // 
            // richTextBox_title
            // 
            this.richTextBox_title.Location = new System.Drawing.Point(3, 3);
            this.richTextBox_title.Name = "richTextBox_title";
            this.richTextBox_title.Size = new System.Drawing.Size(244, 60);
            this.richTextBox_title.TabIndex = 14;
            this.richTextBox_title.Text = "";
            // 
            // richTextBox_description
            // 
            this.richTextBox_description.Location = new System.Drawing.Point(3, 69);
            this.richTextBox_description.Name = "richTextBox_description";
            this.richTextBox_description.Size = new System.Drawing.Size(244, 60);
            this.richTextBox_description.TabIndex = 15;
            this.richTextBox_description.Text = "";
            // 
            // label_deadline
            // 
            this.label_deadline.AutoSize = true;
            this.label_deadline.Location = new System.Drawing.Point(3, 132);
            this.label_deadline.Name = "label_deadline";
            this.label_deadline.Size = new System.Drawing.Size(61, 13);
            this.label_deadline.TabIndex = 16;
            this.label_deadline.Text = "_Deadline_";
            // 
            // BoxTermPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_deadline);
            this.Controls.Add(this.richTextBox_description);
            this.Controls.Add(this.richTextBox_title);
            this.Controls.Add(this.buttonDeleteTermPaper);
            this.Name = "BoxTermPaper";
            this.Size = new System.Drawing.Size(250, 173);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDeleteTermPaper;
        private System.Windows.Forms.RichTextBox richTextBox_title;
        private System.Windows.Forms.RichTextBox richTextBox_description;
        private System.Windows.Forms.Label label_deadline;
    }
}
