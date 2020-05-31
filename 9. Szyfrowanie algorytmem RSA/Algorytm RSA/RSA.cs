using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgorytmRSA
{
    public sealed class RSA
    {
        private TextBox textBoxPublic;
        private TextBox textBoxPrivate;

        public RSA(TextBox textBoxPublic, TextBox textBoxPrivate)
        {
            this.textBoxPublic = textBoxPublic;
            this.textBoxPrivate = textBoxPrivate;
        }


        public bool CheckTextValue()
        {
            if (textBoxPrivate.Text == String.Empty || textBoxPublic.Text == String.Empty)
            {
                MessageBox.Show("Brak kluczy!","Komunikat",MessageBoxButtons.OK,MessageBoxIcon.Warning); ;
                return false;
            }
            else
                return true;
        }

        public void TextBoxValue(string publicKeyPath, string privateKeyPath)
        {
            textBoxPublic.Text = publicKeyPath;
            textBoxPrivate.Text = privateKeyPath;
        }


        public void AssignNewKey(string publicKeyPath, string privateKeyPath)
        {
            if (string.IsNullOrEmpty(publicKeyPath))
            {
                throw new ArgumentNullException("publicKeyPath");
            }

            if (string.IsNullOrEmpty(privateKeyPath))
            {
                throw new ArgumentNullException("privateKeyPath");
            }

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.PersistKeyInCsp = false;

                if (File.Exists(privateKeyPath) == true)
                {
                    File.Delete(privateKeyPath);
                }

                if (File.Exists(publicKeyPath) == true)
                {
                    File.Delete(publicKeyPath);
                }
                File.WriteAllText(publicKeyPath, rsa.ToXmlString(false));
                File.WriteAllText(privateKeyPath, rsa.ToXmlString(true));
            }
        }

        public string EncryptData(string publicKeyPath, string data2Encrypt)
        {
            if (string.IsNullOrEmpty(publicKeyPath))
            {
                throw new ArgumentNullException("publicKeyPath");
            }

            if (string.IsNullOrEmpty(data2Encrypt))
            {
                throw new ArgumentNullException("data2Encrypt");
            }

            byte[] cipherbytes;

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.PersistKeyInCsp = false;
                rsa.FromXmlString(File.ReadAllText(publicKeyPath));
                byte[] plainbytes = Encoding.UTF8.GetBytes(data2Encrypt);

                try
                {
                cipherbytes = rsa.Encrypt(plainbytes, false);
                    return Convert.ToBase64String(cipherbytes);

                }
                catch (CryptographicException)
                {
                    MessageBox.Show("Zbyt długi tekst do zaszyfrowania!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return "";
        }

        public string DecryptData(string privateKeyPath, string data2Decrypt)
        {
            if (string.IsNullOrEmpty(privateKeyPath))
            {
                throw new ArgumentNullException("privateKeyPath");
            }

            if (string.IsNullOrEmpty(data2Decrypt))
            {
                throw new ArgumentNullException("data2Decrypt");
            }

            byte[] plain;

            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024))
            {
                rsa.PersistKeyInCsp = false;

                byte[] encodedCipherText = Convert.FromBase64String(data2Decrypt);
                rsa.FromXmlString(File.ReadAllText(privateKeyPath));
                plain = rsa.Decrypt(encodedCipherText, false);
            }

            return Encoding.UTF8.GetString(plain);
        }
    }
}
