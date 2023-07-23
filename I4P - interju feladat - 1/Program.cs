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
                    Console.WriteLine("\n Helytelen a megadott kulcs vagy üzenet formátuma, próbáld újra!");
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

        static void Main(string[] args)
        {
            MsgEncryption();
          
            Console.ReadKey();
        }
    }
}
