namespace AlgorytmRSA
{
    using System.ComponentModel;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    using System;
    using System.Xml;

    public partial class Form1 : Form
    {
        string privateKeyPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\private.xml";        
        string publicKeyPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\public.xml";
        static RSA rsa;

        public Form1()
        {
            InitializeComponent();
            rsa = new RSA(textBoxKluczPubliczny, textBoxKluczPrywatny);
            buttonSzyfruj.Enabled = true;
        }


        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {

            if (textBoxZwykly.Text != "")
            {
                if (rsa.CheckTextValue())
                {
                    textBoxZaszyfrowany.Text = rsa.EncryptData(publicKeyPath, textBoxZwykly.Text);
                }

            }
            else
                MessageBox.Show("Wprowadź zwykły tekst!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonOdszyfruj_Click(object sender, EventArgs e)
        {
            if (textBoxZaszyfrowany.Text != "")
            {
                if (rsa.CheckTextValue())
                {
                if (textBoxZwykly.Text == String.Empty)
                {
                    textBoxZwykly.Text += rsa.DecryptData(privateKeyPath, textBoxZaszyfrowany.Text);
                }
                else
                {
                    textBoxZwykly.Text += Environment.NewLine + rsa.DecryptData(privateKeyPath, textBoxZaszyfrowany.Text);

                 }

                }
            }
            else
                MessageBox.Show("Brak zaszyfrowanego tekstu!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        private void buttonWyczyszcZaszyfrowany_Click(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Clear();
        }

        private void buttonWyszyscZwykly_Click(object sender, EventArgs e)
        {
            textBoxZwykly.Clear();
        }

        private void buttonPobierzKlucz_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "Pliki XML |*.xml|Pliki pub |*.pub| Wszystkie pliki |*.*";   
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Console.WriteLine("Plik z XML: " + openFileDialog1.FileName);
                publicKeyPath = openFileDialog1.FileName;
                rsa.TextBoxValue(publicKeyPath, privateKeyPath);
                buttonSzyfruj.Enabled = true;
                buttonOdszyfruj.Enabled = false;
            }

        }

        private void buttonGeneruj_Click(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Text = "";

             privateKeyPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\private.xml";
             publicKeyPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\public.xml";

            rsa.AssignNewKey(publicKeyPath, privateKeyPath);
            rsa.TextBoxValue(publicKeyPath, privateKeyPath);
            buttonOdszyfruj.Enabled = true;

            MessageBox.Show("Pomyślnie wygenerowano klucze!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}