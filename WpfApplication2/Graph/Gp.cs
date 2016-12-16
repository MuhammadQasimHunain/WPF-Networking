using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    class Gp
    {
        public int Size { get; set; }
        public Node[] Elements { get; set; }

        public Gp(int si)
        {
            Size = si;
            Elements = new Node[Size ];
            for (int i = 0; i < Size; i++)
            {
                Elements[i] = new Node();
                Elements[i].DeclareAd();
            }
        }
        public Node GetNode(int key)
        {
            for (int i = 0; i < Size; i++)
            {
                if (Elements[i].Value == key)
                {
                    return Elements[i];
                }
            }
            return null;
        }
        public void BFS(Gp g, Node s)
        {
            Queue<Node> Que = new Queue<Node>();
            Node u = null;
            for (int i = 0; i < Size; i++)
            {
                g.Elements[i].Colour = Color.White;
                g.Elements[i].Distance = 0;
                g.Elements[i].Preveious = 0;
            }
            s.Colour = Color.Grey;
            s.Distance = 0;
            s.Preveious = 0;
            Que.Enqueue(s);
            while (Que.Count > 0)
            {
                u = Que.Dequeue();
                for (int i = 0; i < Size; i++)
                {
                    if (u.Adjesent[i] != 0)
                    {
                        if (g.GetNode(i + 1).Colour.ToString().Equals(Color.White.ToString()))
                        {
                            g.GetNode(i + 1).Colour = Color.Grey;
                            g.GetNode(i + 1).Distance = g.GetNode(i + 1).Distance + 1;
                            g.GetNode(i + 1).Preveious = u.Value;
                            Que.Enqueue(g.GetNode(i + 1));
                        }
                    }
                }
                u.Colour = Color.Black;
                Console.WriteLine();
                string ss = null;
                if (!u.Preveious.Equals(null))
                {
                    ss = u.Preveious.ToString();
                }
                else
                {
                    ss = "First Node";
                }

                Console.WriteLine("Node: {0} From Node:{1}", u.Value, ss);
            }
            #region Blank
            //int temp = int.MaxValue;
            //List<int> it = new List<int>();
            //Node te = g.GetNode(3);
            //it.Add(g.GetNode(3).Value);
            //while (temp != 0)
            //{
            //    it.Add(te.Preveious);
            //    te = g.GetNode(te.Preveious);
            //    temp = te.Preveious;
            //}
            //foreach (var item in it.ToArray().Reverse())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
        }

        public List<int> Tracking(Gp g, Node s, Node Destination)
        {
            Queue<Node> Que = new Queue<Node>();
            Node u = null;
            for (int i = 0; i < Size; i++)
            {
                g.Elements[i].Colour = Color.White;
                g.Elements[i].Distance = 0;
                g.Elements[i].Preveious = 0;
            }
            s.Colour = Color.Grey;
            s.Distance = 0;
            s.Preveious = 0;
            Que.Enqueue(s);
            while (Que.Count > 0)
            {
                u = Que.Dequeue();
                for (int i = 0; i < Size; i++)
                {
                    if (u.Adjesent[i] != 0)
                    {
                        if (g.GetNode(i + 1).Colour.ToString().Equals(Color.White.ToString()))
                        {
                            g.GetNode(i + 1).Colour = Color.Grey;
                            g.GetNode(i + 1).Distance = g.GetNode(i + 1).Distance + 1;
                            g.GetNode(i + 1).Preveious = u.Value;
                            Que.Enqueue(g.GetNode(i + 1));
                        }
                    }
                }
                u.Colour = Color.Black;
            }
            int temp = int.MaxValue;
            List<int> it = new List<int>();
            Node te = g.GetNode(Destination.Value);
            it.Add(g.GetNode(Destination.Value).Value);
            while (temp != 0)
            {
                it.Add(te.Preveious);
                te = g.GetNode(te.Preveious);
                temp = te.Preveious;
            }
            return it.ToArray().Reverse().ToList();
        }
    }
}