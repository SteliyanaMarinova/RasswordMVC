using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rassword.View
{
    public class Display
    {
        public int N { get; set; }
        public int L { get; set; }
        public List<string> GeneratePassword { get;set; }
        public void Input()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            this.N = n;

            Console.Write("Enter l: ");
            int l = int.Parse(Console.ReadLine());
            this.L = l;
        }
        public void Output()
        {
            Console.WriteLine($"The generated dumb passwords are: {string.Join(", ", this.GeneratePassword)}");
        }
    }
}

