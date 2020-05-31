namespace AlgorytmRSA
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
            this.buttonOdszyfruj = new System.Windows.Forms.Button();
            this.textBoxZwykly = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonWyczyscZwykly = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxZaszyfrowany = new System.Windows.Forms.TextBox();
            this.buttonWyczyszcZaszyfrowany = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonPobierzKlucz = new System.Windows.Forms.Button();
            this.buttonGenerujKlucze = new System.Windows.Forms.Button();
            this.flowLayoutPanelPrzyciski = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKluczPubliczny = new System.Windows.Forms.TextBox();
            this.textBoxKluczPrywatny = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanelPrzyciski.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSzyfruj
            // 
            this.buttonSzyfruj.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonSzyfruj.Enabled = false;
            this.buttonSzyfruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSzyfruj.Location = new System.Drawing.Point(3, 129);
            this.buttonSzyfruj.Name = "buttonSzyfruj";
            this.buttonSzyfruj.Size = new System.Drawing.Size(472, 34);
            this.buttonSzyfruj.TabIndex = 0;
            this.buttonSzyfruj.Text = "Szyfruj";
            this.buttonSzyfruj.UseVisualStyleBackColor = false;
            this.buttonSzyfruj.Click += new System.EventHandler(this.buttonSzyfruj_Click);
            // 
            // buttonOdszyfruj
            // 
            this.buttonOdszyfruj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonOdszyfruj.Location = new System.Drawing.Point(3, 169);
            this.buttonOdszyfruj.Name = "buttonOdszyfruj";
            this.buttonOdszyfruj.Size = new System.Drawing.Size(472, 33);
            this.buttonOdszyfruj.TabIndex = 1;
            this.buttonOdszyfruj.Text = "Odszyfruj";
            this.buttonOdszyfruj.UseVisualStyleBackColor = true;
            this.buttonOdszyfruj.Click += new System.EventHandler(this.buttonOdszyfruj_Click);
            // 
            // textBoxZwykly
            // 
            this.textBoxZwykly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxZwykly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxZwykly.Location = new System.Drawing.Point(3, 41);
            this.textBoxZwykly.Multiline = true;
            this.textBoxZwykly.Name = "textBoxZwykly";
            this.textBoxZwykly.Size = new System.Drawing.Size(234, 252);
            this.textBoxZwykly.TabIndex = 2;
            this.textBoxZwykly.Text = "Tekst do zaszyfrowania";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(243, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Zaszyfrowany tekst";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonWyczyscZwykly
            // 
            this.buttonWyczyscZwykly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWyczyscZwykly.Location = new System.Drawing.Point(3, 3);
            this.buttonWyczyscZwykly.Name = "buttonWyczyscZwykly";
            this.buttonWyczyscZwykly.Size = new System.Drawing.Size(234, 41);
            this.buttonWyczyscZwykly.TabIndex = 6;
            this.buttonWyczyscZwykly.Text = "Wyczyść zwykły tekst";
            this.buttonWyczyscZwykly.UseVisualStyleBackColor = true;
            this.buttonWyczyscZwykly.Click += new System.EventHandler(this.buttonWyszyscZwykly_Click);
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
            this.panel1.Location = new System.Drawing.Point(0, 584);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 27);
            this.panel1.TabIndex = 10;
            // 
            // textBoxZaszyfrowany
            // 
            this.textBoxZaszyfrowany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxZaszyfrowany.Location = new System.Drawing.Point(243, 41);
            this.textBoxZaszyfrowany.Multiline = true;
            this.textBoxZaszyfrowany.Name = "textBoxZaszyfrowany";
            this.textBoxZaszyfrowany.Size = new System.Drawing.Size(235, 252);
            this.textBoxZaszyfrowany.TabIndex = 11;
            // 
            // buttonWyczyszcZaszyfrowany
            // 
            this.buttonWyczyszcZaszyfrowany.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonWyczyszcZaszyfrowany.Location = new System.Drawing.Point(243, 3);
            this.buttonWyczyszcZaszyfrowany.Name = "buttonWyczyszcZaszyfrowany";
            this.buttonWyczyszcZaszyfrowany.Size = new System.Drawing.Size(228, 41);
            this.buttonWyczyszcZaszyfrowany.TabIndex = 7;
            this.buttonWyczyszcZaszyfrowany.Text = "Wyczyść zaszyfrowany tekst";
            this.buttonWyczyszcZaszyfrowany.UseVisualStyleBackColor = true;
            this.buttonWyczyszcZaszyfrowany.Click += new System.EventHandler(this.buttonWyczyszcZaszyfrowany_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonPobierzKlucz
            // 
            this.buttonPobierzKlucz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonPobierzKlucz.Location = new System.Drawing.Point(3, 50);
            this.buttonPobierzKlucz.Name = "buttonPobierzKlucz";
            this.buttonPobierzKlucz.Size = new System.Drawing.Size(472, 34);
            this.buttonPobierzKlucz.TabIndex = 16;
            this.buttonPobierzKlucz.Text = "Otwórz plik z publicznym kluczem .XML";
            this.buttonPobierzKlucz.UseVisualStyleBackColor = true;
            this.buttonPobierzKlucz.Click += new System.EventHandler(this.buttonPobierzKlucz_Click);
            // 
            // buttonGenerujKlucze
            // 
            this.buttonGenerujKlucze.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonGenerujKlucze.Location = new System.Drawing.Point(3, 90);
            this.buttonGenerujKlucze.Name = "buttonGenerujKlucze";
            this.buttonGenerujKlucze.Size = new System.Drawing.Size(472, 33);
            this.buttonGenerujKlucze.TabIndex = 17;
            this.buttonGenerujKlucze.Text = "Generuj klucze";
            this.buttonGenerujKlucze.UseVisualStyleBackColor = true;
            this.buttonGenerujKlucze.Click += new System.EventHandler(this.buttonGeneruj_Click);
            // 
            // flowLayoutPanelPrzyciski
            // 
            this.flowLayoutPanelPrzyciski.Controls.Add(this.buttonWyczyscZwykly);
            this.flowLayoutPanelPrzyciski.Controls.Add(this.buttonWyczyszcZaszyfrowany);
            this.flowLayoutPanelPrzyciski.Controls.Add(this.buttonPobierzKlucz);
            this.flowLayoutPanelPrzyciski.Controls.Add(this.buttonGenerujKlucze);
            this.flowLayoutPanelPrzyciski.Controls.Add(this.buttonSzyfruj);
            this.flowLayoutPanelPrzyciski.Controls.Add(this.buttonOdszyfruj);
            this.flowLayoutPanelPrzyciski.Location = new System.Drawing.Point(8, 360);
            this.flowLayoutPanelPrzyciski.Name = "flowLayoutPanelPrzyciski";
            this.flowLayoutPanelPrzyciski.Size = new System.Drawing.Size(481, 202);
            this.flowLayoutPanelPrzyciski.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(3, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 22);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ścieżka do klucza publicznego\r\n\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(243, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Ścieżka do klucza prywatnego";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxKluczPubliczny
            // 
            this.textBoxKluczPubliczny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKluczPubliczny.Enabled = false;
            this.textBoxKluczPubliczny.Location = new System.Drawing.Point(3, 321);
            this.textBoxKluczPubliczny.Name = "textBoxKluczPubliczny";
            this.textBoxKluczPubliczny.Size = new System.Drawing.Size(234, 20);
            this.textBoxKluczPubliczny.TabIndex = 21;
            // 
            // textBoxKluczPrywatny
            // 
            this.textBoxKluczPrywatny.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKluczPrywatny.Enabled = false;
            this.textBoxKluczPrywatny.Location = new System.Drawing.Point(243, 321);
            this.textBoxKluczPrywatny.Name = "textBoxKluczPrywatny";
            this.textBoxKluczPrywatny.Size = new System.Drawing.Size(235, 20);
            this.textBoxKluczPrywatny.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxZwykly, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKluczPrywatny, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxKluczPubliczny, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxZaszyfrowany, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.82051F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.17949F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 342);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Zwykły tekst";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanelPrzyciski);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Algorytm RSA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanelPrzyciski.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSzyfruj;
        private System.Windows.Forms.Button buttonOdszyfruj;
        private System.Windows.Forms.TextBox textBoxZwykly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonWyczyscZwykly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxZaszyfrowany;
        private System.Windows.Forms.Button buttonWyczyszcZaszyfrowany;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonPobierzKlucz;
        private System.Windows.Forms.Button buttonGenerujKlucze;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPrzyciski;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKluczPubliczny;
        private System.Windows.Forms.TextBox textBoxKluczPrywatny;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
    }
}

