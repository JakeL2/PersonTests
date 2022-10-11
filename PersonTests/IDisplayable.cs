using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PersonTests
{
    internal interface IDisplayable
    {
        int Sizes { get; set; }

        int Size();



        int Resets { get; set; }

        int Reset();


        int Displays { get; set; }

        int Display();
    }
}
