namespace SzyfrGaderypoluki
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        List<char[]> listaPar;
        char[] inneLitery;

        public Form1()
        {
            InitializeComponent();
            InicjalizajaPar();
        }

        private void InicjalizajaPar()
        {
            listaPar = new List<char[]>();
            listaPar.Add(new char[2] { 'G', 'A' });
            listaPar.Add(new char[2] { 'D', 'E' });
            listaPar.Add(new char[2] { 'R', 'Y' });
            listaPar.Add(new char[2] { 'P', 'O' });
            listaPar.Add(new char[2] { 'L', 'U' });
            listaPar.Add(new char[2] { 'K', 'I' });

            string napis = "GADERYPOLUKI";
            inneLitery = napis.ToCharArray();
        }

        void sprawdzSlowo(char znak, object ktoWysyla)
        {
            foreach (char[] item in listaPar)
            {
                if (item[0] == znak)
                {
                    if (ktoWysyla.Equals(buttonSzyfruj))
                        textBoxZaszyfrowany.Text += item[1];
                    else
                        textBoxZwykly.Text += item[1];

                    return;

                }
                if (item[1] == znak)
                {
                    if (ktoWysyla.Equals(buttonSzyfruj))
                        textBoxZaszyfrowany.Text += item[0];
                    else
                        textBoxZwykly.Text += item[0];

                    return;
                }
            }

            foreach (var item in inneLitery)
            {
                if (znak != item)
                {
                    if (ktoWysyla.Equals(buttonSzyfruj))
                        textBoxZaszyfrowany.Text += znak;
                    else
                        textBoxZwykly.Text += znak;

                    return;
                }

            }
        }

        private void buttonSzyfruj_Click(object sender, EventArgs e)
        {


            if (textBoxZwykly.Text != "")
            {
                if (!Regex.IsMatch(textBoxZwykly.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Wprowadź wyłącznie litery!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    char[] literyZeSlowa = textBoxZwykly.Text.ToUpper().ToCharArray();
                    foreach (char litera in literyZeSlowa)
                    {
                        sprawdzSlowo(litera, sender);
                    }
                }


            }
            else
                MessageBox.Show("Wprowadź zwykły tekst!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxZaszyfrowany.Text != "")
            {

                if (!Regex.IsMatch(textBoxZaszyfrowany.Text, @"^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Wprowadź wyłącznie litery!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {

                    char[] literyZeSlowa = textBoxZaszyfrowany.Text.ToUpper().ToCharArray();
                    foreach (char litera in literyZeSlowa)
                    {
                        sprawdzSlowo(litera, sender);
                    }

                }
            }
            else
                MessageBox.Show("Wprowadź zaszyfrowany tekst!", "Komunikat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void buttonWyczyszcZaszyfrowany_Click(object sender, EventArgs e)
        {
            textBoxZaszyfrowany.Clear();
        }

        private void buttonWyszyscZwykly_Click(object sender, EventArgs e)
        {
            textBoxZwykly.Clear();
        }
    }
}
