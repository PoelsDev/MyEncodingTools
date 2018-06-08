using System;

namespace MyEncodingTools
{
    public class EncodingTools
    {
        public static string RunLengthDecode(string str)
        {
            /*
            string r = "";
            
            int c = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str != "")
                {
                    if (str[i] == str[i + 1])
                    {
                        c++;
                    }
                    else
                    {
                        r += c;
                        r += str[i];
                        c = 1;
                    }
                }
                else
                {
                    r = "";
                }
            }
            
            
            return r;
            */

            string r = "";
            int count = 0;
            char c = ' ';

            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if (!Char.IsDigit(str[i])) return "";
                    count = int.Parse(str.Substring(i, 1));
                }
                else
                {
                    if (!Char.IsLetter(str[i])) return "";
                    c = str[i];
                    r += new string(c, count);
                }
            }

            return r;
        }

        public static string RunLengthEncode(string str)
        {                        
            string r = "";

            int c = 1;
            str = str + " ";
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str != "")
                {
                    if (str[i] == str[i + 1])
                    {
                        c++;
                    }
                    else
                    {
                        r += c;
                        r += str[i];
                        c = 1;
                    }
                }
                else
                {
                    r = "";
                }
            }


            return r;            
        }
    }
}
