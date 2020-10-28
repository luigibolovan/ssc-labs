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
            byte[] key = myCryptoSys1024.generateAESKey();
            timer.Stop();
            long time1024key = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] rsaCipher = myCryptoSys1024.encrypt(key);
            timer.Stop();
            long time1024encrpyt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] decryptedPlainText = myCryptoSys1024.decrypt(rsaCipher);
            timer.Stop();
            long time1024decrypt = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            byte[] signature = myCryptoSys1024.signData(Encoding.ASCII.GetBytes(input));
            timer.Stop();
            long time1024sign = timer.ElapsedMilliseconds;

            timer.Reset();
            timer.Start();
            bool dataOk = myCryptoSys1024.isSignatureOk(Encoding.ASCII.GetBytes(input), signature);
            timer.Stop();
            long time1024verify = timer.ElapsedMilliseconds;

            Console.WriteLine("RSA - 1024");
            Console.WriteLine("Key generation time: " + time1024key);
            Console.WriteLine("Encryption time: " + time1024encrpyt);
            Console.WriteLine("Decryption time: " + time1024decrypt);
            Console.WriteLine("Signature generation time: " + time1024sign);
            Console.WriteLine("Verification: " + dataOk + "\nVerification time: " + time1024verify);


            Console.ReadKey();



        }
    }
}
