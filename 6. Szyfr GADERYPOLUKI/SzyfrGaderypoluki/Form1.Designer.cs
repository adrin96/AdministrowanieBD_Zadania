namespace SzyfrGaderypoluki
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
            this.textBoxZaszyfrowany = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWyszyscZwykly = new System.Windows.Forms.Button();
            this.buttonWyczyszcZaszyfrowany = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSzyfruj.Location = new System.Drawing.Point(183, 314);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(141, 34);
            this.buttonSzyfruj.TabIndex = 0;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = true;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(183, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Odszyfruj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxZwykly
            // 
            this.textBoxZwykly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxZwykly.Location = new System.Drawing.Point(12, 38);
            this.textBoxZwykly.Multiline = true;
            this.textBoxZwykly.Name = "textBoxZwykly";
            this.textBoxZwykly.Size = new System.Drawing.Size(235, 216);
            this.textBoxZwykly.TabIndex = 2;
            this.textBoxZwykly.Text = "GADERYPOLUKI";
            // 
            // textBoxZaszyfrowany
            // 
            this.textBoxZaszyfrowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxZaszyfrowany.Location = new System.Drawing.Point(253, 38);
            this.textBoxZaszyfrowany.Multiline = true;
            this.textBoxZaszyfrowany.Name = "textBoxZaszyfrowany";
            this.textBoxZaszyfrowany.Size = new System.Drawing.Size(235, 216);
            this.textBoxZaszyfrowany.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(75, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Zwykły Tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(298, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zaszyfrowany tekst";
            // 
            // buttonWyszyscZwykly
            // 
            this.buttonWyszyscZwykly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWyszyscZwykly.Location = new System.Drawing.Point(12, 260);
            this.buttonWyszyscZwykly.Name = "buttonWyszyscZwykly";
            this.buttonWyszyscZwykly.Size = new System.Drawing.Size(235, 41);
            this.buttonWyszyscZwykly.TabIndex = 6;
            this.buttonWyszyscZwykly.Text = "Wyczyść zwykły tekst";
            this.buttonWyszyscZwykly.UseVisualStyleBackColor = true;
            this.buttonWyszyscZwykly.Click += new System.EventHandler(this.buttonWyszyscZwykly_Click);
            // 
            // buttonWyczyszcZaszyfrowany
            // 
            this.buttonWyczyszcZaszyfrowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWyczyszcZaszyfrowany.Location = new System.Drawing.Point(253, 260);
            this.buttonWyczyszcZaszyfrowany.Name = "buttonWyczyszcZaszyfrowany";
            this.buttonWyczyszcZaszyfrowany.Size = new System.Drawing.Size(235, 41);
            this.buttonWyczyszcZaszyfrowany.TabIndex = 7;
            this.buttonWyczyszcZaszyfrowany.Text = "Wyczyść zaszyfrowany tekst";
            this.buttonWyczyszcZaszyfrowany.UseVisualStyleBackColor = true;
            this.buttonWyczyszcZaszyfrowany.Click += new System.EventHandler(this.buttonWyczyszcZaszyfrowany_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(327, 6);
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
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 27);
            this.panel1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 429);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonWyczyszcZaszyfrowany);
            this.Controls.Add(this.buttonWyszyscZwykly);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxZaszyfrowany);
            this.Controls.Add(this.textBoxZwykly);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSzyfruj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szyfr GA-DE-RY-PO-LU-KI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxZwykly;
        private System.Windows.Forms.TextBox textBoxZaszyfrowany;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWyszyscZwykly;
        private System.Windows.Forms.Button buttonWyczyszcZaszyfrowany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}

