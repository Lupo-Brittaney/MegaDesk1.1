using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_BrittaneyLupo
{
    class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DeskMaterial DeskMaterial { get; set; }

        //Constants - Limits for the width and depth
        public const int MINWIDTH = 24;
        public const int MINDEPTH = 12;
        public const int MAXWIDTH = 96;
        public const int MAXDEPTH = 48;
        


    }
    public enum DeskMaterial
    {
        Pine = 50,
        Laminate = 100,
        Oak = 200,
        Rosewood = 300,
        Veneer = 125
    }
}
