
namespace WindowsFormsAppUrupaBohdan
{
    partial class FormAddTermPaper
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
            this.dateTimePicker_deadline = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker_deadline
            // 
            this.dateTimePicker_deadline.Location = new System.Drawing.Point(67, 300);
            this.dateTimePicker_deadline.Name = "dateTimePicker_deadline";
            this.dateTimePicker_deadline.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker_deadline.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Дедлайн";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Опис курсової";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Назва курсової";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(11, 169);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(180, 125);
            this.textBox_description.TabIndex = 64;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(11, 25);
            this.textBox_title.Multiline = true;
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(181, 125);
            this.textBox_title.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(40, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 62;
            this.button1.Text = "Дотади курсову";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(13, 336);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(74, 13);
            this.labelMessage.TabIndex = 69;
            this.labelMessage.Text = "Введіть данні";
            // 
            // FormAddTermPaper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 411);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.dateTimePicker_deadline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.button1);
            this.Name = "FormAddTermPaper";
            this.Text = "FormAddTermPaper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker_deadline;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelMessage;
    }
}