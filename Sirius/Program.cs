using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirius.Library;

namespace Sirius
{
    class Program
    {
        static void Main(string[] args)
        {

            var cls_sp = new Sirius.Library.Speech();
            Console.WriteLine("Hello");
            cls_sp.TextSpeech("HELLO");
            

        }
    }
}
