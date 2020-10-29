using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSATimings
{
    class Program
    {
        static void Main(string[] args)
        {
            RSACryptosys myCryptoSys1024 = new RSACryptosys(1024);
            RSACryptosys myCryptoSys2048 = new RSACryptosys(2048);
            RSACryptosys myCrpytoSys3072 = new RSACryptosys(3072);
            RSACryptosys myCrpytoSys4096 = new RSACryptosys(4096);
            string input = "my test string;";
            Stopwatch timer = new Stopwatch();


            timer.Start();
            byte[] key1024 = myCryptoSys1024.generateAESKey();
            timer.Stop();
            long time1024key = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] rsa1024Cipher = myCryptoSys1024.encrypt(key1024);
            timer.Stop();
            long time1024encrpyt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] decrypted1024PlainText = myCryptoSys1024.decrypt(rsa1024Cipher);
            timer.Stop();
            long time1024decrypt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] signature1024rsa = myCryptoSys1024.signData(Encoding.ASCII.GetBytes(input));
            timer.Stop();
            long time1024sign = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            bool data1024Ok = myCryptoSys1024.isSignatureOk(Encoding.ASCII.GetBytes(input), signature1024rsa);
            timer.Stop();
            long time1024verify = timer.ElapsedMilliseconds;
            timer.Reset();

            Console.WriteLine("RSA - 1024");
            Console.WriteLine("Key generation time: " + time1024key + "\nKey: " + getHEXStringFromBytes(key1024));
            Console.WriteLine("Encryption time: " + time1024encrpyt + "\nCipherText: " + getHEXStringFromBytes(rsa1024Cipher));
            Console.WriteLine("Decryption time: " + time1024decrypt + "\nPlain text after decryption: " + getHEXStringFromBytes(decrypted1024PlainText));
            Console.WriteLine("Signature generation time: " + time1024sign + "\nSignature: " + getHEXStringFromBytes(signature1024rsa));
            Console.WriteLine("Verification: " + data1024Ok + "\nVerification time: " + time1024verify);
            Console.WriteLine();

            timer.Start();
            byte[] key2048 = myCryptoSys2048.generateAESKey();
            timer.Stop();
            long time2048key = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] rsa2048Cipher = myCryptoSys2048.encrypt(key2048);
            timer.Stop();
            long time2048encrpyt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] decrypted2048PlainText = myCryptoSys2048.decrypt(rsa2048Cipher);
            timer.Stop();
            long time2048decrypt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] signature2048rsa = myCryptoSys2048.signData(Encoding.ASCII.GetBytes(input));
            timer.Stop();
            long time2048sign = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            bool data2048Ok = myCryptoSys2048.isSignatureOk(Encoding.ASCII.GetBytes(input), signature2048rsa);
            timer.Stop();
            long time2048verify = timer.ElapsedMilliseconds;
            timer.Reset();

            Console.WriteLine();
            Console.WriteLine("RSA - 2048");
            Console.WriteLine("Key generation time: " + time2048key + "\nKey: " + getHEXStringFromBytes(key2048));
            Console.WriteLine("Encryption time: " + time2048encrpyt + "\nCipherText: " + getHEXStringFromBytes(rsa2048Cipher));
            Console.WriteLine("Decryption time: " + time2048decrypt + "\nPlain text after decryption: " + getHEXStringFromBytes(decrypted2048PlainText));
            Console.WriteLine("Signature generation time: " + time2048sign + "\nSignature: " + getHEXStringFromBytes(signature2048rsa));
            Console.WriteLine("Verification: " + data2048Ok + "\nVerification time: " + time2048verify);
            Console.WriteLine();


            timer.Start();
            byte[] key3072 = myCrpytoSys3072.generateAESKey();
            timer.Stop();
            long time3072key = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] rsa3072Cipher = myCrpytoSys3072.encrypt(key3072);
            timer.Stop();
            long time3072encrpyt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] decrypted3072PlainText = myCrpytoSys3072.decrypt(rsa3072Cipher);
            timer.Stop();
            long time3072decrypt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] signature3072rsa = myCrpytoSys3072.signData(Encoding.ASCII.GetBytes(input));
            timer.Stop();
            long time3072sign = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            bool data3072Ok = myCrpytoSys3072.isSignatureOk(Encoding.ASCII.GetBytes(input), signature3072rsa);
            timer.Stop();
            long time3072verify = timer.ElapsedMilliseconds;
            timer.Reset();

            Console.WriteLine();
            Console.WriteLine("RSA - 3072");
            Console.WriteLine("Key generation time: " + time3072key + "\nKey: " + getHEXStringFromBytes(key3072));
            Console.WriteLine("Encryption time: " + time3072encrpyt + "\nCipherText: " + getHEXStringFromBytes(rsa3072Cipher));
            Console.WriteLine("Decryption time: " + time3072decrypt + "\nPlain text after decryption: " + getHEXStringFromBytes(decrypted3072PlainText));
            Console.WriteLine("Signature generation time: " + time3072sign + "\nSignature: " + getHEXStringFromBytes(signature3072rsa));
            Console.WriteLine("Verification: " + data3072Ok + "\nVerification time: " + time3072verify);
            Console.WriteLine();

            timer.Start();
            byte[] key4096 = myCrpytoSys4096.generateAESKey();
            timer.Stop();
            long time4096key = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] rsa4096Cipher = myCrpytoSys4096.encrypt(key4096);
            timer.Stop();
            long time4096encrpyt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] decrypted4096PlainText = myCrpytoSys4096.decrypt(rsa4096Cipher);
            timer.Stop();
            long time4096decrypt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] signature4096rsa = myCrpytoSys4096.signData(Encoding.ASCII.GetBytes(input));
            timer.Stop();
            long time4096sign = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            bool data4096Ok = myCrpytoSys4096.isSignatureOk(Encoding.ASCII.GetBytes(input), signature4096rsa);
            timer.Stop();
            long time4096verify = timer.ElapsedMilliseconds;
            timer.Reset();

            Console.WriteLine();
            Console.WriteLine("RSA - 4096");
            Console.WriteLine("Key generation time: " + time4096key + "\nKey: " + getHEXStringFromBytes(key4096));
            Console.WriteLine("Encryption time: " + time4096encrpyt + "\nCipherText: " + getHEXStringFromBytes(rsa4096Cipher));
            Console.WriteLine("Decryption time: " + time4096decrypt + "\nPlain text after decryption: " + getHEXStringFromBytes(decrypted4096PlainText));
            Console.WriteLine("Signature generation time: " + time4096sign + "\nSignature: " + getHEXStringFromBytes(signature4096rsa));
            Console.WriteLine("Verification: " + data4096Ok + "\nVerification time: " + time4096verify);
            Console.WriteLine();

            Console.ReadKey();

        }

        private static String getHEXStringFromBytes(byte[] msg)
        {
            return BitConverter.ToString(msg).Replace("-", "");               
        }
    }
}
