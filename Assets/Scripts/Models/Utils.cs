﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator.Utility
{
    public static class Utils
    {
        static Random rand = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            
            return rand.Next(min, max);
        }
    }
}
