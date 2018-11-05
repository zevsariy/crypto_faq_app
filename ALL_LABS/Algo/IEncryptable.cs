using System;

namespace ALL_LABS.Algo
{
    public interface IEncryptable
    {
        String Encode(String data, String key);

        byte[] Encode(byte[] data, String key);

        byte[] Encode(byte[] data, byte[] key);
    }
}
