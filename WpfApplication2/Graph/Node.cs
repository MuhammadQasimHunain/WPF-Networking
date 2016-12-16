using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Node
    {
        public int Id { get; set; }
        public int Preveious { get; set; }
        public int Distance { get; set; }
        public Color Colour { get; set; }
        public int[] Adjesent { get; set; }
        public int Value { get; set; }
        public void DeclareAd() { Adjesent = new int[15]; }
        
        }
    }

