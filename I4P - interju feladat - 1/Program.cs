using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4P___interju_feladat___1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encrypt e = new Encrypt();

            string msg = string.Empty;
            string key = string.Empty;

            Console.Write("Üzenet: ");
            msg = Console.ReadLine();

            Console.Write("Kulcs: ");
            key = Console.ReadLine();

            Console.WriteLine(e.EncryptMsg(msg, key));

            Console.ReadKey();
        }
    }
}
