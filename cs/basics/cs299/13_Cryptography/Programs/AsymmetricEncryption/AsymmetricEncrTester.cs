using System;
namespace Encryption
{
    public class AsymetricEncrTester
    {
        //[TestMethod]
        //public void EncryptionRSATest()
        public static void Main()
        {
            int keySize = 1024;
            var keys = EncryptorRSA.GenerateKeys(keySize);

            string text = "text for encryption";

            string encrypted = EncryptorRSA.EncryptText(text, keys.PublicKey);
            string decrypted = EncryptorRSA.DecryptText(encrypted, keys.PrivateKey);
            Console.WriteLine(decrypted);
            //Assert.IsTrue(text == decrypted);
        }
    }// class
}// namespace


