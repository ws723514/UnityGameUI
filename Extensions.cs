﻿using System;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace UnityGameUI
{
    internal delegate bool d_LoadImage(IntPtr tex, IntPtr data, bool markNonReadable);
    internal delegate bool parseHTMLString(IntPtr HTMLString, IntPtr result);

    internal static class Extensions
    {
        // Load Image ICall

        // Convert Hex string to Color32
        public static Color32 HexToColor(this string hexString)
        {
            string tmp = hexString;

            if (tmp.IndexOf('#') != -1)
                tmp = tmp.Replace("#", "");

            byte r = 0, g = 0, b = 0, a = 0;

            r = Convert.ToByte(tmp.Substring(0, 2), 16);
            g = Convert.ToByte(tmp.Substring(2, 2), 16);
            b = Convert.ToByte(tmp.Substring(4, 2), 16);
            if (tmp.Length == 8)
                a = Convert.ToByte(tmp.Substring(6, 2), 16);

            return new Color32(r, g, b, a);
        }

        public static int ConvertToIntDef(this string input, int defaultValue)
        {
            int result;
            if (int.TryParse(input, out result))
            {
                return result;
            }
            return defaultValue;
        }

    }
}
