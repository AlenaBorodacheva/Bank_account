using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracts_Lesson_7_
{
    interface ICoder<T>
    {
        T Encode(T item);
        T Decode(T item);
    }
}
