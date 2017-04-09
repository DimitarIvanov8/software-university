using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._hard__Nilapdromes
{
    class Nilapdromes
    {
        static void Main(string[] args)
        {
            string border = "";
            string core = "";

            string nilapdrom = Console.ReadLine();

            while (nilapdrom != "end")
            {

                int borderLength = 0;
                int iterations = 0;
                for (int i = nilapdrom.Length / 2; i > 0; --i)
                {
                    string currentBorder = nilapdrom.Substring(0, i);
                    string otherBorder = nilapdrom.Substring(nilapdrom.Length - i);

                    if (currentBorder == otherBorder)
                    {
                        borderLength = i;
                        break;
                    }
                    ++iterations;
                }
                if (borderLength != 0 && (iterations != 0 || nilapdrom.Length % 2 == 1))
                {
                    border = nilapdrom.Substring(0, borderLength);
                    core = nilapdrom.Substring(borderLength, nilapdrom.Length - 2 * borderLength);
                    //Console.WriteLine("test: " + nilapdrom + ", border: " + border + ", core: " + core);
                    nilapdrom = border + core + border;

                    string newNilapdrom = core + border + core;
                    Console.WriteLine(newNilapdrom);
                }


                nilapdrom = Console.ReadLine();
            }
        }
    }
}
