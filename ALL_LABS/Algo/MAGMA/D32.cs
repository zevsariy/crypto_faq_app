using System;
namespace ALL_LABS.Algo.MAGMA
{
    class D32 : Converter
    {
        byte[] decrByteString;
        uint[] uintKey;
        ulong[] ulongString;

        private D32() { }

        public D32(byte[] stringa, byte[] key)
        {
            uintKey = GetUIntKeyArray(key);
            ulongString = GetULongDataArray(stringa);

            decrByteString = ConvertToByte(DecryptFile());
        }

        public byte[] GetDecryptString
        {
            get { return decrByteString; }
        }

        private ulong[] DecryptFile()
        {
            BasicStep[] K = new BasicStep[8];
            ulong[] ulongDecrString = new ulong[ulongString.Length];

            for (int k = 0; k < ulongString.Length; k++)
            {
                ulongDecrString[k] = ulongString[k];

                for (int i = 0; i < K.Length; i++)
                {
                    K[i] = new BasicStep(ulongDecrString[k], uintKey[i]);
                    ulongDecrString[k] = K[i].BasicEncrypt(false);
                }

                for (int j = 0; j < 3; j++)
                {
                    for (int i = K.Length - 1; i >= 0; i--)
                    {
                        K[i] = new BasicStep(ulongDecrString[k], uintKey[i]);

                        if ((j == 2) && (i == 0))
                            ulongDecrString[k] = K[i].BasicEncrypt(true);
                        else
                            ulongDecrString[k] = K[i].BasicEncrypt(false);
                    }
                }
            }

            return ulongDecrString;
        }
    }
}