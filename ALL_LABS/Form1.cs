using ALL_LABS.Algo;
using ALL_LABS.Algo.MAGMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALL_LABS
{
    public partial class fm : Form
    {
        public fm()
        {
            InitializeComponent();
        }

        private void buGenerateKey_Click(object sender, EventArgs e)
        {
            txKey.Text = Generator.MakeKey();
        }

        private void btEncrypt_Click(object sender, EventArgs e)
        {
            switch (cbALgoritm.Text)
            {
                case "MAGMA":
                    {
                        if (txInputText.Text == "")
                            MessageBox.Show("Введите данные для шифрования.");
                        else
                        {
                            byte[] btText = Encoding.Default.GetBytes(txInputText.Text);
                            byte[] btKey = Encoding.ASCII.GetBytes(txKey.Text);

                            if ((btKey == null) || (btKey.Length != 32))
                                MessageBox.Show("Введдите 256-битный ключ.");
                            else
                            {
                                E32 e32 = new E32(btText, btKey);
                                txOutputText.Text = Encoding.Default.GetString(e32.GetEncryptString);
                            }
                        }
                    }
                    break;
                case "CESAR":
                    txOutputText.Text = Cesar.Encode(txInputText.Text);
                    break;
                case "VIJENER":
                    {
                        if (txInputText.Text == "")
                            MessageBox.Show("Введите данные для шифрования.");
                        else if (txKey.Text == "")
                            MessageBox.Show("Введите ключ шифрования или используйте вариант с псевдослучайным числом.");
                        else if (txKey.Text.Length != txInputText.Text.Length)
                            MessageBox.Show("Ключ и текст должны быть одной длинны.");
                        else
                        {
                            txOutputText.Text = Vijener.Encode(txInputText.Text, txKey.Text);
                        }
                    }
                    break;
                case "VIJENER_PSEUDO":
                    {
                        if (txInputText.Text == "")
                            MessageBox.Show("Введите данные для шифрования.");
                        else
                        {
                            txKey.Text = Vijener.Generate_Pseudorandom_KeyWord(txInputText.Text.Length, 100);
                            txOutputText.Text = Vijener.Encode(txInputText.Text, txKey.Text);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Не выбран алгоритм");
                    break;
            }
        }

        private void btDecrypt_Click(object sender, EventArgs e)
        {
            switch (cbALgoritm.Text)
            {
                case "MAGMA":
                    {
                        if (txInputText.Text == "")
                            MessageBox.Show("Введите данные для шифрования.");
                        else
                        {
                            byte[] btText = Encoding.Default.GetBytes(txInputText.Text);
                            byte[] btKey = Encoding.ASCII.GetBytes(txKey.Text);

                            if ((btKey == null) || (btKey.Length != 32))
                                MessageBox.Show("Введдите 256-битный ключ.");
                            else
                            {
                                D32 d32 = new D32(btText, btKey);
                                txOutputText.Text = Encoding.Default.GetString(d32.GetDecryptString);
                            }
                        }
                    }
                    break;
                case "CESAR":
                    txOutputText.Text = Cesar.Decode(txInputText.Text);
                    break;
                case "VIJENER":
                    {
                        if (txInputText.Text == "")
                            MessageBox.Show("Введите данные для шифрования.");
                        else
                        {
                            txOutputText.Text = Vijener.Decode(txInputText.Text, txKey.Text);
                        }
                    }
                    break;
                case "VIJENER_PSEUDO":
                    {
                        if (txInputText.Text == "")
                            MessageBox.Show("Введите данные для шифрования.");
                        else
                        {
                            txOutputText.Text = Vijener.Decode(txInputText.Text, txKey.Text);
                        }
                    }
                    break;
                default:
                    MessageBox.Show("Не выбран алгоритм");
                    break;
            }
        }
    }
}
