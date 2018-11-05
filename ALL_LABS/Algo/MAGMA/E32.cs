using System;

namespace ALL_LABS.Algo.MAGMA
{
    class E32 : Converter
    {
        byte[] encrByteString;
        uint[] uintKey;
        ulong[] ulongString;

        private E32() { }

        public E32(byte[] stringa, byte[] key)
        {
            uintKey = GetUIntKeyArray(key);
            ulongString = GetULongDataArray(stringa);

            encrByteString = ConvertToByte(EncryptString());
        }

        public byte[] GetEncryptString
        {
            get { return encrByteString; }
        }

        private ulong[] EncryptString()
        {
            BasicStep[] K = new BasicStep[8];
            ulong[] ulongEncrString = new ulong[ulongString.Length];

            for (int k = 0; k < ulongString.Length; k++)
            {
                ulongEncrString[k] = ulongString[k];

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < K.Length; i++)
                    {
                        K[i] = new BasicStep(ulongEncrString[k], uintKey[i]);
                        ulongEncrString[k] = K[i].BasicEncrypt(false);
                    }
                }

                for (int i = K.Length - 1; i >= 0; i--)
                {
                    K[i] = new BasicStep(ulongEncrString[k], uintKey[i]);

                    if (i != 0)
                        ulongEncrString[k] = K[i].BasicEncrypt(false);
                    else
                        ulongEncrString[k] = K[i].BasicEncrypt(true);
                }
            }

            return ulongEncrString;
        }
    }
}