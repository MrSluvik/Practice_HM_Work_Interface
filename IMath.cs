using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Interface
{
    interface IMath
    {
        int Max();
        int Min();
        float Avg();
        bool Search(int valueToSearch);
    }
}
