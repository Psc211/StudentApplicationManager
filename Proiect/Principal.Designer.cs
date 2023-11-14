namespace Proiect
{
    partial class Principal
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
            this.tbStartPage = new System.Windows.Forms.TextBox();
            this.btnAdaugareCandidati = new System.Windows.Forms.Button();
            this.btnAdaugareFacultati = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnEvaluareCandidati = new System.Windows.Forms.Button();
            this.btnStatistica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbStartPage
            // 
            this.tbStartPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbStartPage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbStartPage.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStartPage.Location = new System.Drawing.Point(18, 51);
            this.tbStartPage.Multiline = true;
            this.tbStartPage.Name = "tbStartPage";
            this.tbStartPage.ReadOnly = true;
            this.tbStartPage.Size = new System.Drawing.Size(891, 56);
            this.tbStartPage.TabIndex = 0;
            this.tbStartPage.Text = "Admitere Facultate";
            this.tbStartPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdaugareCandidati
            // 
            this.btnAdaugareCandidati.Location = new System.Drawing.Point(18, 138);
            this.btnAdaugareCandidati.Name = "btnAdaugareCandidati";
            this.btnAdaugareCandidati.Size = new System.Drawing.Size(200, 50);
            this.btnAdaugareCandidati.TabIndex = 1;
            this.btnAdaugareCandidati.Text = "Adaugare Candidati";
            this.btnAdaugareCandidati.UseVisualStyleBackColor = true;
            this.btnAdaugareCandidati.Click += new System.EventHandler(this.btnAdaugareCandidati_Click);
            // 
            // btnAdaugareFacultati
            // 
            this.btnAdaugareFacultati.Location = new System.Drawing.Point(18, 194);
            this.btnAdaugareFacultati.Name = "btnAdaugareFacultati";
            this.btnAdaugareFacultati.Size = new System.Drawing.Size(200, 50);
            this.btnAdaugareFacultati.TabIndex = 2;
            this.btnAdaugareFacultati.Text = "Adaugare Facultati";
            this.btnAdaugareFacultati.UseVisualStyleBackColor = true;
            this.btnAdaugareFacultati.Click += new System.EventHandler(this.btnAdaugareFacultati_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem,
            this.binaryFileToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // textFileToolStripMenuItem
            // 
            this.textFileToolStripMenuItem.Name = "textFileToolStripMenuItem";
            this.textFileToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.textFileToolStripMenuItem.Text = "TextFile";
            this.textFileToolStripMenuItem.Click += new System.EventHandler(this.textFileToolStripMenuItem_Click);
            // 
            // binaryFileToolStripMenuItem
            // 
            this.binaryFileToolStripMenuItem.Name = "binaryFileToolStripMenuItem";
            this.binaryFileToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.binaryFileToolStripMenuItem.Text = "Binary File";
            this.binaryFileToolStripMenuItem.Click += new System.EventHandler(this.binaryFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textFileToolStripMenuItem1,
            this.binaryFileToolStripMenuItem1});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // textFileToolStripMenuItem1
            // 
            this.textFileToolStripMenuItem1.Name = "textFileToolStripMenuItem1";
            this.textFileToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.textFileToolStripMenuItem1.Text = "Text File";
            this.textFileToolStripMenuItem1.Click += new System.EventHandler(this.textFileToolStripMenuItem1_Click);
            // 
            // binaryFileToolStripMenuItem1
            // 
            this.binaryFileToolStripMenuItem1.Name = "binaryFileToolStripMenuItem1";
            this.binaryFileToolStripMenuItem1.Size = new System.Drawing.Size(160, 26);
            this.binaryFileToolStripMenuItem1.Text = "Binary File";
            this.binaryFileToolStripMenuItem1.Click += new System.EventHandler(this.binaryFileToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnEvaluareCandidati
            // 
            this.btnEvaluareCandidati.Location = new System.Drawing.Point(18, 250);
            this.btnEvaluareCandidati.Name = "btnEvaluareCandidati";
            this.btnEvaluareCandidati.Size = new System.Drawing.Size(200, 48);
            this.btnEvaluareCandidati.TabIndex = 4;
            this.btnEvaluareCandidati.Text = "Evalueaza Candidati";
            this.btnEvaluareCandidati.UseVisualStyleBackColor = true;
            this.btnEvaluareCandidati.Click += new System.EventHandler(this.btnEvaluareCandidati_Click);
            // 
            // btnStatistica
            // 
            this.btnStatistica.Location = new System.Drawing.Point(18, 358);
            this.btnStatistica.Name = "btnStatistica";
            this.btnStatistica.Size = new System.Drawing.Size(200, 48);
            this.btnStatistica.TabIndex = 5;
            this.btnStatistica.Text = "Statistica Candidati";
            this.btnStatistica.UseVisualStyleBackColor = true;
            this.btnStatistica.Click += new System.EventHandler(this.btnStatistica_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 48);
            this.button1.TabIndex = 6;
            this.button1.Text = "Evalueaza un Candidat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(440, 132);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(167, 274);
            this.listBox1.TabIndex = 7;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox1_DragEnter);
            this.listBox1.DoubleClick += new System.EventHandler(this.ListBox1_DoubleClick);
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseDown);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseMove);
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListBox1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(440, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume Candidati";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 457);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStatistica);
            this.Controls.Add(this.btnEvaluareCandidati);
            this.Controls.Add(this.btnAdaugareFacultati);
            this.Controls.Add(this.btnAdaugareCandidati);
            this.Controls.Add(this.tbStartPage);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStartPage;
        private System.Windows.Forms.Button btnAdaugareCandidati;
        private System.Windows.Forms.Button btnAdaugareFacultati;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textFileToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem binaryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryFileToolStripMenuItem1;
        private System.Windows.Forms.Button btnEvaluareCandidati;
        private System.Windows.Forms.Button btnStatistica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

