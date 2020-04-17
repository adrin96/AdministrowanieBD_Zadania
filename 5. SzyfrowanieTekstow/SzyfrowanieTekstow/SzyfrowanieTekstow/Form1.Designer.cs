namespace SzyfrowanieTekstow
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonClearNormal = new System.Windows.Forms.Button();
            this.buttonEncript = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxNormal = new System.Windows.Forms.TextBox();
            this.textBoxEncripted = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDecript = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonClearEncripted = new System.Windows.Forms.Button();
            this.labelMove = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClearNormal
            // 
            this.buttonClearNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearNormal.Location = new System.Drawing.Point(29, 292);
            this.buttonClearNormal.Name = "buttonClearNormal";
            this.buttonClearNormal.Size = new System.Drawing.Size(239, 36);
            this.buttonClearNormal.TabIndex = 5;
            this.buttonClearNormal.Text = "Wyczyść zwykły tekst";
            this.buttonClearNormal.UseVisualStyleBackColor = true;
            this.buttonClearNormal.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonEncript
            // 
            this.buttonEncript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEncript.Location = new System.Drawing.Point(159, 393);
            this.buttonEncript.Name = "buttonEncript";
            this.buttonEncript.Size = new System.Drawing.Size(231, 30);
            this.buttonEncript.TabIndex = 1;
            this.buttonEncript.Text = "Szyfruj";
            this.buttonEncript.UseVisualStyleBackColor = true;
            this.buttonEncript.Click += new System.EventHandler(this.buttonEncript_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 497);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 23);
            this.panel1.TabIndex = 7;
            // 
            // textBoxNormal
            // 
            this.textBoxNormal.Font = new System.Drawing.Font("Noto Mono", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNormal.Location = new System.Drawing.Point(29, 43);
            this.textBoxNormal.Multiline = true;
            this.textBoxNormal.Name = "textBoxNormal";
            this.textBoxNormal.Size = new System.Drawing.Size(239, 243);
            this.textBoxNormal.TabIndex = 0;
            this.textBoxNormal.Text = "aąbcćdeęfghijklłmnńoópqrsśtuvwxyzźż";
            // 
            // textBoxEncripted
            // 
            this.textBoxEncripted.Font = new System.Drawing.Font("Noto Mono", 11F);
            this.textBoxEncripted.Location = new System.Drawing.Point(295, 43);
            this.textBoxEncripted.Multiline = true;
            this.textBoxEncripted.Name = "textBoxEncripted";
            this.textBoxEncripted.Size = new System.Drawing.Size(239, 243);
            this.textBoxEncripted.TabIndex = 2222;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(94, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Zwykły tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(337, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Zaszyfrowany tekst";
            // 
            // buttonDecript
            // 
            this.buttonDecript.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonDecript.Location = new System.Drawing.Point(159, 429);
            this.buttonDecript.Name = "buttonDecript";
            this.buttonDecript.Size = new System.Drawing.Size(231, 35);
            this.buttonDecript.TabIndex = 2;
            this.buttonDecript.Text = "Odszyfruj";
            this.buttonDecript.UseVisualStyleBackColor = true;
            this.buttonDecript.Click += new System.EventHandler(this.buttonDecript_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 367);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(231, 20);
            this.numericUpDown1.TabIndex = 2223;
            this.numericUpDown1.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // buttonClearEncripted
            // 
            this.buttonClearEncripted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearEncripted.Location = new System.Drawing.Point(295, 292);
            this.buttonClearEncripted.Name = "buttonClearEncripted";
            this.buttonClearEncripted.Size = new System.Drawing.Size(239, 36);
            this.buttonClearEncripted.TabIndex = 2225;
            this.buttonClearEncripted.Text = "Wyczyść zaszyfrowany tekst";
            this.buttonClearEncripted.UseVisualStyleBackColor = true;
            this.buttonClearEncripted.Click += new System.EventHandler(this.buttonClearEncripted_Click);
            // 
            // labelMove
            // 
            this.labelMove.AutoSize = true;
            this.labelMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelMove.Location = new System.Drawing.Point(215, 344);
            this.labelMove.Name = "labelMove";
            this.labelMove.Size = new System.Drawing.Size(99, 20);
            this.labelMove.TabIndex = 2224;
            this.labelMove.Text = "Przesunięcie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(396, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "@Adrian Kut III INF PWSZ 2020";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 520);
            this.Controls.Add(this.buttonClearEncripted);
            this.Controls.Add(this.labelMove);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonDecript);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEncripted);
            this.Controls.Add(this.textBoxNormal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonEncript);
            this.Controls.Add(this.buttonClearNormal);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demonstracja działania szyfru Cezara ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClearNormal;
        private System.Windows.Forms.Button buttonEncript;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNormal;
        private System.Windows.Forms.TextBox textBoxEncripted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDecript;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button buttonClearEncripted;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.Label label3;
    }
}

