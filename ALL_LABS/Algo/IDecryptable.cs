using System;

namespace ALL_LABS.Algo
{
    public interface IDecryptable
    {
        String Decode(String data, String key);

        byte[] Decode(byte[] data, String key);

        byte[] Decode(byte[] data, byte[] key);
    }
}
