﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ControlWork
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UserInterface();
            ui.DisplayFactorial();
            ui.DisplaySort();
            ui.DisplayEncryptedWord();
        }
    }
}
