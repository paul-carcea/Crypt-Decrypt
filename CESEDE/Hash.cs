using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace CESEDE
{
    public class Hash
    {
        public static byte[] SHA1(byte[] input)
        {
            using(MessageDigestContext mdc = new MessageDigestContext(MessageDigest.SHA1))
            {
                return mdc.Digest(input);
            }
        }
    }
}
