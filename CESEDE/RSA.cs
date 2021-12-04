using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenSSL.Crypto;
using OpenSSL.Core;

namespace CESEDE
{
    class RSA : EncryptionAlgorithm
    {
        System.Random random;

        public RSA()
        {
            random = new System.Random();
        }

        public override byte[] Decrypt(byte[] data, byte[] key)
        {
            BIO bio = new BIO(key);
            OpenSSL.Crypto.RSA rsa = OpenSSL.Crypto.RSA.FromPrivateKey(bio);

            return rsa.PrivateDecrypt(data, OpenSSL.Crypto.RSA.Padding.PKCS1);
        }

        public override byte[] Encrypt(byte[] data, byte[] key)
        {
            BIO bio = new BIO(key);
            OpenSSL.Crypto.RSA rsa = OpenSSL.Crypto.RSA.FromPublicKey(bio);

            return rsa.PublicEncrypt(data, OpenSSL.Crypto.RSA.Padding.PKCS1);
        }

        public override List<byte[]> GenerateKeyPair()
        {
            byte[] seed = new byte[8];
            random.NextBytes(seed);
            OpenSSL.Core.Random.Seed(seed);

            OpenSSL.Crypto.RSA rsa = new OpenSSL.Crypto.RSA();

            rsa.GenerateKeys(1024, BigNumber.One, null, null);

            return new List<byte[]>()
            {
                 Encoding.ASCII.GetBytes(rsa.PublicKeyAsPEM),
                 Encoding.ASCII.GetBytes(rsa.PrivateKeyAsPEM)
            };
        }

        public override string GetName()
        {
            return "Asimetric - RSA";
        }
    }
}
