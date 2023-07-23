using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace I4P___interju_feladat___1
{
    internal class Program
    {
        private static bool MsgFormat(string msg)
        {
            Regex msgReg = new Regex(@"^([a-z]| )+$");

            return msgReg.IsMatch(msg);
        }

        private static void MsgEncryption()
        {
            string msg = string.Empty;
            string key = string.Empty;
            Encrypt encrypter = new Encrypt();
            bool msgOk = true;

            do
            {

                Console.Write("Add meg a titkosítandó üzenetet: ");
                msg = Console.ReadLine();

                Console.Write("Add meg a kulcsot az üzenethez: ");
                key = Console.ReadLine();

                if (!MsgFormat(msg) || !MsgFormat(key))
                {
                    Console.WriteLine("\n Helytelen a megadott kulcs vagy ag üzenet formátuma, próbáld újra!");
                    msgOk = false;
                }

                if (msg.Length > key.Length)
                {
                    Console.WriteLine("A kulcsnak leglább olyan hosszúnak kell lennie mint az üzenetnek!");
                    msgOk = false;
                }
            } while (!msgOk);

            Console.WriteLine($"A titkosított üzenet: {encrypter.EncryptMsg(msg, key)}");
        }

        private static void MsgDecryption()
        {
            string encMsg = string.Empty;
            string key = string.Empty;
            Decrypt decrypter = new Decrypt();
            bool msgOk = true;

            do
            {

                Console.Write("Add meg a rejtjelezett üzenetet: ");
                encMsg = Console.ReadLine();

                Console.Write("Add meg a kulcsot az üzenethez: ");
                key = Console.ReadLine();

                if (!MsgFormat(encMsg) || !MsgFormat(key))
                {
                    Console.WriteLine("\n Helytelen a megadott kulcs vagy az üzenet formátuma, próbáld újra!");
                    msgOk = false;
                }

                if (encMsg.Length > key.Length)
                {
                    Console.WriteLine("A kulcsnak leglább olyan hosszúnak kell lennie mint az üzenetnek!");
                    msgOk = false;
                }
            } while (!msgOk);

            Console.WriteLine($"Az eredeti üzenet: {decrypter.DecrypMsg(encMsg, key)}");
        }

        static void Main(string[] args)
        {
            //MsgEncryption();
            //MsgDecryption();
          
            Console.ReadKey();
        }
    }
}
