using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rassword.Model
{
    public class Password
    {
        private int n;

        public int N
        {
            get { return n; }
            set { n = value; }
        }
        private int l;

        public int L
        {
            get { return l; }
            set { l = value; }
        }

        public Password(int n, int l)
        {
            this.n = n;
            this.l = l;
        }
        public Password()
        {

        }
        internal List<string> GeneratePassword()
        {
            List<string> passwords = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n; k++)
                {
                    for (char d = (char)097; d < (char)097 + l; d++)
                    {
                        for (char e = (char)097; e < (char)097 + l; e++)
                        {
                            for (int m = 1; m <= n; m++)
                            {
                                if (m > i && m > k)
                                {
                                    passwords.Add($"{i}{k}{d}{e}{m}");
                                }
                            }
                        }
                    }
                }
            }
            passwords.Sort();
            return passwords;
        }
    }
}
