using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4P___interju_feladat___1
{
    public class Decrypt : Transfer
    {
        public string DecrypMsg(string encryptedMsg, string key)
        {
            int encryptedMsgLength = encryptedMsg.Length;
            string decryptedMsg = string.Empty;

            for (int i = 0; i < encryptedMsgLength; i++)
            {
                //A more detailed code decryption
                /*
                int encMsgCharCode = GetCharCode(encryptedMsg[i]);
                int keyCode = GetCharCode(key[i]);
                int msgCharCode = encMsgCharCode - keyCode;

                if (msgCharCode < 0)
                {
                    msgCharCode += 27;
                }

                decryptedMsg += GetChar(msgCharCode);
                */

                //A simplified code for decryption
                decryptedMsg += GetChar(GetCharCode(encryptedMsg[i]) - GetCharCode(key[i]));
            }

            return decryptedMsg;
        }
    }
}
