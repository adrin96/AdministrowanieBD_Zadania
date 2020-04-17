using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SzyfrowanieTekstow
{
   
    public partial class Form1 : Form
    {
        char[] alphabet = new char[34];
        char[] word = new char[Char.MaxValue];
        char tempSlowo;
        int tempNumber;


        public Form1()
        {
            initializeEncriptor();
            InitializeComponent();
     
        }

        private void initializeEncriptor()
        {
            alphabet[0] = 'a';
            alphabet[1] = 'ą';
            alphabet[2] = 'b';
            alphabet[3] = 'c';
            alphabet[4] = 'ć'; 
            alphabet[5] = 'd';
            alphabet[6] = 'e';
            alphabet[7] = 'ę';
            alphabet[8] = 'f';
            alphabet[9] = 'g';
            alphabet[10] = 'h';
            alphabet[11] = 'i';
            alphabet[12] = 'j';
            alphabet[13] = 'k';
            alphabet[14] = 'l';
            alphabet[15] = 'ł'; 
            alphabet[16] = 'm';
            alphabet[17] = 'n';
            alphabet[18] = 'ń';
            alphabet[19] = 'o';
            alphabet[20] = 'ó';
            alphabet[21] = 'p';
            alphabet[22] = 'q';
            alphabet[23] = 'r';
            alphabet[24] = 's';
            alphabet[25] = 'ś';
            alphabet[26] = 't';
            alphabet[27] = 'u';
            alphabet[28] = 'w';
            alphabet[29] = 'x';
            alphabet[30] = 'y';
            alphabet[31] = 'z';
            alphabet[32] = 'ź';
            alphabet[33] = 'ż';
        }

        private void buttonEncript_Click(object sender, EventArgs e)
        {   
            word = textBoxNormal.Text.ToLower().ToCharArray(); 
            if (textBoxNormal.Text =="")
            {
                MessageBox.Show("Wprowadź tekst do zaszyfrowania!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
            foreach (char item in word)
            {
                for (int i = 0; i < alphabet.Length; i++)
                {
                    if (alphabet[i] == item)
                    {
                        if (i+ (int)numericUpDown1.Value == alphabet.Length)
                        {
                            tempSlowo = alphabet[0];
                            textBoxEncripted.Text = textBoxEncripted.Text + "" + tempSlowo;
                        }
                        else if (i + (int)numericUpDown1.Value > alphabet.Length)
                        {
     
                            tempNumber = i + (int)numericUpDown1.Value;
                            tempNumber = tempNumber - alphabet.Length;
                            tempSlowo = alphabet[tempNumber];
                            textBoxEncripted.Text = textBoxEncripted.Text + "" + tempSlowo;
                        }
                        else
                        {
                            tempSlowo = alphabet[i + (int)numericUpDown1.Value];
                            textBoxEncripted.Text = textBoxEncripted.Text + "" + tempSlowo;
                        }
                    }    
                    
                }
               
            }
            }
        }

        private void buttonDecript_Click(object sender, EventArgs e)
        {
            word = textBoxEncripted.Text.ToLower().ToCharArray();

            if (textBoxEncripted.Text == "")
            {
                MessageBox.Show("Wprowadź tekst do odszyfrowania!","Informacja",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                foreach (char item in word)
                {
                    for (int i = 0; i < alphabet.Length; i++)
                    {
                        if (alphabet[i] == item)
                        {
                            if (i - (int)numericUpDown1.Value == 0)
                            {
                                tempSlowo = alphabet[0];
                                textBoxNormal.Text = textBoxNormal.Text + "" + tempSlowo;
                            }
                            else if (i - (int)numericUpDown1.Value < 0)
                            {
                                tempNumber = i - (int)numericUpDown1.Value;
                                tempNumber = tempNumber + alphabet.Length;
                                tempSlowo = alphabet[tempNumber];
                                textBoxNormal.Text = textBoxNormal.Text + "" + tempSlowo;
                            }
                            else
                            {

                                tempSlowo = alphabet[i - (int)numericUpDown1.Value];
                                textBoxNormal.Text = textBoxNormal.Text + "" + tempSlowo;
                            }
                        }
                    }

                }
            }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNormal.Text = "";
        }

        private void buttonClearEncripted_Click(object sender, EventArgs e)
        {
            textBoxEncripted.Text = "";
        }
    }
}
