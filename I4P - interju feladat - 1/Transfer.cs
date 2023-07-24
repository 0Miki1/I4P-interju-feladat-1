using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4P___interju_feladat___1
{
    public class Transfer
    {
        protected int GetCharCode(char character)
        {
            if (character == ' ')
            {
                return 26;
            }

            return character - 'a';
        }

        protected char GetChar(int code)
        {
            if (code == 26)
            {
                return ' ';
            }

            return (char)('a' + code);
        }
    }
}
