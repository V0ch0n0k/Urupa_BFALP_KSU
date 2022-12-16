
namespace WindowsFormsAppUrupaBohdan.UsersControls
{
    partial class BoxTeacher
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.labelNameTeach = new System.Windows.Forms.Label();
            this.labelSurnameTeach = new System.Windows.Forms.Label();
            this.buttonDeleteTeacher = new System.Windows.Forms.Button();
            this.buttonShowMyStudents = new System.Windows.Forms.Button();
            this.labelAmountStudents = new System.Windows.Forms.Label();
            this.labelDiscipline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.AutoSize = true;
            this.buttonAddStudent.Location = new System.Drawing.Point(74, 73);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(103, 23);
            this.buttonAddStudent.TabIndex = 2;
            this.buttonAddStudent.Text = "Додати студента";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // labelNameTeach
            // 
            this.labelNameTeach.AutoSize = true;
            this.labelNameTeach.Location = new System.Drawing.Point(69, 3);
            this.labelNameTeach.Name = "labelNameTeach";
            this.labelNameTeach.Size = new System.Drawing.Size(78, 13);
            this.labelNameTeach.TabIndex = 3;
            this.labelNameTeach.Text = "_NameTeach_";
            // 
            // labelSurnameTeach
            // 
            this.labelSurnameTeach.AutoSize = true;
            this.labelSurnameTeach.Location = new System.Drawing.Point(69, 16);
            this.labelSurnameTeach.Name = "labelSurnameTeach";
            this.labelSurnameTeach.Size = new System.Drawing.Size(92, 13);
            this.labelSurnameTeach.TabIndex = 4;
            this.labelSurnameTeach.Text = "_SurnameTeach_";
            // 
            // buttonDeleteTeacher
            // 
            this.buttonDeleteTeacher.AutoSize = true;
            this.buttonDeleteTeacher.Location = new System.Drawing.Point(3, 73);
            this.buttonDeleteTeacher.Name = "buttonDeleteTeacher";
            this.buttonDeleteTeacher.Size = new System.Drawing.Size(65, 23);
            this.buttonDeleteTeacher.TabIndex = 5;
            this.buttonDeleteTeacher.Text = "Видалити";
            this.buttonDeleteTeacher.UseVisualStyleBackColor = true;
            this.buttonDeleteTeacher.Click += new System.EventHandler(this.buttonDeleteTeacher_Click);
            // 
            // buttonShowMyStudents
            // 
            this.buttonShowMyStudents.AutoSize = true;
            this.buttonShowMyStudents.Location = new System.Drawing.Point(183, 74);
            this.buttonShowMyStudents.Name = "buttonShowMyStudents";
            this.buttonShowMyStudents.Size = new System.Drawing.Size(63, 23);
            this.buttonShowMyStudents.TabIndex = 6;
            this.buttonShowMyStudents.Text = "Студенти";
            this.buttonShowMyStudents.UseVisualStyleBackColor = true;
            this.buttonShowMyStudents.Click += new System.EventHandler(this.buttonShowMyStudents_Click);
            // 
            // labelAmountStudents
            // 
            this.labelAmountStudents.AutoSize = true;
            this.labelAmountStudents.Location = new System.Drawing.Point(71, 50);
            this.labelAmountStudents.Name = "labelAmountStudents";
            this.labelAmountStudents.Size = new System.Drawing.Size(97, 13);
            this.labelAmountStudents.TabIndex = 7;
            this.labelAmountStudents.Text = "_AmountStudents_";
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(69, 29);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(64, 13);
            this.labelDiscipline.TabIndex = 8;
            this.labelDiscipline.Text = "_Discipline_";
            // 
            // BoxTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.labelAmountStudents);
            this.Controls.Add(this.buttonShowMyStudents);
            this.Controls.Add(this.buttonDeleteTeacher);
            this.Controls.Add(this.labelSurnameTeach);
            this.Controls.Add(this.labelNameTeach);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BoxTeacher";
            this.Size = new System.Drawing.Size(250, 100);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label labelNameTeach;
        private System.Windows.Forms.Label labelSurnameTeach;
        private System.Windows.Forms.Button buttonDeleteTeacher;
        private System.Windows.Forms.Button buttonShowMyStudents;
        private System.Windows.Forms.Label labelAmountStudents;
        private System.Windows.Forms.Label labelDiscipline;
    }
}
