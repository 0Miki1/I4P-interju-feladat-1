using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.ComponentModel.Design;

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
            Console.Clear();

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
            Console.Clear();

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

        private static void Menu()
        {
            Console.Clear();

            bool inputOK = true;
            int input = 0;

            do
            {
                Console.WriteLine("1 - Titkosítás\n2 - Visszafejtés\n3 - Kilépés");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    inputOK = false;
                }

                inputHandler(input);
            } while (input < 1 || input > 3 || !inputOK);
        }

        private static void inputHandler(int input)
        {
            switch (input)
            {
                case 1:
                    MsgEncryption();
                    break;
                case 2:
                    MsgDecryption();
                    break;
            }

            Console.WriteLine("\nA menübe visszalépéshez nyomjon meg egy gombot!");

            Console.ReadKey();

            Menu();
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}
