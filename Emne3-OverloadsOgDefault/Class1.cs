using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emne3_OverloadsOgDefault
{
    internal class Class1
    {
        string Name { get; set; }
        string Text { get; set; }

        public Class1(string text, string name)
        {
            Name = name;
            Text = text;
        }

        public void printInfo()
        {
            Console.WriteLine(Text);
        }

        public void printInfo(string extraInfo)
        {
            Console.WriteLine(Text + extraInfo);
        }


    }
}
