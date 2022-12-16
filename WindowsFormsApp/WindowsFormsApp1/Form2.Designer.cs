
namespace WindowsFormsAppUrupaBohdan
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.treeView_tree = new System.Windows.Forms.TreeView();
            this.chartTeacher = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.dataGridViewStudent = new System.Windows.Forms.DataGridView();
            this.chartStudent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView_tree
            // 
            this.treeView_tree.Location = new System.Drawing.Point(6, 6);
            this.treeView_tree.Name = "treeView_tree";
            this.treeView_tree.Size = new System.Drawing.Size(166, 407);
            this.treeView_tree.TabIndex = 5;
            // 
            // chartTeacher
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTeacher.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTeacher.Legends.Add(legend1);
            this.chartTeacher.Location = new System.Drawing.Point(739, 6);
            this.chartTeacher.Name = "chartTeacher";
            this.chartTeacher.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Student";
            this.chartTeacher.Series.Add(series1);
            this.chartTeacher.Size = new System.Drawing.Size(341, 200);
            this.chartTeacher.TabIndex = 4;
            this.chartTeacher.Text = "chart1";
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(178, 6);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.Size = new System.Drawing.Size(555, 200);
            this.dataGridViewTeacher.TabIndex = 6;
            // 
            // dataGridViewStudent
            // 
            this.dataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudent.Location = new System.Drawing.Point(178, 213);
            this.dataGridViewStudent.Name = "dataGridViewStudent";
            this.dataGridViewStudent.Size = new System.Drawing.Size(555, 200);
            this.dataGridViewStudent.TabIndex = 8;
            // 
            // chartStudent
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStudent.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStudent.Legends.Add(legend2);
            this.chartStudent.Location = new System.Drawing.Point(739, 211);
            this.chartStudent.Name = "chartStudent";
            this.chartStudent.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "TermPaper";
            this.chartStudent.Series.Add(series2);
            this.chartStudent.Size = new System.Drawing.Size(341, 202);
            this.chartStudent.TabIndex = 9;
            this.chartStudent.Text = "chart2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 419);
            this.Controls.Add(this.chartStudent);
            this.Controls.Add(this.dataGridViewStudent);
            this.Controls.Add(this.dataGridViewTeacher);
            this.Controls.Add(this.treeView_tree);
            this.Controls.Add(this.chartTeacher);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chartTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_tree;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTeacher;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.DataGridView dataGridViewStudent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudent;
    }
}