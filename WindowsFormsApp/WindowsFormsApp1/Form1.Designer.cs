
namespace WindowsFormsAppUrupaBohdan
{
    partial class Form1
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
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.flowLayoutPanelPeople = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAddPeople = new System.Windows.Forms.Panel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.buttonTabularData = new System.Windows.Forms.Button();
            this.buttonTeachers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.AutoSize = true;
            this.buttonAddTeacher.Location = new System.Drawing.Point(12, 12);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(98, 23);
            this.buttonAddTeacher.TabIndex = 4;
            this.buttonAddTeacher.Text = "Додати вчителя";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // flowLayoutPanelPeople
            // 
            this.flowLayoutPanelPeople.AutoScroll = true;
            this.flowLayoutPanelPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelPeople.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanelPeople.Name = "flowLayoutPanelPeople";
            this.flowLayoutPanelPeople.Size = new System.Drawing.Size(275, 440);
            this.flowLayoutPanelPeople.TabIndex = 6;
            this.flowLayoutPanelPeople.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelPeople_Paint);
            // 
            // panelAddPeople
            // 
            this.panelAddPeople.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAddPeople.Location = new System.Drawing.Point(298, 41);
            this.panelAddPeople.Name = "panelAddPeople";
            this.panelAddPeople.Size = new System.Drawing.Size(220, 440);
            this.panelAddPeople.TabIndex = 7;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.AutoSize = true;
            this.buttonGenerate.Location = new System.Drawing.Point(116, 12);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(81, 23);
            this.buttonGenerate.TabIndex = 8;
            this.buttonGenerate.Text = "Згенерувати";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // buttonTabularData
            // 
            this.buttonTabularData.AutoSize = true;
            this.buttonTabularData.Location = new System.Drawing.Point(12, 487);
            this.buttonTabularData.Name = "buttonTabularData";
            this.buttonTabularData.Size = new System.Drawing.Size(118, 23);
            this.buttonTabularData.TabIndex = 9;
            this.buttonTabularData.Text = "Більш обширні данні";
            this.buttonTabularData.UseVisualStyleBackColor = true;
            this.buttonTabularData.Click += new System.EventHandler(this.buttonTabularData_Click);
            // 
            // buttonTeachers
            // 
            this.buttonTeachers.AutoSize = true;
            this.buttonTeachers.Location = new System.Drawing.Point(203, 12);
            this.buttonTeachers.Name = "buttonTeachers";
            this.buttonTeachers.Size = new System.Drawing.Size(84, 23);
            this.buttonTeachers.TabIndex = 10;
            this.buttonTeachers.Text = "Вчителі";
            this.buttonTeachers.UseVisualStyleBackColor = true;
            this.buttonTeachers.Click += new System.EventHandler(this.buttonTeachers_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(527, 517);
            this.Controls.Add(this.buttonTeachers);
            this.Controls.Add(this.buttonTabularData);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.panelAddPeople);
            this.Controls.Add(this.flowLayoutPanelPeople);
            this.Controls.Add(this.buttonAddTeacher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPeople;
        private System.Windows.Forms.Panel panelAddPeople;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Button buttonTabularData;
        private System.Windows.Forms.Button buttonTeachers;
    }
}

