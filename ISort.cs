using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_Interface
{
    interface ISort
    {
        void SortAsc();
        void SortDesc();
        void SortByParam(bool isAsc);
    }
}
