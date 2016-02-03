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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.openFileData = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericLearningCount = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.labelTestCount = new System.Windows.Forms.Label();
            this.labelDataCount = new System.Windows.Forms.Label();
            this.labelLearningCount = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelR2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelB1 = new System.Windows.Forms.Label();
            this.labelB0 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupUnkown = new System.Windows.Forms.GroupBox();
            this.labelUnkownX = new System.Windows.Forms.Label();
            this.numericUnkownX = new System.Windows.Forms.NumericUpDown();
            this.labelUnkownY = new System.Windows.Forms.Label();
            this.numericUnkownY = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLearningCount)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupUnkown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnkownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnkownY)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileData
            // 
            this.openFileData.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupUnkown);
            this.panel1.Controls.Add(this.groupBoxData);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 406);
            this.panel1.TabIndex = 0;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.label4);
            this.groupBoxData.Controls.Add(this.numericLearningCount);
            this.groupBoxData.Controls.Add(this.drawButton);
            this.groupBoxData.Controls.Add(this.labelTestCount);
            this.groupBoxData.Controls.Add(this.labelDataCount);
            this.groupBoxData.Controls.Add(this.labelLearningCount);
            this.groupBoxData.Controls.Add(this.labelData);
            this.groupBoxData.Controls.Add(this.buttonLoadData);
            this.groupBoxData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(237, 197);
            this.groupBoxData.TabIndex = 8;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Dane";
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
            // numericLearningCount
            // 
            this.numericLearningCount.Enabled = false;
            this.numericLearningCount.Location = new System.Drawing.Point(143, 108);
            this.numericLearningCount.Name = "numericLearningCount";
            this.numericLearningCount.Size = new System.Drawing.Size(65, 20);
            this.numericLearningCount.TabIndex = 11;
            this.numericLearningCount.ValueChanged += new System.EventHandler(this.numericLearningCount_ValueChanged);
            // 
            // drawButton
            // 
            this.drawButton.Enabled = false;
            this.drawButton.Location = new System.Drawing.Point(6, 160);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(143, 23);
            this.drawButton.TabIndex = 4;
            this.drawButton.Text = "Oblicz i rysuj";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
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
            this.groupBox1.Controls.Add(this.labelR2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelB1);
            this.groupBox1.Controls.Add(this.labelB0);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Równanie regresji";
            // 
            // labelR2
            // 
            this.labelR2.AutoSize = true;
            this.labelR2.Location = new System.Drawing.Point(38, 97);
            this.labelR2.Name = "labelR2";
            this.labelR2.Size = new System.Drawing.Size(13, 13);
            this.labelR2.TabIndex = 8;
            this.labelR2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "R² =";
            // 
            // labelB1
            // 
            this.labelB1.AutoSize = true;
            this.labelB1.Location = new System.Drawing.Point(38, 74);
            this.labelB1.Name = "labelB1";
            this.labelB1.Size = new System.Drawing.Size(13, 13);
            this.labelB1.TabIndex = 6;
            this.labelB1.Text = "0";
            // 
            // labelB0
            // 
            this.labelB0.AutoSize = true;
            this.labelB0.Location = new System.Drawing.Point(38, 48);
            this.labelB0.Name = "labelB0";
            this.labelB0.Size = new System.Drawing.Size(13, 13);
            this.labelB0.TabIndex = 5;
            this.labelB0.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "β1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "β0 =";
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
            // mainChart
            // 
            chartArea5.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea5);
            this.mainChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.mainChart.Legends.Add(legend5);
            this.mainChart.Location = new System.Drawing.Point(249, 3);
            this.mainChart.Name = "mainChart";
            this.mainChart.Size = new System.Drawing.Size(530, 406);
            this.mainChart.TabIndex = 2;
            this.mainChart.Text = "chart1";
            title5.Name = "Zastosowanie regresji linowej do predykcji";
            this.mainChart.Titles.Add(title5);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.mainChart, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(782, 412);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // groupUnkown
            // 
            this.groupUnkown.Controls.Add(this.numericUnkownY);
            this.groupUnkown.Controls.Add(this.labelUnkownY);
            this.groupUnkown.Controls.Add(this.numericUnkownX);
            this.groupUnkown.Controls.Add(this.labelUnkownX);
            this.groupUnkown.Enabled = false;
            this.groupUnkown.Location = new System.Drawing.Point(3, 331);
            this.groupUnkown.Name = "groupUnkown";
            this.groupUnkown.Size = new System.Drawing.Size(237, 72);
            this.groupUnkown.TabIndex = 9;
            this.groupUnkown.TabStop = false;
            this.groupUnkown.Text = "Unkown";
            // 
            // labelUnkownX
            // 
            this.labelUnkownX.AutoSize = true;
            this.labelUnkownX.Location = new System.Drawing.Point(6, 19);
            this.labelUnkownX.Name = "labelUnkownX";
            this.labelUnkownX.Size = new System.Drawing.Size(57, 13);
            this.labelUnkownX.TabIndex = 1;
            this.labelUnkownX.Text = "Unkown X";
            // 
            // numericUnkownX
            // 
            this.numericUnkownX.DecimalPlaces = 4;
            this.numericUnkownX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUnkownX.Location = new System.Drawing.Point(69, 17);
            this.numericUnkownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUnkownX.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUnkownX.Name = "numericUnkownX";
            this.numericUnkownX.Size = new System.Drawing.Size(120, 20);
            this.numericUnkownX.TabIndex = 2;
            this.numericUnkownX.ValueChanged += new System.EventHandler(this.numericUnkownX_ValueChanged);
            // 
            // labelUnkownY
            // 
            this.labelUnkownY.AutoSize = true;
            this.labelUnkownY.Location = new System.Drawing.Point(6, 46);
            this.labelUnkownY.Name = "labelUnkownY";
            this.labelUnkownY.Size = new System.Drawing.Size(57, 13);
            this.labelUnkownY.TabIndex = 3;
            this.labelUnkownY.Text = "Unkown Y";
            // 
            // numericUnkownY
            // 
            this.numericUnkownY.DecimalPlaces = 4;
            this.numericUnkownY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUnkownY.Location = new System.Drawing.Point(69, 44);
            this.numericUnkownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUnkownY.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUnkownY.Name = "numericUnkownY";
            this.numericUnkownY.ReadOnly = true;
            this.numericUnkownY.Size = new System.Drawing.Size(120, 20);
            this.numericUnkownY.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 412);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Regresja liniowa";
            this.panel1.ResumeLayout(false);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLearningCount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupUnkown.ResumeLayout(false);
            this.groupUnkown.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnkownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUnkownY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericLearningCount;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label labelTestCount;
        private System.Windows.Forms.Label labelDataCount;
        private System.Windows.Forms.Label labelLearningCount;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelR2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelB1;
        private System.Windows.Forms.Label labelB0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupUnkown;
        private System.Windows.Forms.NumericUpDown numericUnkownX;
        private System.Windows.Forms.Label labelUnkownX;
        private System.Windows.Forms.NumericUpDown numericUnkownY;
        private System.Windows.Forms.Label labelUnkownY;
    }
}

