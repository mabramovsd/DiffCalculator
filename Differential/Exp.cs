﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Differential
{
    public class Exp
    {
        public static bool IsIt(String func)
        {
            return (func == "exp");
        }

        public static String Diff(String func)
        {
            return "exp";
        }
    }
}