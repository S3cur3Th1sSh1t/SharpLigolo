using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SharpLigolo
{
    class Program
    {

        [DllImport("main.dll", EntryPoint = "maindel")]
        extern static int maindel(byte[] test);

        static void Main(string[] args)
        {
            string argsAsString = String.Join(" ", args);
            maindel(Encoding.ASCII.GetBytes(argsAsString));
        }

    }
}
