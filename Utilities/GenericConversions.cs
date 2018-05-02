﻿using System;

namespace Utilities
{
    public class GenericConversions<T>
    {
        public static T Generify(object val) => (T)Convert.ChangeType(val, typeof(T));
    }
}