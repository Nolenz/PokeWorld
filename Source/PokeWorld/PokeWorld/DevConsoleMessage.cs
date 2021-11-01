﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace PokeWorld
{
    [StaticConstructorOnStartup]
    public static class PW_DevConsoleMessage
    {
        static PW_DevConsoleMessage() //our constructor
        {
            Log.Message("Hello from Gargamiel, the PokeWorld creator!"); //Outputs "Hello World!" to the dev console.           
        }
    }
}
