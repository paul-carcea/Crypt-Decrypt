using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace CESEDE
{
    class GenericSymmetricAlgo : EncryptionAlgorithm
    {
        System.Random random;
        Cipher cipher;
        CipherContext cipherContext;
        int keyLength;
        string name;

        public GenericSymmetricAlgo(Cipher cipher, string name, int keyLength)
        {
            random = new System.Random();
            this.cipher = cipher;
            this.keyLength = keyLength;
            this.name = name;
            cipherContext = new CipherContext(cipher);
        }

        public override byte[] Decrypt(byte[] data, byte[] key)
        {
            byte[] iv = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            return cipherContext.Decrypt(data, key, iv);
        }

        public override byte[] Encrypt(byte[] data, byte[] key)
        {
            byte[] iv = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            return cipherContext.Encrypt(data, key, iv);
        }

        public override List<byte[]> GenerateKeyPair()
        {
            // Generate 128-bit key
            byte[] key = new byte[keyLength];
            random.NextBytes(key);
            return new List<byte[]>() { key, key };
        }

        public override string GetName()
        {
            return "Simetric - " + name;
        }
    }
}
