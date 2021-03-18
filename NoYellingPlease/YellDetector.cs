using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoYellingPlease
{
    public class YellDetector
    {
        private readonly string _yell;

        public YellDetector(string yell)
        {
            _yell = yell;
        }

        public string ReverseLoop()
        {
            int charCount = 0;
            for (int i = _yell.Length - 1; i >= 0; i--)
            {
                var c = _yell[i];
                if (c == '!' || c == '?') charCount++;
            }
            return _yell.Substring(0, _yell.Length - charCount + 1);
        }
    }
}
