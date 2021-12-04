using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenSSL.Crypto;
using OpenSSL.Core;

namespace CESEDE
{
    class Blowfish : EncryptionAlgorithm
    {
        System.Random random;
        Cipher cipher;
        CipherContext cipherContext;

        public Blowfish()
        {
            random = new System.Random();
            cipher = Cipher.Blowfish_ECB;
            cipherContext = new CipherContext(cipher);
        }

        public override byte[] Decrypt(byte[] data, byte[] key)
        {
            byte[] iv = { 0, 0, 0, 0, 0, 0, 0, 0 };
            return cipherContext.Decrypt(data, key, iv);
        }

        public override byte[] Encrypt(byte[] data, byte[] key)
        {
            byte[] iv = { 0, 0, 0, 0, 0, 0, 0, 0 };
            return cipherContext.Encrypt(data, key, iv);
        }

        public override List<byte[]> GenerateKeyPair()
        {
            // Generate 128-bit key
            byte[] key = new byte[16];
            random.NextBytes(key);
            return new List<byte[]>() { key, key };
        }

        public override string GetName()
        {
            return "Simetric - Blowfish";
        }
    }
}
