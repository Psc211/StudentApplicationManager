namespace Proiect
{
    partial class FormularEvaluareCandidati
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
            this.btnEvalueazaCand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSpecializari = new System.Windows.Forms.DataGridView();
            this.lbCandidatiAdmisi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSimpla = new System.Windows.Forms.RadioButton();
            this.rbPonderata = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecializari)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEvalueazaCand
            // 
            this.btnEvalueazaCand.Location = new System.Drawing.Point(39, 103);
            this.btnEvalueazaCand.Name = "btnEvalueazaCand";
            this.btnEvalueazaCand.Size = new System.Drawing.Size(122, 37);
            this.btnEvalueazaCand.TabIndex = 1;
            this.btnEvalueazaCand.Text = "Evalueaza Candidati";
            this.btnEvalueazaCand.UseVisualStyleBackColor = true;
            this.btnEvalueazaCand.Click += new System.EventHandler(this.btnEvalueazaCand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Specializari Posibile";
            // 
            // dgvSpecializari
            // 
            this.dgvSpecializari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecializari.Location = new System.Drawing.Point(37, 69);
            this.dgvSpecializari.Name = "dgvSpecializari";
            this.dgvSpecializari.RowHeadersWidth = 51;
            this.dgvSpecializari.RowTemplate.Height = 24;
            this.dgvSpecializari.Size = new System.Drawing.Size(346, 148);
            this.dgvSpecializari.TabIndex = 3;
            this.dgvSpecializari.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSpecializari_RowHeaderMouseClick);
            // 
            // lbCandidatiAdmisi
            // 
            this.lbCandidatiAdmisi.FormattingEnabled = true;
            this.lbCandidatiAdmisi.ItemHeight = 16;
            this.lbCandidatiAdmisi.Location = new System.Drawing.Point(495, 69);
            this.lbCandidatiAdmisi.Name = "lbCandidatiAdmisi";
            this.lbCandidatiAdmisi.Size = new System.Drawing.Size(451, 372);
            this.lbCandidatiAdmisi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(492, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Candidati admisi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPonderata);
            this.groupBox1.Controls.Add(this.rbSimpla);
            this.groupBox1.Controls.Add(this.btnEvalueazaCand);
            this.groupBox1.Location = new System.Drawing.Point(37, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 140);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alegere Metoda Admitere";
            // 
            // rbSimpla
            // 
            this.rbSimpla.AutoSize = true;
            this.rbSimpla.Checked = true;
            this.rbSimpla.Location = new System.Drawing.Point(39, 34);
            this.rbSimpla.Name = "rbSimpla";
            this.rbSimpla.Size = new System.Drawing.Size(111, 20);
            this.rbSimpla.TabIndex = 2;
            this.rbSimpla.TabStop = true;
            this.rbSimpla.Text = "Medie Simpla";
            this.rbSimpla.UseVisualStyleBackColor = true;
            // 
            // rbPonderata
            // 
            this.rbPonderata.AutoSize = true;
            this.rbPonderata.Location = new System.Drawing.Point(39, 61);
            this.rbPonderata.Name = "rbPonderata";
            this.rbPonderata.Size = new System.Drawing.Size(132, 20);
            this.rbPonderata.TabIndex = 3;
            this.rbPonderata.Text = "Medie Ponderata";
            this.rbPonderata.UseVisualStyleBackColor = true;
            // 
            // FormularEvaluareCandidati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCandidatiAdmisi);
            this.Controls.Add(this.dgvSpecializari);
            this.Controls.Add(this.label1);
            this.Name = "FormularEvaluareCandidati";
            this.Text = "FormularEvaluareCandidati";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecializari)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEvalueazaCand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSpecializari;
        private System.Windows.Forms.ListBox lbCandidatiAdmisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPonderata;
        private System.Windows.Forms.RadioButton rbSimpla;
    }
}