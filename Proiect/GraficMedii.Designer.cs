namespace Proiect
{
    partial class GraficMedii
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
            this.chrtMedii = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.chartStat2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnImprimare = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDensitate = new System.Windows.Forms.RadioButton();
            this.rdbMedie = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.chrtMedii)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtMedii
            // 
            this.chrtMedii.AllowDrop = true;
            chartArea1.Name = "ChartArea1";
            this.chrtMedii.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtMedii.Legends.Add(legend1);
            this.chrtMedii.Location = new System.Drawing.Point(51, 72);
            this.chrtMedii.Name = "chrtMedii";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtMedii.Series.Add(series1);
            this.chrtMedii.Size = new System.Drawing.Size(524, 406);
            this.chrtMedii.TabIndex = 0;
            this.chrtMedii.Text = "Situatie Medii";
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mediile Candidatilor";
            // 
            // chartStat2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStat2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStat2.Legends.Add(legend2);
            this.chartStat2.Location = new System.Drawing.Point(645, 72);
            this.chartStat2.Name = "chartStat2";
            this.chartStat2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartStat2.Series.Add(series2);
            this.chartStat2.Size = new System.Drawing.Size(525, 406);
            this.chartStat2.TabIndex = 2;
            this.chartStat2.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(642, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Densitate Medii";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(380, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(464, 40);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Statistică Medii";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(811, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Candidati";
            // 
            // btnImprimare
            // 
            this.btnImprimare.Location = new System.Drawing.Point(54, 118);
            this.btnImprimare.Name = "btnImprimare";
            this.btnImprimare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnImprimare.Size = new System.Drawing.Size(93, 34);
            this.btnImprimare.TabIndex = 7;
            this.btnImprimare.Text = "Imprimare";
            this.btnImprimare.UseVisualStyleBackColor = true;
            this.btnImprimare.Click += new System.EventHandler(this.btnImprimare_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDensitate);
            this.groupBox1.Controls.Add(this.rdbMedie);
            this.groupBox1.Controls.Add(this.btnImprimare);
            this.groupBox1.Location = new System.Drawing.Point(1195, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imprimare Grafic";
            // 
            // rdbDensitate
            // 
            this.rdbDensitate.AutoSize = true;
            this.rdbDensitate.Location = new System.Drawing.Point(54, 61);
            this.rdbDensitate.Name = "rdbDensitate";
            this.rdbDensitate.Size = new System.Drawing.Size(144, 20);
            this.rdbDensitate.TabIndex = 9;
            this.rdbDensitate.Text = "Densitatea Mediilor";
            this.rdbDensitate.UseVisualStyleBackColor = true;
            // 
            // rdbMedie
            // 
            this.rdbMedie.AutoSize = true;
            this.rdbMedie.Checked = true;
            this.rdbMedie.Location = new System.Drawing.Point(54, 34);
            this.rdbMedie.Name = "rdbMedie";
            this.rdbMedie.Size = new System.Drawing.Size(147, 20);
            this.rdbMedie.TabIndex = 8;
            this.rdbMedie.TabStop = true;
            this.rdbMedie.Text = "Mediile Candidatilor";
            this.rdbMedie.UseVisualStyleBackColor = true;
            // 
            // GraficMedii
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 574);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartStat2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrtMedii);
            this.Name = "GraficMedii";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chrtMedii)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStat2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtMedii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStat2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnImprimare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbDensitate;
        private System.Windows.Forms.RadioButton rdbMedie;
    }
}