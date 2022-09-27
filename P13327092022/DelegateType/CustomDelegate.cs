using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateType
{
    public delegate bool Check(int num);

    public delegate Tresult Write<in T1, out Tresult>(T1 item);
    public delegate Tresult Write<in T1,in T2, out Tresult>(T1 item);
}
