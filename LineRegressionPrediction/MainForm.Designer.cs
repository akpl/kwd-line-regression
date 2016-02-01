namespace LineRegressionPrediction
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.numericLearningCount = new System.Windows.Forms.NumericUpDown();
            this.labelTestCount = new System.Windows.Forms.Label();
            this.labelDataCount = new System.Windows.Forms.Label();
            this.labelLearningCount = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.beta1Field = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.beta0Field = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.drawButton = new System.Windows.Forms.Button();
            this.openFileData = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLearningCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beta1Field)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beta0Field)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.55738F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.44262F));
            this.tableLayoutPanel1.Controls.Add(this.mainChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 326);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // mainChart
            // 
            chartArea1.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea1);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.mainChart.Legends.Add(legend1);
            this.mainChart.Location = new System.Drawing.Point(249, 3);
            this.mainChart.Name = "mainChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.mainChart.Series.Add(series1);
            this.mainChart.Size = new System.Drawing.Size(530, 320);
            this.mainChart.TabIndex = 2;
            this.mainChart.Text = "chart1";
            title1.Name = "Zastosowanie regresji linowej do predykcji";
            this.mainChart.Titles.Add(title1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxData);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 320);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.label4);
            this.groupBoxData.Controls.Add(this.numericLearningCount);
            this.groupBoxData.Controls.Add(this.labelTestCount);
            this.groupBoxData.Controls.Add(this.labelDataCount);
            this.groupBoxData.Controls.Add(this.labelLearningCount);
            this.groupBoxData.Controls.Add(this.labelData);
            this.groupBoxData.Controls.Add(this.buttonLoadData);
            this.groupBoxData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(237, 156);
            this.groupBoxData.TabIndex = 8;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Dane";
            // 
            // numericLearningCount
            // 
            this.numericLearningCount.Location = new System.Drawing.Point(143, 108);
            this.numericLearningCount.Name = "numericLearningCount";
            this.numericLearningCount.Size = new System.Drawing.Size(65, 20);
            this.numericLearningCount.TabIndex = 11;
            this.numericLearningCount.ValueChanged += new System.EventHandler(this.numericLearningCount_ValueChanged);
            // 
            // labelTestCount
            // 
            this.labelTestCount.AutoSize = true;
            this.labelTestCount.Location = new System.Drawing.Point(6, 133);
            this.labelTestCount.Name = "labelTestCount";
            this.labelTestCount.Size = new System.Drawing.Size(144, 13);
            this.labelTestCount.TabIndex = 10;
            this.labelTestCount.Text = "Liczba w zbiorze testowym: 0";
            // 
            // labelDataCount
            // 
            this.labelDataCount.AutoSize = true;
            this.labelDataCount.Location = new System.Drawing.Point(6, 88);
            this.labelDataCount.Name = "labelDataCount";
            this.labelDataCount.Size = new System.Drawing.Size(88, 13);
            this.labelDataCount.TabIndex = 9;
            this.labelDataCount.Text = "Liczba danych: 0";
            // 
            // labelLearningCount
            // 
            this.labelLearningCount.AutoSize = true;
            this.labelLearningCount.Location = new System.Drawing.Point(6, 110);
            this.labelLearningCount.Name = "labelLearningCount";
            this.labelLearningCount.Size = new System.Drawing.Size(130, 13);
            this.labelLearningCount.TabIndex = 8;
            this.labelLearningCount.Text = "Liczba w zbiorze uczącym";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(6, 67);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(72, 13);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Wczytaj dane";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(84, 62);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(65, 23);
            this.buttonLoadData.TabIndex = 7;
            this.buttonLoadData.Text = "Przeglądaj";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.beta1Field);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.beta0Field);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Równanie regresji";
            // 
            // beta1Field
            // 
            this.beta1Field.DecimalPlaces = 3;
            this.beta1Field.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.beta1Field.Location = new System.Drawing.Point(59, 72);
            this.beta1Field.Name = "beta1Field";
            this.beta1Field.Size = new System.Drawing.Size(65, 20);
            this.beta1Field.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "β1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "β0";
            // 
            // beta0Field
            // 
            this.beta0Field.DecimalPlaces = 3;
            this.beta0Field.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.beta0Field.Location = new System.Drawing.Point(59, 46);
            this.beta0Field.Name = "beta0Field";
            this.beta0Field.Size = new System.Drawing.Size(65, 20);
            this.beta0Field.TabIndex = 2;
            this.beta0Field.Value = new decimal(new int[] {
            54,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Y = β0 + β1X";
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(9, 281);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(75, 23);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Rysuj";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // openFileData
            // 
            this.openFileData.FileName = "openFileDialog1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Format pliku: \r\nPlik CSV, kolumny oddzielone \';\'\r\nczęść dziesiętna oddzielona \',\'" +
    "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 326);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Regresja liniowa";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLearningCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beta1Field)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beta0Field)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown beta1Field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown beta0Field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.OpenFileDialog openFileData;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.NumericUpDown numericLearningCount;
        private System.Windows.Forms.Label labelTestCount;
        private System.Windows.Forms.Label labelDataCount;
        private System.Windows.Forms.Label labelLearningCount;
        private System.Windows.Forms.Label label4;
    }
}

