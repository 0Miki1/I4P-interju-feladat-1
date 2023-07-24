using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4P___interju_feladat___1
{
    public class Encrypt : Transfer
    {
        public string EncryptMsg(string msg, string key)
        {
            int msgLenght = msg.Length;
            string encryptedMsg = string.Empty;

            for (int i = 0; i < msgLenght; i++)
            {
                int msgCode = GetCharCode(msg[i]);
                int keyCode = GetCharCode(key[i]);
                int encryptedCode = msgCode + keyCode;

                if (encryptedCode > 26)
                {
                    encryptedCode = encryptedCode % 27;
                }

                encryptedMsg += GetChar(encryptedCode);
            }

            return encryptedMsg;
        }
    }
}
