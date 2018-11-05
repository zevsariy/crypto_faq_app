using System;

namespace ALL_LABS.Algo
{
    class Cesar
    {
        public static string Encode(string Stringa)
        {
            char[] CharSet = Stringa.ToCharArray();
            string NewCharSet = "";
            foreach (char charka in CharSet)
            {
                NewCharSet = NewCharSet + Convert.ToChar(Convert.ToInt16(charka) - 3);
            }
            return NewCharSet;
        }

        public static string Decode(string Stringa)
        {
            char[] CharSet = Stringa.ToCharArray();
            string NewCharSet = "";
            foreach (char charka in CharSet)
            {
                NewCharSet = NewCharSet + Convert.ToChar(Convert.ToInt16(charka) + 3);
            }
            return NewCharSet;
        }
    }
}
