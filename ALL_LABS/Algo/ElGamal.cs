using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALL_LABS.Algo
{
    class ElGamal
    {
        /* private int Rand()//Ф-я получения случайного числа
        {
            Random random = new Random();
            return random.Next();
        }

        int power(int a, int b, int n) // a^b mod n - возведение a в степень b по модулю n
        {
            int tmp = a;
            int sum = tmp;
            for (int i = 1; i < b; i++)
            {
                for (int j = 1; j < a; j++)
                {
                    sum += tmp;
                    if (sum >= n)
                    {
                        sum -= n;
                    }
                }
                tmp = sum;
            }
            return tmp;
        }

        int mul(int a, int b, int n) // a*b mod n - умножение a на b по модулю n
        {
            int sum = 0;
            for (int i = 0; i < b; i++)
            {
                sum += a;
                if (sum >= n)
                {
                    sum -= n;
                }
            }
            return sum;
        }

        void crypt(int p, int g, int x, string strIn) //Шифрование
        {
            rTxtBOut.Text = "";
            int y = power(g, x, p);
            txtBPublicKey.Text = "Открытый ключ (p,g,y) = (" + p + "," + g + "," + y + ")";
            txtBSecretKey.Text = "Закрытый ключ x = " + x;
            IEnumerator<char> Enum = strIn.GetEnumerator();
            Enum.Reset();
            if (Enum.MoveNext())
            {
                char t = Enum.Current;
                int m = Convert.ToInt32(t);
                for (int i = 1; i <= strIn.Length; i++)
                {
                    if (m > 0)
                    {
                        t = Enum.Current;
                        m = Convert.ToInt32(t);
                        int k = Rand() % (p - 2) + 1; // 1 < k < (p-1)
                        int a = power(g, k, p);
                        int b = mul(power(y, k, p), m, p);
                        rTxtBOut.Text = rTxtBOut.Text + a + " " + b + " ";
                        Enum.MoveNext();
                    }
                }
            }
        }

        void decrypt(int p, int x, string strIn)
        {
            if (strIn.Length > 0)
            {
                txtBDecrypt.Text = "";
                string[] strA = strIn.Split(' ');
                if (strA.Length > 0)
                {
                    for (int i = 0; i < strA.Length - 1; i += 2)
                    {
                        char[] a = new char[strA[i].Length];
                        char[] b = new char[strA[i + 1].Length];
                        int ai = 0;
                        int bi = 0;
                        a = strA[i].ToCharArray();
                        b = strA[i + 1].ToCharArray();
                        for (int j = 0; (j < a.Length); j++)
                        {
                            ai = ai * 10 + (int)(a[j] - 48);
                        }
                        for (int j = 0; (j < b.Length); j++)
                        {
                            bi = bi * 10 + (int)(b[j] - 48);
                        }
                        if ((ai != 0) && (bi != 0))
                        {
                            int deM = mul(bi, power(ai, p - 1 - x, p), p);// m=b*(a^x)^(-1)mod p =b*a^(p-1-x)mod p - трудно было  найти нормальную формулу, в ней вся загвоздка
                            char m = (char)deM;
                            txtBDecrypt.Text = txtBDecrypt.Text + m;
                        }
                    }
                }

            }
        }

        private void txtBIn_TextChanged(object sender, EventArgs e) //Обработка изменения текста в текстовом поле
        {
            string strIn = txtBIn.Text;
            string strOut = rTxtBOut.Text;
            int p = Convert.ToInt32(numP.Value);
            int g = Convert.ToInt32(numG.Value);
            int x = Convert.ToInt32(numX.Value);
            crypt(p, g, x, strIn);
            decrypt(p, x, strOut);
        }
        */
    }
}
