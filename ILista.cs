﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aeropuerto
{
    interface ILista<E>
    {
        void add(E e);
        E get(int Index);
        int size();
        void Clear();
        Boolean isEmpty();
    }
}
