﻿using System;
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
            char.ToLower(character);

            if (character == ' ')
            {
                return 26;
            }

            return character - 'a';
        }

        protected char GetChar(int code)
        {
            if (code < 0)
            {
                code += 27;
            }
            else if (code == 26)
            {
                return ' ';
            }
            else if (code > 26)
            {
                code %= 27;
            }

            return (char)('a' + code);
        }
    }
}
