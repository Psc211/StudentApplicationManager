namespace Proiect
{
    partial class FormularEvaluareSinguraCandidat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularEvaluareSinguraCandidat));
            this.tbCandidatSelect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNotaOblig = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNotaProfil = new System.Windows.Forms.TextBox();
            this.tbNotaOptionala = new System.Windows.Forms.TextBox();
            this.dgvSpecializari = new System.Windows.Forms.DataGridView();
            this.btnAlegereSpecializare = new System.Windows.Forms.Button();
            this.btnToateSpecializarile = new System.Windows.Forms.Button();
            this.tbRezultat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbPonderata = new System.Windows.Forms.RadioButton();
            this.rbSimpla = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecializari)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCandidatSelect
            // 
            this.tbCandidatSelect.Location = new System.Drawing.Point(34, 73);
            this.tbCandidatSelect.Multiline = true;
            this.tbCandidatSelect.Name = "tbCandidatSelect";
            this.tbCandidatSelect.ReadOnly = true;
            this.tbCandidatSelect.Size = new System.Drawing.Size(155, 28);
            this.tbCandidatSelect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numele candidatului selectat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota Proba Obligatorie";
            // 
            // tbNotaOblig
            // 
            this.tbNotaOblig.Location = new System.Drawing.Point(34, 123);
            this.tbNotaOblig.Multiline = true;
            this.tbNotaOblig.Name = "tbNotaOblig";
            this.tbNotaOblig.ReadOnly = true;
            this.tbNotaOblig.Size = new System.Drawing.Size(155, 28);
            this.tbNotaOblig.TabIndex = 3;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1069, 27);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nota Proba Profil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota Proba Optionala";
            // 
            // tbNotaProfil
            // 
            this.tbNotaProfil.Location = new System.Drawing.Point(34, 173);
            this.tbNotaProfil.Multiline = true;
            this.tbNotaProfil.Name = "tbNotaProfil";
            this.tbNotaProfil.ReadOnly = true;
            this.tbNotaProfil.Size = new System.Drawing.Size(155, 28);
            this.tbNotaProfil.TabIndex = 7;
            // 
            // tbNotaOptionala
            // 
            this.tbNotaOptionala.Location = new System.Drawing.Point(34, 223);
            this.tbNotaOptionala.Multiline = true;
            this.tbNotaOptionala.Name = "tbNotaOptionala";
            this.tbNotaOptionala.ReadOnly = true;
            this.tbNotaOptionala.Size = new System.Drawing.Size(155, 28);
            this.tbNotaOptionala.TabIndex = 8;
            // 
            // dgvSpecializari
            // 
            this.dgvSpecializari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecializari.Location = new System.Drawing.Point(347, 54);
            this.dgvSpecializari.Name = "dgvSpecializari";
            this.dgvSpecializari.RowHeadersWidth = 51;
            this.dgvSpecializari.RowTemplate.Height = 24;
            this.dgvSpecializari.Size = new System.Drawing.Size(637, 205);
            this.dgvSpecializari.TabIndex = 9;
            this.dgvSpecializari.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSpecializari_RowHeaderMouseClick);
            // 
            // btnAlegereSpecializare
            // 
            this.btnAlegereSpecializare.Location = new System.Drawing.Point(171, 102);
            this.btnAlegereSpecializare.Name = "btnAlegereSpecializare";
            this.btnAlegereSpecializare.Size = new System.Drawing.Size(149, 53);
            this.btnAlegereSpecializare.TabIndex = 10;
            this.btnAlegereSpecializare.Text = "Specializarea Aleasa";
            this.btnAlegereSpecializare.UseVisualStyleBackColor = true;
            this.btnAlegereSpecializare.Click += new System.EventHandler(this.btnAlegereSpecializare_Click);
            // 
            // btnToateSpecializarile
            // 
            this.btnToateSpecializarile.Location = new System.Drawing.Point(6, 102);
            this.btnToateSpecializarile.Name = "btnToateSpecializarile";
            this.btnToateSpecializarile.Size = new System.Drawing.Size(136, 53);
            this.btnToateSpecializarile.TabIndex = 11;
            this.btnToateSpecializarile.Text = "Toate Specializarile";
            this.btnToateSpecializarile.UseVisualStyleBackColor = true;
            this.btnToateSpecializarile.Click += new System.EventHandler(this.btnToateSpecializarile_Click);
            // 
            // tbRezultat
            // 
            this.tbRezultat.Location = new System.Drawing.Point(414, 305);
            this.tbRezultat.Multiline = true;
            this.tbRezultat.Name = "tbRezultat";
            this.tbRezultat.ReadOnly = true;
            this.tbRezultat.Size = new System.Drawing.Size(570, 155);
            this.tbRezultat.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Rezultat";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbPonderata);
            this.groupBox1.Controls.Add(this.rbSimpla);
            this.groupBox1.Controls.Add(this.btnToateSpecializarile);
            this.groupBox1.Controls.Add(this.btnAlegereSpecializare);
            this.groupBox1.Location = new System.Drawing.Point(34, 305);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 182);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alegere Metoda Admitere";
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
            // FormularEvaluareSinguraCandidat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 499);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbRezultat);
            this.Controls.Add(this.dgvSpecializari);
            this.Controls.Add(this.tbNotaOptionala);
            this.Controls.Add(this.tbNotaProfil);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tbNotaOblig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCandidatSelect);
            this.Name = "FormularEvaluareSinguraCandidat";
            this.Text = "FormularEvaluareSinguraCandidat";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecializari)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbCandidatSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNotaOblig;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNotaProfil;
        private System.Windows.Forms.TextBox tbNotaOptionala;
        private System.Windows.Forms.DataGridView dgvSpecializari;
        private System.Windows.Forms.Button btnAlegereSpecializare;
        private System.Windows.Forms.Button btnToateSpecializarile;
        private System.Windows.Forms.TextBox tbRezultat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPonderata;
        private System.Windows.Forms.RadioButton rbSimpla;
    }
}