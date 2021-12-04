using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESEDE
{
    public abstract class EncryptionAlgorithm
    {
        public abstract string GetName();

        public abstract List<byte[]> GenerateKeyPair();

        public abstract byte[] Encrypt(byte[] data, byte[] key);

        public abstract byte[] Decrypt(byte[] data, byte[] key);

    }
}
