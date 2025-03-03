﻿using System;

namespace Egate_Ecommerce
{
    public static class BoolExt
    {
        public static bool ToBool(this long value)
        {
            return value == 1 ? true : false;
        }

        public static long ToLong(this bool value)
        {
            return value ? 1 : 0;
        }

        public static bool ToBool(this int value)
        {
            return value == 1 ? true : false;
        }

        //public static int ToLong(this bool value)
        //{
        //    return value ? 1 : 0;
        //}

        public static bool? ToBool(this long? value)
        {
            if (value == null) return null;
            return (bool?)value.ToBool();
        }

        public static long? ToLong(this bool? value)
        {
            if (value == null) return null;
            return (long?)value.ToLong();
        }
    }
}
