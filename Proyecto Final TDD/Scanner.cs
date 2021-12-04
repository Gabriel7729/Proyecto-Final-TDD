using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Proyecto_Final_TDD
{
    public class Scanner : System.IO.StringReader
    {
        string currentWord;

        public Scanner(string source) : base(source)
        {
            readNextWord();
        }

        private void readNextWord()
        {
            System.Text.StringBuilder sb = new StringBuilder();
            char nextChar;
            int next;
            do
            {
                next = this.Read();
                if (next < 0)
                    break;
                nextChar = (char)next;
                if (char.IsWhiteSpace(nextChar))
                    break;
                sb.Append(nextChar);
            } while (true);
            while ((this.Peek() >= 0) && (char.IsWhiteSpace((char)this.Peek())))
                this.Read();
            if (sb.Length > 0)
                currentWord = sb.ToString();
            else
                currentWord = null;
        }

        public bool hasNextInt()
        {
            if (currentWord == null)
                return false;
            int dummy;
            return int.TryParse(currentWord, out dummy);
        }

        public int nextInt()
        {
            try
            {
                return int.Parse(currentWord);
            }
            finally
            {
                readNextWord();
            }
        }

        public bool hasNextDouble()
        {
            if (currentWord == null)
                return false;
            double dummy;
            return double.TryParse(currentWord, out dummy);
        }

        public double nextDouble()
        {
            try
            {
                return double.Parse(currentWord);
            }
            finally
            {
                readNextWord();
            }
        }

        public bool hasNext()
        {
            return currentWord != null;
        }
    }
    public class PacketReader : StringReader
    {
        public PacketReader(string s)
            : base(s)
        {
        }

        public T ReadNext<T>() where T : IConvertible
        {
            var sb = new StringBuilder();

            do
            {
                var current = Read();
                if (current < 0)
                    break;

                sb.Append((char)current);

                var next = (char)Peek();
                if (char.IsWhiteSpace(next))
                    break;

            } while (true);

            var value = sb.ToString();

            var type = typeof(T);
            if (type.IsEnum)
                return (T)Enum.Parse(type, value);

            return (T)((IConvertible)value).ToType(typeof(T), System.Globalization.CultureInfo.CurrentCulture);
        }

    }
}
