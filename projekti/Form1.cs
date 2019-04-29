using System;
using System.Text;
using System.Windows.Forms;

namespace projekti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private char[,] GjeneroMatricen(string keyword)
        {
            char[,] matrica = new char[5, 5];

            StringBuilder sbAlfabeti = new StringBuilder();
            for (int i = 65; i < 65 + 26; i++)
                if ((char)i != 'I')
                    sbAlfabeti.Append((char)i);

            keyword = keyword.ToUpper();
            keyword = keyword.Replace("I", "J");

            for (int i = 0; i < keyword.Length; i++)
                sbAlfabeti.Replace(keyword[i].ToString(), "");





            int k = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                {
                    if (k < keyword.Length)
                    {
                        for (int l = 0; l < k; l++)
                        {
                            if (k < keyword.Length && keyword[l] == keyword[k])
                            {
                                k++;
                                l = -1;
                            }
                        }
                        if (k < keyword.Length) { 
                        matrica[i, j] = keyword[k];
                            k++;
                        }
                    }
                    else
                    {
                        matrica[i, j] = sbAlfabeti[0];
                        sbAlfabeti.Remove(0, 1);
                    }
                }
            return matrica;
        }

        private string Enkripto(string plaintexti, char[,] matrica)
        {
            
            StringBuilder sb = new StringBuilder("");
            plaintexti = plaintexti.Replace("I", "J");
            plaintexti = plaintexti.Replace(" ", "");

            for (int i = 0; i < plaintexti.Length; i++)
            {
                char chA = plaintexti[i];
                int pozitaX = 0, pozitaY = 0;
                for (int j = 0; j < 5; j++)
                    for (int k = 0; k < 5; k++)
                    {
                        if (matrica[j, k] == chA)
                        {
                            pozitaX = j+1;
                            pozitaY = k+1;
                        }
                    }
                
                string enc = pozitaX.ToString() + pozitaY.ToString();
                sb.Append(enc);
            }

            return sb.ToString();
        }

        private string Dekripto(string ciphertexti, char[,] matrica)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < ciphertexti.Length; i += 2)
            {
                char enc11 = ciphertexti[i];
                char enc21 = ciphertexti[i + 1];
                int enc1 = int.Parse(enc11.ToString())-1;
                int enc2 = int.Parse(enc21.ToString())-1;
                char dec='w';
                for (int j = 0; j < 5; j++)
                    for (int k = 0; k < 5; k++)
                    {
                        if (j == enc1 && k == enc2 )
                        {
                            dec = matrica[j, k];
                        }
                        
                    }
                sb.Append(dec);
            }

            return sb.ToString();
        }



        private void plaintexti_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(keyword.Text);
            string ciphertexti = Enkripto(plaintexti.Text.ToUpper(), matrica);
            ciphertext.Text = ciphertexti;
        }
        

        private void keyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            char[,] matrica = GjeneroMatricen(keyword.Text);
            string textDekriptuar = Dekripto(ciphertext.Text, matrica);
            textdekriptuar.Text = textDekriptuar;
        }

        private void textdekriptuar_TextChanged(object sender, EventArgs e)
        {

        }

        private void ciphertext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
