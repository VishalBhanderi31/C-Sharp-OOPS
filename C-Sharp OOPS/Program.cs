using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text {Width = 10f}; // Here we use ObjectInitializer to use Width property
            text.Copy();
        }
    }
}
