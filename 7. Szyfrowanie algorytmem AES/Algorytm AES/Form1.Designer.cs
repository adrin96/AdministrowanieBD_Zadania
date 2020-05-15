namespace AlgorytmAES
{
    partial class Form1
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
            this.buttonSzyfruj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxZwykly = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWyszyscZwykly = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.buttonWyczyszcZaszyfrowany = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSzyfruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSzyfruj.Location = new System.Drawing.Point(12, 315);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(472, 34);
            this.buttonSzyfruj.TabIndex = 0;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = false;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(12, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(472, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odszyfruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxZwykly
            // 
            this.textBoxZwykly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxZwykly.Location = new System.Drawing.Point(12, 37);
            this.textBoxZwykly.Multiline = true;
            this.textBoxZwykly.Name = "textBoxZwykly";
            this.textBoxZwykly.Size = new System.Drawing.Size(206, 224);
            this.textBoxZwykly.TabIndex = 2;
            this.textBoxZwykly.Text = "Tekst do zaszyfrowania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(69, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zwykły Tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(313, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encrypted";
            // 
            // buttonWyszyscZwykly
            // 
            this.buttonWyszyscZwykly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWyszyscZwykly.Location = new System.Drawing.Point(12, 265);
            this.buttonWyszyscZwykly.Name = "buttonWyszyscZwykly";
            this.buttonWyszyscZwykly.Size = new System.Drawing.Size(206, 41);
            this.buttonWyszyscZwykly.TabIndex = 6;
            this.buttonWyszyscZwykly.Text = "Wyczyść zwykły tekst";
            this.buttonWyszyscZwykly.UseVisualStyleBackColor = true;
            this.buttonWyszyscZwykly.Click += new System.EventHandler(this.buttonWyszyscZwykly_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(315, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "@ Adrian Kut III INF KPU 2020";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 403);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 27);
            this.panel1.TabIndex = 10;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Enabled = false;
            this.textBoxEncrypted.Location = new System.Drawing.Point(224, 37);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(260, 53);
            this.textBoxEncrypted.TabIndex = 11;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Enabled = false;
            this.textBoxKey.Location = new System.Drawing.Point(224, 121);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(260, 53);
            this.textBoxKey.TabIndex = 12;
            // 
            // textBoxIV
            // 
            this.textBoxIV.Enabled = false;
            this.textBoxIV.Location = new System.Drawing.Point(224, 206);
            this.textBoxIV.Multiline = true;
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(260, 53);
            this.textBoxIV.TabIndex = 13;
            // 
            // buttonWyczyszcZaszyfrowany
            // 
            this.buttonWyczyszcZaszyfrowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWyczyszcZaszyfrowany.Location = new System.Drawing.Point(224, 265);
            this.buttonWyczyszcZaszyfrowany.Name = "buttonWyczyszcZaszyfrowany";
            this.buttonWyczyszcZaszyfrowany.Size = new System.Drawing.Size(260, 41);
            this.buttonWyczyszcZaszyfrowany.TabIndex = 7;
            this.buttonWyczyszcZaszyfrowany.Text = "Wyczyść zaszyfrowany tekst";
            this.buttonWyczyszcZaszyfrowany.UseVisualStyleBackColor = true;
            this.buttonWyczyszcZaszyfrowany.Click += new System.EventHandler(this.buttonWyczyszcZaszyfrowany_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(336, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Key";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(336, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "IV";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 430);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonWyczyszcZaszyfrowany);
            this.Controls.Add(this.buttonWyszyscZwykly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxZwykly);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSzyfruj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorytm AES";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxZwykly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWyszyscZwykly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.TextBox textBoxIV;
        private System.Windows.Forms.Button buttonWyczyszcZaszyfrowany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

