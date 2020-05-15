namespace AlgorytmAES
{
    using System;
    using System.IO;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        internal byte[] key;
        internal byte[] iv;
        internal byte[] encrypted;

        public Form1()
        {
            InitializeComponent();
            buttonWyczyszcZaszyfrowany.Enabled = false;
        }

        private byte[] EncryptString(string plaintext, byte[] Key, byte[] IV)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                key = Key;
                iv = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plaintext);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            textBoxEncrypted.Text = BitConverter.ToString(encrypted);
            textBoxKey.Text = BitConverter.ToString(key);
            textBoxIV.Text = BitConverter.ToString(iv);

            return encrypted;
        }

        private string DecryptString(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = "";
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {
            if (textBoxZwykly.Text != "")
            {
                using (Aes myAes = Aes.Create())
                {
                    byte[] encrypted = EncryptString(textBoxZwykly.Text, myAes.Key, myAes.IV);
                }
                buttonWyczyszcZaszyfrowany.Enabled = true;
            }
            else
                MessageBox.Show("Wprowadź zwykły tekst!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxEncrypted.Text != "")
            {
                using (Aes myAes = Aes.Create())
                {
                    string roundtrip = DecryptString(encrypted, key, iv);
                    textBoxZwykly.Text += "" + Environment.NewLine;
                    textBoxZwykly.Text += roundtrip.ToString();
                }
            }
            else
                MessageBox.Show("Brak zaszyfrowanego tekstu!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonWyczyszcZaszyfrowany_Click(object sender, EventArgs e)
        {
            textBoxEncrypted.Clear();
            textBoxIV.Clear();
            textBoxKey.Clear();

            buttonWyczyszcZaszyfrowany.Enabled = false;
        }

        private void buttonWyszyscZwykly_Click(object sender, EventArgs e)
        {
            textBoxZwykly.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Aes myAes = Aes.Create())
            {
                Console.WriteLine("Encrypted:" + textBoxEncrypted.Text);
                Console.WriteLine("Key:" + textBoxKey.Text);
                Console.WriteLine("IV:" + textBoxIV.Text);

                byte[] enc = Encoding.UTF8.GetBytes(textBoxEncrypted.Text);

                foreach (var item in enc)
                {
                    Console.WriteLine(" " + enc);
                }
                byte[] key = Encoding.ASCII.GetBytes(textBoxEncrypted.Text);
                byte[] iv = Encoding.ASCII.GetBytes(textBoxEncrypted.Text);

                string roundtrip = DecryptString(enc, key, iv);
                textBoxZwykly.Text += "" + Environment.NewLine;
                textBoxZwykly.Text += roundtrip.ToString();
            }
        }
    }
}
