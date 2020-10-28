using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace RSATimings
{
    class RSACryptosys
    {
        private RSACryptoServiceProvider mRsa;
        private AesManaged mAES;

        public RSACryptosys(int bits)
        {
            mRsa = new RSACryptoServiceProvider(bits);
            mAES = new AesManaged();
        }

        public byte[] generateAESKey()
        {
            mAES.GenerateKey();
            return mAES.Key;
        }

        public byte[] encrypt(byte[] msg)
        {
            return mRsa.Encrypt(msg, true);
        }

        public byte[] decrypt(byte[] msg)
        {
            return mRsa.Decrypt(msg, true);
        }

        public byte[] signData(byte[] msg)
        {
            SHA256Managed sha256 = new SHA256Managed();
            return mRsa.SignData(msg, sha256);
        }

        public bool isSignatureOk(byte[] msg, byte[] signature)
        {
            SHA256Managed sha256 = new SHA256Managed();
            return mRsa.VerifyData(msg, sha256, signature);
        }
    }
}
